using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tabuada
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/**
			 * ADS turma 1
			 * 
			 * @author Lucas Colette
			 * @RA 212114030
			 * 
			 * Gera a tabudada do numero solicitado
			 * 
			 */
			
			Console.WriteLine("Digite um número:");

      		int Numero = Convert.ToInt32(Console.ReadLine());

      		Console.Write("\n\n");

      		Console.WriteLine(Numero + " x 1 = " + Numero * 1);
      		Console.WriteLine(Numero + " x 2 = " + Numero * 2);
      		Console.WriteLine(Numero + " x 3 = " + Numero * 3);
      		Console.WriteLine(Numero + " x 4 = " + Numero * 4);
      		Console.WriteLine(Numero + " x 5 = " + Numero * 5);
      		Console.WriteLine(Numero + " x 6 = " + Numero * 6);
      		Console.WriteLine(Numero + " x 7 = " + Numero * 7);
      		Console.WriteLine(Numero + " x 8 = " + Numero * 8);
      		Console.WriteLine(Numero + " x 9 = " + Numero * 9);
      		Console.WriteLine(Numero + " x 10 = " + Numero * 10);

      		Console.ReadKey();

		}
	}
}
