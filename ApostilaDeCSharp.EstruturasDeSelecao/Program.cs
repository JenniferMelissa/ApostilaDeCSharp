using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.EstruturasDeSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if - estrutura de seleção simples
            double x = 43.1;
                if (x >= 43.1)
                    Console.WriteLine("Mandaloriano!");

            //if else - estrutura de seleção composta
            /* quem define o tipo é o compilador */
            var idade = 17;
            if(idade >= 43.1)
            {
                Console.WriteLine("Mandaloriano!");
            }
            else
            {
                Console.WriteLine("Grande Jovem Jovem!");
            }

            //if else if - estrutura de seleção composta encadeada
            if(idade >= 43.1)
            {
                Console.WriteLine("Mandaloriano!");
            }
            else if(idade >= 18 && idade < 43.1)
            {
                Console.WriteLine("Grande Jovem Jovem!");
            }
            else
            {
                Console.WriteLine("Menino(a)!");
            }

            //switch - estrutura de seleção múltipla
            var dia = 1;

            switch(dia)
            {
                case 2: Console.WriteLine("Segunda");break;
                case 3: Console.WriteLine("Terça");break;
                case 4: Console.WriteLine("Quarta");break;
                case 5: Console.WriteLine("Quinta");break;
                case 6: Console.WriteLine("Sexta");break;

                default: Console.WriteLine("Final de semana chegou!!...");break;
            }

            string mensagem;
            var salario = 49000.20;
            mensagem = salario >= 50000.20 ? "Tá rico hein!" : "Complicado em!";
            Console.WriteLine(mensagem);


            var num = 15;
            var num2 = 5;

            if (num % num2 == 0)
            {
                Console.WriteLine("Fracionário!");
            }
            else
            {
                Console.WriteLine("Não Fracionário!");
            }
            
            /*
             var numero = 5.3;
            if(numero.GetType() == typeof(double))
                Console.WriteLine("Número é facionário/real");
             */

            Console.ReadKey();
        }
    }
}
