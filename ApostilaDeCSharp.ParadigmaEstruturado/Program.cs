using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Sequêncial - TopDown
            Passo 1
            Passo 2
            Passo 3
            Passo 4
            */
            string repetir;
            do
            {
                //Passo 1 - Entrada de Dados
                string nome, resposta;
                Console.WriteLine("Qual o aluno?");
                nome = Console.ReadLine().ToUpper();

                //string nome


                //Passo 2 - Processamento (dá pra fazer sem as chaves 
                if (nome.Equals("Regys")) resposta = "Você é o nosso representante";
                //{
                //resposta = "Você é o nosso representante";
                //}
                else resposta = "Por Favor! Chame o representante ";
                //{
                // resposta = "Por Favor! Chame o representante ";
                //
                //}
                //Passo 3 - Saída
                Console.WriteLine(resposta);
                //Passo 4 - Montar uma interação (repetição)
                Console.WriteLine("Deseja sair? Y - N");
                repetir = Console.ReadLine().ToUpper();

            } while (!repetir.Equals("Y"));




            int[] notas = new int[4];
            notas[0] = 9;
            notas[1] = 21;
            notas[2] = 7; 
            notas[3] = 15;
            Console.WriteLine("Mostre as notas!");

            double soma = 0;


            //  inicio, condição, incremento
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(notas[i]);
                soma = soma + notas[i];
            }

            double media = soma / notas.Length; 
            /*length ajuda a nao se preocupar com o tamanho pois nao sabemos quantas notas
            teram com certeza, sera adiconado depois */

            Console.WriteLine($"soma:{soma}");
            Console.WriteLine($"média:{media}");


            Console.ReadKey();
        }
    }
}


