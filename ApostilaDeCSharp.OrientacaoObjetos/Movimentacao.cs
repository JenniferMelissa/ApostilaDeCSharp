using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.OrientacaoObjetos
{
    public class Movimentacao
    {

        public string Voar(Personagem p)
        {
            //SoundPlayer voou = new SoundPlayer(@"C:\Users\Aluno\Downloads\fly.wav");
            //voou.Play();

            SoundPlayer voou = new SoundPlayer(Properties.Resources.fly);
            
            voou.Play();


            if(p.QtdePontos > 10)
            {
                return $"{p.Nome} voou";
            }
            else
            {
                return $"{p.Nome} não voou";
            }
        }
        public string Nadar(Personagem p)
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Downloads\swimming.wav");
            //player.Play();

            SoundPlayer play = new SoundPlayer(Properties.Resources.swim);
            play.Play();

            return $"{p.Nome} nadou!";

        }
        public string Pular(Personagem p)
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.Jump);
            play.Play();
            return $"{p.Nome} pulou!";
        }
        public string Correr(Personagem p)
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.Running);
            play.Play();
            return $"{p.Nome} correu!"; 
        }
        public string VirarEsquerda(Personagem p)
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.TurnOn);
            play.Play();
            return $"{p.Nome} virou a esquerda!";
        }
        public string VirarDireita(Personagem p)
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.TurnOn);
            play.Play();
            return $"{p.Nome} virou a direita";
        }
        public string Parar(Personagem p)
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.CarStop);
            play.Play();
            return $"{p.Nome} parou!";
        }
        public string Andar(Personagem p)
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.walking);
            play.Play();
            return $"{p.Nome} andou!";
        }
        public string Voltar(Personagem p)
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.TurnAround);
            play.Play();
            return $"{p.Nome} voltou!";
        }
        
    }
}
