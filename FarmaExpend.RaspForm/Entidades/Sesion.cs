using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaExpend.RaspForm.Entidades
{
    public class Sesion
    {
        private static Sesion sesion;
        public static Sesion GetInstance()
        {
            if (sesion == null)
            {
                sesion = new Sesion();
            }

            return sesion;
        }
        public string token { get; set; }

        public string verToken()
        {
            return token;
        }
        public string username { get; set; }
        public string password { get; set; }
        public void login(string u, string p, int n)
        {
            username = u;
            password = p;
            nro_maquina = n;
        }
        public int nro_maquina { get; set; }
        public MaquinaApiBE maquina { get; set; } = new MaquinaApiBE();
    }
}
