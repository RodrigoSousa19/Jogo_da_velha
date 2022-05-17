
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
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.jogoDaVelhaDataSet1 = new Jogo_da_velha.JogoDaVelhaDataSet1();
            this.jogoDaVelhaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realTimeSource1 = new DevExpress.Data.RealTimeSource();
            this.jogoDaVelhaDataSet2 = new Jogo_da_velha.JogoDaVelhaDataSet2();
            this.dadosPartidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosPartidasTableAdapter = new Jogo_da_velha.JogoDaVelhaDataSet2TableAdapters.DadosPartidasTableAdapter();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPartidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // jogoDaVelhaDataSet1
            // 
            this.jogoDaVelhaDataSet1.DataSetName = "JogoDaVelhaDataSet1";
            this.jogoDaVelhaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogoDaVelhaDataSet1BindingSource
            // 
            this.jogoDaVelhaDataSet1BindingSource.DataSource = this.jogoDaVelhaDataSet1;
            this.jogoDaVelhaDataSet1BindingSource.Position = 0;
            // 
            // realTimeSource1
            // 
            this.realTimeSource1.DataSource = this.dadosPartidasBindingSource;
            this.realTimeSource1.DisplayableProperties = "Partida;NomeJogadorX;NomeJogadorO;PontosJogadorX;PontosJogadorO;Empates;VencedorF" +
    "inal;DataDaPartida";
            // 
            // jogoDaVelhaDataSet2
            // 
            this.jogoDaVelhaDataSet2.DataSetName = "JogoDaVelhaDataSet2";
            this.jogoDaVelhaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosPartidasBindingSource
            // 
            this.dadosPartidasBindingSource.DataMember = "DadosPartidas";
            this.dadosPartidasBindingSource.DataSource = this.jogoDaVelhaDataSet2;
            // 
            // dadosPartidasTableAdapter
            // 
            this.dadosPartidasTableAdapter.ClearBeforeFill = true;
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Dark";
            this.chartControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.chartControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.chartControl1.DataSource = this.realTimeSource1;
            xyDiagram1.AxisX.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisY.GridLines.Visible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "NomeJogadorX";
            series1.Name = "Jogador X";
            series1.ValueDataMembersSerializable = "PontosJogadorX";
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(239)))), ((int)(((byte)(227)))));
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series1.View = sideBySideBarSeriesView1;
            series2.ArgumentDataMember = "NomeJogadorO";
            series2.Name = "Jogador O";
            series2.ValueDataMembersSerializable = "PontosJogadorO";
            sideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(155)))), ((int)(((byte)(140)))));
            sideBySideBarSeriesView2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series2.View = sideBySideBarSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.Size = new System.Drawing.Size(883, 500);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Maiores Pontuações";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // Estatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 500);
            this.Controls.Add(this.chartControl1);
            this.Name = "Estatisticas";
            this.Text = "Estatisticas";
            this.Load += new System.EventHandler(this.Estatisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPartidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
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
    }
}