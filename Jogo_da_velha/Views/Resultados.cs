using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha.Views
{
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'jogoDaVelhaDataSet1.DadosPartidas'. Você pode movê-la ou removê-la conforme necessário.
            this.dadosPartidasTableAdapter.Fill(this.jogoDaVelhaDataSet1.DadosPartidas);

        }
    }
}
