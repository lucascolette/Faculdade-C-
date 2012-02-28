using System;

namespace Parcelamento
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
		/**
		 * @author Lucas Colette <eu@colet.me>
		 * @RA 212114030
		 * 
		 * Um programa que simule o parcelamento em 3x de uma determinada conta
		 * 
		 * Qual o valor da conta ?
		 * => 3000
		 * 
		 * As 3 parcelas serão de:
		 * - 01 - 15/02/2012 - 1000
		 * - 02 - 15/03/2012 - 1000
		 * - 03 - 15/04/2012 - 1000
		 * 
		 */

			Console.WriteLine("Qual o valor da conta ?");
			decimal Valor = Convert.ToDecimal(Console.ReadLine());
			decimal VlrParcela = Valor/3;

			DateTime Hoje = DateTime.Now;

			Console.WriteLine("\nAs parcelas serão: \n");
			Console.WriteLine("01 - {0:d} - R$ "+VlrParcela.ToString("N2"), (Hoje.AddDays(30)).ToString("dd/MM/yyyy"));
			Console.WriteLine("02 - {0:d} - R$ "+VlrParcela.ToString("N2"), (Hoje.AddDays(60)).ToString("dd/MM/yyyy"));
			Console.WriteLine("03 - {0:d} - R$ "+VlrParcela.ToString("N2"), (Hoje.AddDays(90)).ToString("dd/MM/yyyy"));

		}
	}
}
