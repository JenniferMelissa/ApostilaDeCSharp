using ApostilaDeCSharp.OrientacaoObjetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostilaDeCSharp.InterfaceGrafica
{
    public partial class Drive1 : Form
    {
        public Drive1()
        {
            InitializeComponent();
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {

            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();

          //MessageBox.Show(m.Voar(p) + " " + DateTime.Now);
            MessageBox.Show(m.Voar(p) + " " + DateTime.Now);
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            //p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Correr(p));

            MessageBox.Show(m.Correr(p) + DateTime.Now.ToString("dd/M/yyyy") + "\n" + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void btnNadar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Nadar(p));

            MessageBox.Show(m.Nadar(p) + DateTime.Now.ToString("dd/M/yyyy") + "\n" + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Andar(p));

            MessageBox.Show(m.Andar(p) + DateTime.Now.ToString("dd/M/yyyy") + "\n" + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Parar(p));

            MessageBox.Show(m.Parar(p) + DateTime.Now.ToString("dd/M/yyyy") + "\n" + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Voltar(p));

            MessageBox.Show(m.Voltar(p) + DateTime.Now.ToString("dd/M/yyyy") + "\n" + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Pular(p));

            MessageBox.Show(m.Pular(p) + DateTime.Now.ToString("dd/M/yyyy") + "\n" + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void btnVirarADireita_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.VirarDireita(p));
        }

        private void btnVirarAEsquerda_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.VirarEsquerda(p));
        }
    }
}
