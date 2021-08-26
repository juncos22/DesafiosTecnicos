using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Casos.Shared
{
    public class CasoResponse
    {
        public int StatusCode { get; set; }
        public string Mensaje { get; set; }
        public List<ListCasoViewModel> Data { get; set; }

    }
}
