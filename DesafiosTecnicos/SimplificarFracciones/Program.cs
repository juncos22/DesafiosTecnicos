using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplificarFracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Simplificar("100/400"));
            Console.ReadLine();
        }

        /// <summary>
        /// Funcion para simplificar una fraccion a su menor expresión.
        /// </summary>
        /// <param name="fraccion">La cadena de texto que contiene la fraccion.</param>
        /// <returns>La fraccion simplificada.</returns>
        public static string Simplificar(string fraccion)
        {
            // Se separa la cadena de la fraccion ingresada por medio del caracter '/' de la misma
            // de esta forma se obtiene un arreglo de cadenas con el numerador y denominador.
            var numeros = fraccion.Split('/');

            // Se convierten el numerador y denominador en enteros para poder operar con ellos,
            // guardandolos en variables separadas.
            int numerador = int.Parse(numeros[0]);
            int denominador = int.Parse(numeros[1]);

            // Se evalua si el resto de la división entre el numerador y el denominador
            // vale cero, de ser asi, se devuelve su cociente directamente.
            if (numerador % denominador == 0)
            {
                return $"{numerador / denominador}";
            }
            // Se obtiene el MCD de la fraccion y se lo guarda en la variable 'mcd'.
            int mcd = Mcd(numerador, denominador);

            // Una vez obtenido el MCD, se procede a dividir al numerador y denominador por el mismo
            numerador /= mcd;
            denominador /= mcd;

            // De esta forma se obtiene la fraccion simplificada
            return $"{numerador}/{denominador}";
        }

        /// <summary>
        /// Funcion para sacar el Mínimo Común Divisor de una fracción.
        /// </summary>
        /// <param name="n">El numerador de la fraccion en entero.</param>
        /// <param name="d">El denominador de la fraccion en entero.</param>
        /// <returns>El Mínimo Común Divisor de una fracción.</returns>
        static int Mcd(int n, int d)
        {
            // Variable donde se guardará el resto del cociente entre el numerador
            // y el denominador.
            int resto;

            // Mientras el denominador sea diferente de cero, el resto entre el
            // numerador y denominador se irá guardando en la variable 'resto'
            // luego se realizará un intercambio de valores entre el resto, el numerador
            // y el denominador, de esta forma, la variable 'n' va a guardar al final 
            // el MCD de la fraccion cuando la variable 'd' valga cero.
            while (d != 0)
            {
                resto = n % d;
                n = d;
                d = resto;
            }
            return n;
        }
    }
}
