using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGit
{
    class Program
    {
        static void Main(string[] args)
        {

                                     
            System.Console.WriteLine("Digite a sua renda (R$)!");
            decimal renda = Convert.ToDecimal(System.Console.ReadLine());

            System.Console.WriteLine("Digite o acréscimo (%)!");
            decimal acrescimo = Convert.ToDecimal(System.Console.ReadLine());
                                             
            System.Console.WriteLine(("O acréscimo de %" + (acrescimo + (" em cima do valor de R$ " + (renda + (" é de R$ " + AcrescimoRenda(renda, acrescimo)))))));
            System.Console.ReadLine();


        }


        /// <summary>
        /// Function que adiciona acréscimo na renda digitada
        /// </summary>
        /// <param name="renda">Digite a renda do cliente</param>
        /// <param name="acrescimo">Digite o acréscimo que deseja adicionar</param>
        /// <returns></returns>
        static decimal AcrescimoRenda(Decimal renda, Decimal acrescimo)
        {
            Decimal valoracrescimo;
            valoracrescimo = (renda / 100) * acrescimo;
            return valoracrescimo;
        }
    }
}
