using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadoraWS
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal suma(decimal n1, decimal n2)
        {
            Calcular c = new Calcular();
            c.numero1 = n1;
            c.numero2 = n2;
            return c.suma();
        }
        [WebMethod]
        public decimal resta(decimal n1, decimal n2)
        {
            Calcular c = new Calcular();
          
            return c.resta(n1,n2);
        }
        [WebMethod]
        public decimal multiplicacion(decimal n1, decimal n2)
        {
            Calcular c = new Calcular();
            return c.multiplicacion(n1,n2);
        }
        [WebMethod]
        public decimal division(decimal n1, decimal n2)
        {
            Calcular c = new Calcular();
            return c.division(n1,n2);
        }
        [WebMethod]
        public decimal Areacirculo(decimal n1)
        {
            Calcular c = new Calcular();
            return c.Areacirculo(n1);
        }
        [WebMethod]
        public decimal Areacuadrado(decimal n1)
        {
            Calcular c = new Calcular();
            return c.Areacuadrado(n1);
        }
        [WebMethod]
        public decimal Areatriangulo(decimal n1, decimal n2)
        {
            Calcular c = new Calcular();
            return c.Areatriangulo(n1, n2);
        }
    }
}
