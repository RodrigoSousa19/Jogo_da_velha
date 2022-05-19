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

            chartControl2.DataSource = new System.ComponentModel.BindingList<Jogo_da_velha.resultadoJogoPersistencia>(sqoClassDB.GetResult());
        }

        private void Estatisticas_Load(object sender, EventArgs e)
        {

        }

        private void resultadoJogoPersistenciaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }
    }
}