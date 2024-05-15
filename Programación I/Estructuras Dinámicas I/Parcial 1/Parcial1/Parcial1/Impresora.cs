using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    public class Impresora
    {
        public string Modelo { get; set; }
        public int Copias { get; set; }
        public Impresora Siguiente { get; set; }

    }
}
