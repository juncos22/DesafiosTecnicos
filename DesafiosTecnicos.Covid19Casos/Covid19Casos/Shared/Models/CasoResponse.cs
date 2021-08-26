using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Casos.Shared
{
    /// <summary>
    /// Clase que se va a encargar de proveer una respuesta al usuario cuando se ejecute 
    /// una operacion, ya sea de lectura o escritura.
    /// En caso de que la operación salga bien, la respuesta obtendrá un StatusCode de 200 
    /// y el objeto Data traerá la información de la base de datos (de ser una operación de consulta),
    /// en caso de ser una operación de escritura, obtendrá solamente el StatusCode 200 y un 
    /// Mensaje que la operación fue exitosa.
    /// 
    /// Si la operación fuera a fallar, en cualquier caso, recibira un StatusCode de 400 y 
    /// un mensaje de que hubo un error al realizar la operación.
    /// </summary>
    public class CasoResponse
    {
        // El código de estado (puede ser 200 o 400).
        public int StatusCode { get; set; }
        // Mensaje para mostrar al usuario.
        public string Mensaje { get; set; }
        // La información para mostrar al usuario, en el caso de la operación de lectura.
        public List<ListCasoViewModel> Data { get; set; }

    }
}
