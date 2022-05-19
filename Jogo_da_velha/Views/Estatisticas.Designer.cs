
namespace Jogo_da_velha.Views
{
    partial class Estatisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.sqoClassDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqoClassDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl2
            // 
            this.chartControl2.DataSource = typeof(Jogo_da_velha.resultadoJogoPersistencia);
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.Visible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            series1.ArgumentDataMember = "Jogador";
            series1.Name = "Vitorias";
            series1.ValueDataMembersSerializable = "Vitorias";
            series2.ArgumentDataMember = "Jogador";
            series2.Name = "Derrotas";
            series2.ValueDataMembersSerializable = "Derrotas";
            series3.ArgumentDataMember = "Jogador";
            series3.Name = "Empates";
            series3.ValueDataMembersSerializable = "Empates";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chartControl2.Size = new System.Drawing.Size(834, 640);
            this.chartControl2.TabIndex = 0;
            this.chartControl2.Click += new System.EventHandler(this.chartControl2_Click);
            // 
            // sqoClassDBBindingSource
            // 
            this.sqoClassDBBindingSource.DataSource = typeof(Jogo_da_velha.sqoClassDB);
            // 
            // Estatisticas
            // 
            this.ClientSize = new System.Drawing.Size(834, 640);
            this.Controls.Add(this.chartControl2);
            this.Name = "Estatisticas";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqoClassDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource jogoDaVelhaDataSet1BindingSource;
        private JogoDaVelhaDataSet1 jogoDaVelhaDataSet1;
        private DevExpress.Data.RealTimeSource realTimeSource1;
        private JogoDaVelhaDataSet2 jogoDaVelhaDataSet2;
        private System.Windows.Forms.BindingSource dadosPartidasBindingSource;
        private JogoDaVelhaDataSet2TableAdapters.DadosPartidasTableAdapter dadosPartidasTableAdapter;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource resultadoJogoPersistenciaBindingSource;
        private System.Windows.Forms.BindingSource resultadosBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.Windows.Forms.BindingSource sqoClassDBBindingSource;
    }
}