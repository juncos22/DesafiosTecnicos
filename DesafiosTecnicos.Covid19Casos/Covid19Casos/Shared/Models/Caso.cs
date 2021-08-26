using System;
using System.ComponentModel.DataAnnotations;

namespace Covid19Casos.Shared
{
    /// <summary>
    /// Clase que sirve de modelo de datos para guardar la información en la base de datos.
    /// Posee cada uno de los campos de la tabla en la base de datos.
    /// </summary>
    public class Caso
    {
        [Key]
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Provincia { get; set; }

    }
}
