using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaExpend.RaspForm
{
    public class MaquinaProductoApiBE
    {
        public int nro_compartimento { get; set; }
        public int nro_producto { get; set; }
        public string nombre_producto { get; set; }
        public decimal precio { get; set; }
        public string url_img { get; set; }
    }
}
