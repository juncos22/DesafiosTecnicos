using System;
using System.ComponentModel.DataAnnotations;

namespace Covid19Casos.Shared
{
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
