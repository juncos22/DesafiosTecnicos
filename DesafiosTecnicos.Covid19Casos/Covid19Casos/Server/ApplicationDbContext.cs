using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using Covid19Casos.Shared;

namespace Covid19Casos.Server
{
    /// <summary>
    /// Esta es la clase que se va a encargar de realizar las operaciones
    /// a la base de datos alojada en la carpeta 'Data'.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, 
            IConfiguration configuration) : base(options)
        {
            // Esta linea de codigo va a hacer que se asegure de crear la base de datos
            // en el archivo Covid19Casos.db de la carpeta 'Data'.
            Database.EnsureCreated(); 
            this.configuration = configuration;
        }

        // El objeto DbSet<Caso> se usara para realizar las operaciones de A.B.M a la base de datos.
        public virtual DbSet<Caso> Casos { get; set; }

        /// <summary>
        /// Metodo para leer la informacion disponible en el archivo Covid19Casos.csv
        /// </summary>
        /// <returns>La lista con los registros obtenidos del archivo .csv</returns>
        public List<Caso> CargarInfo()
        {
            // Creacion de una lista de objetos 'Caso' vacia.
            var casosList = new List<Caso>();
            try
            {
                // Se obtiene la ruta del archivo .csv para poder leer su contenido.
                string filePath = configuration.GetSection("FileData").Value;
                if (File.Exists(filePath))
                {
                    // Si el archivo existe, lo va a abrir para su lectura.
                    var reader = new StreamReader(File.OpenRead(filePath));

                    // Mientras el contenido del archivo no se haya terminado de leer, va a 
                    // ir capturando linea por linea los registros.
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine(); // Captura cada linea de los registros.
                        var campos = linea.Split(','); // Crea un arreglo de cada campo separado por comas.

                        // En la lista creada anteriormente, ira creando y guardando los objetos Caso
                        // con los campos de interés (Fecha - Edad - Genero - Provincia).
                        casosList.Add(new Caso
                        {
                            Fecha = DateTime.Parse(campos[9]),
                            Edad = int.Parse(campos[2]),
                            Genero = campos[1],
                            Provincia = campos[5]
                        });

                    }
                    // Una vez que se termino de leer el archivo, se debe cerrar la conexion del lector.
                    reader.Close();
                }
                else
                {
                    // En caso de que el archivo no exista, imprimirá un mensaje.
                    Console.WriteLine("No se encontro el archivo");
                }

            } // Se controlan las excepciones mediante un bloque try/catch.
            catch (Exception e)
            {
                Console.WriteLine($"Data Error: {e.Message}");
            }
            // Se devuelve la lista de casos leidos del archivo .csv
            return casosList;
        }
    }
}
