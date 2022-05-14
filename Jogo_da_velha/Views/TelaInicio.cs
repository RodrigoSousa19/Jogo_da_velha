using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

    }
}
