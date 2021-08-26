using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlarNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidarNombre("Edgar A. Poe"));
            Console.ReadLine();
        }

        /// <summary>
        /// Funcion donde se evalua el nombre completo
        /// </summary>
        /// <param name="nombre">El nombre completo a evaluar</param>
        /// <returns>
        /// Si el nombre pasa todas las validaciones y posibilidades logicas, devolvera True.
        /// De lo contrario devolvera False.
        /// </returns>
        public static bool ValidarNombre(string nombre)
        {
            // Se divide la palabra, separandola por los espacios en blanco.
            // De esta forma se creara un arreglo de cadenas de texto.
            var palabras = nombre.Split(' ');
            // Variable para validar el nombre
            bool nombreValido;

            // Como solamente se permiten 2 o 3 entradas, se evalua que las mismas 
            // Sean mayores a 1
            if (palabras.Length == 2)
            {
                // La primera posibilidad es igual para todas las palabras,
                // Deben estar capitalizadas sin ninguna excepción, de lo contrario se 
                // asigna directamente False a la variable 'nombreValido'.
                if (EstaCapitalizada(palabras[0]) 
                    && EstaCapitalizada(palabras[1]))
                {
                    // La siguiente posibilidad sera que las 2 palabras sean nombres completos, 
                    // de lo contrario evalua la siguiente posibilidad.
                    if (EsNombreCompleto(palabras[0]) 
                        && EsNombreCompleto(palabras[1]))
                    {
                        nombreValido = true;
                    }
                    else if (EsInicial(palabras[0]) && !EsInicial(palabras[1]))
                    {
                        // En la siguiente posibilidad se evalua que la primera palabra sea una inicial
                        // pero que la segunda no lo sea, debido a que los apellidos no pueden ser iniciales 
                        // en este caso, de lo contrario el nombre sera inválido.
                        nombreValido = true;
                    }
                    else
                    {
                        nombreValido = false;
                    }
                }
                else
                {
                    nombreValido = false;
                }
            }
            else if (palabras.Length == 3)
            {
                // En el caso de que las palabras sean 3, se validan de la misma forma que 
                // las otras, que esten capitalizadas cada una, sin excepción,
                // de lo contrario el nombre sera inválido de entrada.
                if (EstaCapitalizada(palabras[0]) 
                    && EstaCapitalizada(palabras[1]) 
                    && EstaCapitalizada(palabras[2]))
                {
                    // Al igual que los nombres de 3 palabras, se evalua si son nombres completos,
                    // de ser asi, el nombre será valido, de lo contrario buscara la siguiente posibilidad.
                    if (EsNombreCompleto(palabras[0]) 
                        && EsNombreCompleto(palabras[1])
                        && EsNombreCompleto(palabras[2]))
                    {
                        nombreValido = true;
                    }
                    else if (EsInicial(palabras[0]) // En la siguiente posibilidad, evalua si las 2 primeras
                        && EsInicial(palabras[1])   // palabras son iniciales, pero la 3 no, en caso de 
                        && !EsInicial(palabras[2])) // ser asi el nombre sera valido, de lo contrario
                    {                               // pasa a la siguiente posibilidad
                        nombreValido = true;
                    }
                    else if (!EsInicial(palabras[0]) && EsNombreCompleto(palabras[0])
                        && EsInicial(palabras[1])
                        && !EsInicial(palabras[2])) // La ultima posibilidad será que el primer nombre
                    {                               // no sea una inicial y que sea un nombre completo
                        nombreValido = true;        // ademas de que el segundo nombre sea inicial, y 
                    }                               // el apellido no lo sea, de lo contrario 
                    else                            // el nombre ingresado será invalido.
                    {
                        nombreValido = false;
                    }
                }
                else
                {
                    nombreValido = false;
                }
            }
            else 
            {
                nombreValido = false;
            }

            return nombreValido;
        }

        /// <summary>
        /// Funcion para validar los nombres con punto que no son iniciales.
        /// Esta funcion valida mas que nada las palabras que no son ni iniciales ni nombres completos
        /// Ejemplo: Edg.
        /// </summary>
        /// <param name="palabra">La palabra a evaluar</param>
        /// <returns>
        /// Si la palabra contiene 2 o mas caracteres pero sin punto, devolvera True.
        /// En caso de que contenga 2 o mas caracteres pero tambien un punto, devolvera False
        /// </returns>
        static bool EsNombreCompleto(string palabra)
        {
            var esNombre = palabra.Length >= 2 && !palabra.Contains('.');
            return esNombre;
        }

        /// <summary>
        /// Esta funcion evalua si la palabra esta capitalizada, es decir, que su primera 
        /// letra sea mayuscula.
        /// </summary>
        /// <param name="palabra">La palabra a evaluar</param>
        /// <returns>
        /// Si la primera letra de la palabra es mayuscula, devolvera True,
        /// de lo contrario devolvera False.
        /// </returns>
        static bool EstaCapitalizada(string palabra)
        {
            var estaCapitalizada = palabra[0].ToString() == palabra[0].ToString().ToUpper();
            return estaCapitalizada;
        }

        /// <summary>
        /// Funcion para evaluar si la palabra es una inicial en sí.
        /// </summary>
        /// <param name="palabra">La palabra a evaluar</param>
        /// <returns>
        /// Si la palabra contiene solo 2 caracteres (incluyendo el punto) y ademas el segundo 
        /// caracter es un punto, devolvera True. De lo contrario devolvera False.
        /// </returns>
        static bool EsInicial(string palabra)
        {
            var esInicial = palabra.Length == 2 && palabra[1] == '.';
            return esInicial;
        }
    }
}
