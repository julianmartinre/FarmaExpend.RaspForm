using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FarmaExpend.RaspForm
{
    public class Api
    {
        public MaquinaApiBE GetMachine(int nro_maquina, string token)
        {
            var url = $"https://api.farmaexpend.com/api/Maquina/Get?nro_maquina=" + nro_maquina + "&token=" + token;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            MaquinaApiBE m = new MaquinaApiBE();
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                Reply oR = new Reply();
                                oR = JsonConvert.DeserializeObject<Reply>(responseBody);
                                m = JsonConvert.DeserializeObject<MaquinaApiBE>(oR.data.ToString());
                                Console.WriteLine(responseBody);
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            return m;
        }
        public void RegisterSale(int nro_maquina, string token, int nro_producto, decimal precio)
        {
            try
            {
                string p = precio.ToString();
                int numEnero = int.Parse(p.Split(',')[0]);
                float numDecimal = float.Parse("0," + p.Split(',')[1]);

                var url = $"https://api.farmaexpend.com/api/Venta/RegisterMachineSale?nro_maquina=" + nro_maquina.ToString() + "&token=" + token + "&nro_producto=" + nro_producto.ToString() + "&precio=" + numEnero.ToString() + "." + numDecimal.ToString() + "&fecha=10/10/10";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = 0;
                request.Accept = "application/json";

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                Reply oR = new Reply();
                                oR = JsonConvert.DeserializeObject<Reply>(responseBody);
                                //m = JsonConvert.DeserializeObject<MaquinaApiBE>(oR.data.ToString());
                                Console.WriteLine(responseBody);
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        public string GenerarToken(string u, string p)
        {
            var url = $"https://api.farmaexpend.com/api/Access/loginRasp?u=" + u + " &p=" + p;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            string token = "";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                Reply oR = new Reply();
                                oR = JsonConvert.DeserializeObject<Reply>(responseBody);
                                if (oR.data != null) { token = oR.data.ToString(); }                              
                                Console.WriteLine(responseBody);
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            return token;
        }
    }
}
