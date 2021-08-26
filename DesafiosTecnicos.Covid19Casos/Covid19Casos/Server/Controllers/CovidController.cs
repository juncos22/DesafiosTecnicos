using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19Casos.Shared;

namespace Covid19Casos.Server.Controllers
{
    /// <summary>
    /// Clase que será el controlador con todos los endpoints a los que acceda el usuario.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CovidController : ControllerBase
    {
        // Atributo inyectado que maneja las operaciones a la base de datos.
        private readonly ApplicationDbContext _db;

        // Le realiza la inyección de dependencias en el constructor.
        public CovidController(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Método de prueba para obtener los registros de la lista de casos
        /// y guardarlos en la base de datos sqlite por medio de tareas asíncronas.
        /// </summary>
        /// <returns>El resultado de los registros guardados.</returns>
        public async Task<CasoResponse> Get()
        {
            //Se crea un objeto del tipo CasoResponse que será enviado con toda la
            //informacion de los casos.
            var response = new CasoResponse();
            try
            {
                //       Primero se realiza una consulta a la base de datos
                //para corroborar si tiene algun registro.
                var casos = (from c in _db.Casos
                             select c).ToList();

                List<ListCasoViewModel> casosList = new();
                //  En caso de no haber encontrado ningun registro, va a buscar la informacion del archivo
                //.csv para guardarla en la base de datos.
                if (casos.Count == 0)
                {
                    casos = _db.CargarInfo();

                    await _db.Casos.AddRangeAsync(casos);
                    await _db.SaveChangesAsync();
                }
                //En cualquier caso, sea que encuentre o no la informacion, va a guardarla en la lista de
                //objetos ListCasoViewModel para poder devolverla como respuesta al usuario.
                casos.ForEach(c => casosList.Add(new ListCasoViewModel
                {
                    Fecha = c.Fecha,
                    Edad = c.Edad,
                    Genero = c.Genero,
                    Provincia = c.Provincia
                }));
                //Si todo ha ido bien, el codigo de respuesta será 200 y la data será la lista de objetos
                //ListCasoViewModel que recibirá el usuario.
                response.StatusCode = 200;
                response.Data = casosList;
            }
            catch (Exception e) /*Se controlan cualquier excepción que pueda ocurrir, en caso de ser asi,*/
            {
                //la respuesta devolvera un codigo 400 y como mensaje recibirá el mensaje
                //de la excepción para enviarla al usuario.
                response.StatusCode = 400;
                response.Mensaje = e.Message;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// Metodo GET para obtener el total de casos filtrado por Rango de Fechas, Rango de Edades,
        /// Genero y Provincia. La url proveniente de la peticion será http://localhost:53463/covid/total
        /// </summary>
        /// <param name="fechaInicio">La fecha inicial del caso.</param>
        /// <param name="fechaFin">La fecha final del caso.</param>
        /// <param name="edadInicio">La edad inicial del caso.</param>
        /// <param name="edadFin">La edad final del caso.</param>
        /// <param name="genero">El genero correspondiente a las personas afectadas.</param>
        /// <param name="provincia">La provincia proviniente de las personas afectadas.</param>
        /// <returns>
        /// La respuesta como objeto CasoResponse que obtendrá el codigo de estado de la petición,
        /// el mensaje de la respuesta (en caso de fallar), y el objeto Data como una lista 
        /// de casos del objeto ListCasoViewModel.
        /// </returns>
        [HttpGet("total")]
        public async Task<CasoResponse> Total(DateTime FechaInicio, DateTime FechaFin, int EdadInicio, 
            int EdadFin, string Genero, string Provincia)
        {
            // Se crea el objeto de tipo CasoResponse donde se guardará la respuesta para el usuario.
            var response = new CasoResponse();
            try
            {
                // Se realiza la consulta por medio de Linq a la base de datos, filtrando por
                // los campos y parametros establecidos.
                var casos = (from c in _db.Casos
                             where c.Fecha >= FechaInicio.Date && c.Fecha <= FechaFin.Date
                             || c.Edad >= EdadInicio && c.Edad <= EdadFin
                             || c.Genero == Genero || c.Provincia == Provincia
                             select new ListCasoViewModel
                             {
                                 Fecha = c.Fecha,
                                 Edad = c.Edad,
                                 Genero = c.Genero,
                                 Provincia = c.Provincia
                             }).ToList();

                // En caso de tener exito, el objeto response devolvera el codigo de estado 200 y 
                // la lista de casos como objeto List<ListCasoViewModel>
                response.StatusCode = 200;
                response.Data = casos;
            }
            catch (Exception e)
            {
                // Imprime el mensaje de la excepción.
                Console.WriteLine($"QUERY ERROR: {e.Message}");

                // En caso de fallar, el objeto response devolverá el código de estado 400 y 
                // un mensaje de error.
                response.StatusCode = 400;
                response.Mensaje = "Hubo un error al consultar la información.";
            }
            // Se devuelve el resultado por medio del metodo OK que guardará el objeto response.
            return await Task.FromResult(response);
        }

        /// <summary>
        /// Metodo para agregar nuevos registros de casos.
        /// La url proveniente de la peticion será http://localhost:53463/covid/update
        /// </summary>
        /// <param name="model">El modelo de datos como un objeto de tipo CasoViewModel</param>
        /// <returns>La respuesta de tipo CasoResponse que mostrará la informacion al usuario.</returns>
        [HttpPost("update")]
        public async Task Update(CasoViewModel model)
        {
            try
            {
                // Se crea el objeto de datos tipo Caso donde, por medio del modelo de datos
                // CasoViewModel, llenará la información de cada atributo de la clase Caso.
                Caso caso = new Caso
                {
                    Fecha = model.Fecha.Date,
                    Edad = model.Edad,
                    Genero = model.Genero,
                    Provincia = model.Provincia
                };

                // Por medio del objeto _db de tipo ApplicationDbContext se guardará el nuevo registro
                // de tipo Caso en la base de datos.
                await _db.Casos.AddAsync(caso);
                // Se guardan los cambios en la base de datos.
                await _db.SaveChangesAsync();

            }
            catch (Exception e)
            {
                // Se imprime e mensaje de la excepción para saber la raíz del problema.
                Console.WriteLine($"DATA ERROR: {e.Message}");
            }
        }
    }
}
