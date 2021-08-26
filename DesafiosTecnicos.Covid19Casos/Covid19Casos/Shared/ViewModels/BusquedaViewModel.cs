using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Casos.Shared
{
    /// <summary>
    /// Clase que se va a encargar de obtener los parametros de busqueda
    /// del usuario sin tener que darle acceso directo al modelo de datos.
    /// </summary>
    public class BusquedaViewModel
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int EdadInicio { get; set; }
        public int EdadFin { get; set; }
        public string Genero { get; set; }
        public string Provincia { get; set; }
    }
}
