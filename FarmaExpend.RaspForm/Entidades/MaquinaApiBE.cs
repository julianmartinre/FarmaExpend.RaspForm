using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaExpend.RaspForm
{
    public class MaquinaApiBE
    {
        public int nro_maquina { get; set; }
        public List<MaquinaProductoApiBE> productos { get; set; }
    }
}
