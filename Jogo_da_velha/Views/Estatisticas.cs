using DevExpress.XtraEditors;
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
    public partial class Estatisticas : DevExpress.XtraEditors.XtraForm
    {
        public Estatisticas()
        {
            InitializeComponent();
        }

        private void Estatisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'jogoDaVelhaDataSet2.DadosPartidas'. Você pode movê-la ou removê-la conforme necessário.
            this.dadosPartidasTableAdapter.Fill(this.jogoDaVelhaDataSet2.DadosPartidas);

        }
    }
}