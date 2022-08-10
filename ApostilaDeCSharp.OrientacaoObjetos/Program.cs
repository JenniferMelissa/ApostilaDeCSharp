using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem p = new Personagem();
            p.Nome = "Aloy";
            p.QtdePontos = 0;
            p.QtdeVidas = 7;

            Movimentacao m = new Movimentacao();

            m.Voar(p);
            Console.WriteLine(m.Voar(p));

            m.Correr(p);
            Console.WriteLine(m.Correr(p));

            m.Nadar(p);
            Console.WriteLine(m.Nadar(p));

            m.Pular(p);
            Console.WriteLine(m.Pular(p));

            m.VirarEsquerda(p);
            Console.WriteLine(m.VirarEsquerda(p));

            m.VirarDireita(p);
            Console.WriteLine(m.VirarDireita(p));

            m.Andar(p);
            Console.WriteLine(m.Andar(p));

            m.Parar(p);
            Console.WriteLine(m.Parar(p));

            m.Voltar(p);
            Console.WriteLine(m.Voltar(p));



            Console.ReadKey();
        }
    }
}
