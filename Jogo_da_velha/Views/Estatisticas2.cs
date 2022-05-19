using DevExpress.XtraCharts;
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
    public partial class Estatisticas2 : Form
    {
        public Estatisticas2()
        {
            InitializeComponent();
        }

        private void Estatisticas2_Load(object sender, EventArgs e)
        {
            ChartControl chart = new ChartControl();
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);

            Series vitorias = new Series("Vitorias", ViewType.Bar);
            vitorias.DataSource = sqoClassDB.GetResult();
            vitorias.ArgumentDataMember = "Jogador";
            vitorias.ValueDataMembers.AddRange("Vitorias");
            chart.Series.Add(vitorias);

            Series derrotas = new Series("Derrotas", ViewType.Bar);
            derrotas.DataSource = sqoClassDB.GetResult();
            derrotas.ArgumentDataMember = "Jogador";
            derrotas.ValueDataMembers.AddRange("Derrotas");
            chart.Series.Add(derrotas);

            Series empates = new Series("Empates", ViewType.Bar);
            empates.DataSource = sqoClassDB.GetResult();
            empates.ArgumentDataMember = "Jogador";
            empates.ValueDataMembers.AddRange("Empates");
            chart.Series.Add(empates);

            vitorias.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            derrotas.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            empates.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "Estatiscas dos jogos";
            chart.Titles.Add(chartTitle);

            XYDiagram diagram = chart.Diagram as XYDiagram;
            diagram.AxisY.GridLines.Visible = false;
        }
    }
}
