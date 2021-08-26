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
        // Ademas se agregó la anotación para validar que no se envíe el formulario sin valores.
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, 100, ErrorMessage = "El valor debe estar entre 1 y 100 años.")]
        public int Edad { get; set; }
        
        // El atributo Genero no necesita validación ya que tendrá el valor 'M' por defecto.
        public string Genero { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Provincia { get; set; }
    }
}
