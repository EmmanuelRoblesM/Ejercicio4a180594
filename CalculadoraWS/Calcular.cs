using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWS
{
	public class Calcular
	{

		public decimal numero1 { get; set; }
		public decimal numero2 { get; set; }
		public decimal suma()
		{
			return numero1+numero2;
		}

		public decimal resta(decimal n1, decimal n2)
		{
			numero1 = n1;
			numero2 = n2;
			return numero1-numero2;
		}

		public decimal multiplicacion(decimal n1, decimal n2)
		{
			return n1*n2;
		}

		public decimal division(decimal n1, decimal n2)
		{
			var resultado = n1/n2;
			return resultado;
		}
		public decimal Areacirculo(decimal n1)
		{
			var pi = 3.1416;
			var radioalcuadrado = Convert.ToDouble( n1 * n1);
			var resultado = pi * radioalcuadrado;
			return Convert.ToDecimal (resultado);
			
		}
		public decimal Areacuadrado(decimal n1)
		{
			var resultado = n1 * n1;
			return resultado;
		}
		public decimal Areatriangulo(decimal n1, decimal n2)
		{
			var resultado = ((n1 * n2)/2);
			return resultado;
		}
	}
}