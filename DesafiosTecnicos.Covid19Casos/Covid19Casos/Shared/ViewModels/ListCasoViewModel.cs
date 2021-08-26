using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Casos.Shared
{
    /// <summary>
    /// Al igual que la clase CasoViewModel, esta se encarga de proveer la información
    /// requerida por el usuario, sin que interactúe directamente con el modelo de datos.
    /// </summary>
    public class ListCasoViewModel
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
