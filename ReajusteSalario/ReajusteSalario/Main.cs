using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rajuste
{
  class Program
  {
    static void Main(string[] args)
    {

      /**
       * ADS turma 1
       * 
       * @author Lucas Colette
       * @RA 212114030
       * 
       * Um programa que solicite um salário para o usuário;
       * Depois solicita um percentual de reajuste. Deve mostrar
       * o novo salário ajustado
       * 
       */
		
      Console.WriteLine("Qual o salário ?");
      decimal Salario = Convert.ToDecimal(Console.ReadLine());

      Console.WriteLine("Qual o reajuste ?");
      decimal Reajuste = Convert.ToDecimal(Console.ReadLine());

      decimal SalarioFinal = Salario+(Salario*Reajuste/100);

      Console.Write("\n\n");
      Console.Write("O salário reajustado terá valor de R$ " + (SalarioFinal));

      Console.ReadKey();


    }
  }
}
