using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Jogo_da_velha;

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
            List<resultadoJogoPersistencia> Resultado = new List<resultadoJogoPersistencia>(sqoClassDB.GetResult());
            dtGrid.DataSource = Resultado;
        }
    }
}
