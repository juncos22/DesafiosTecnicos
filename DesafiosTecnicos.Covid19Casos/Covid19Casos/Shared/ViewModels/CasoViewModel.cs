using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Casos.Shared
{
    /// <summary>
    /// Clase que maneja el modelo de datos de los casos.
    /// La razón por la que se creó esta clase, fué para que, en lugar de darle 
    /// acceso directo al usuario a la clase Caso, esta clase es la que se 
    /// va a encargar de obtener la informacion del usuario para pasársela al modelo de datos
    /// sin que el usuario interactúe directamente con el mismo.
    /// Esto mantiene separada la lógica de negocio del modelo de datos y el usuario.
    /// </summary>
    public class CasoViewModel
    {
        // Atributo Fecha donde se establece el formato aceptado por los navegadores
        // además del tipo de dato del atributo para que sea interpretado por los mismos.
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Provincia { get; set; }
    }
}
