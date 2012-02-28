using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnoNascimento
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/**
			 * @author Lucas Colette <eu@colet.me>
			 * @RA 212114030
			 * 
			 * Um programa que solicite a idade do usuario e informe o ano de seu nascimento
			 *
			 */
			
			Console.WriteLine("Qual a sua idade ?");

			int Idade = Convert.ToInt32(Console.ReadLine());
			
			DateTime Hoje = DateTime.Now;
			int AnoAtual = Hoje.Year;

			Console.WriteLine("Você nasceu no ano de " + (AnoAtual-Idade));
			
		}
	}
}
