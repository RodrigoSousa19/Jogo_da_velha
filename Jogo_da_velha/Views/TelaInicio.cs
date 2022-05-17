using System;
using System.Windows.Forms;
using Jogo_da_velha.Views;

namespace Jogo_da_velha
{

    public partial class TelaInicio : Form
    {


        public TelaInicio()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            TelaJogo Nomes = new TelaJogo(txtboxjogador1.Text, txtboxjogador2.Text);
            Nomes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estatisticas navegar = new Estatisticas();
            navegar.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Resultados navegar = new Resultados();
            navegar.Show();
        }
    }
}
