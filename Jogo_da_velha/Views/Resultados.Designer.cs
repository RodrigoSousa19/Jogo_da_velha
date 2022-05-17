
namespace Jogo_da_velha.Views
{
    partial class Resultados
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
            this.ExibeResultado = new System.Windows.Forms.DataGridView();
            this.jogoDaVelhaDataSet1 = new Jogo_da_velha.JogoDaVelhaDataSet1();
            this.dadosPartidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosPartidasTableAdapter = new Jogo_da_velha.JogoDaVelhaDataSet1TableAdapters.DadosPartidasTableAdapter();
            this.partidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeJogadorXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeJogadorODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontosJogadorXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontosJogadorODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencedorFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExibeResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPartidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExibeResultado
            // 
            this.ExibeResultado.AllowUserToAddRows = false;
            this.ExibeResultado.AllowUserToDeleteRows = false;
            this.ExibeResultado.AutoGenerateColumns = false;
            this.ExibeResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ExibeResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExibeResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partidaDataGridViewTextBoxColumn,
            this.nomeJogadorXDataGridViewTextBoxColumn,
            this.nomeJogadorODataGridViewTextBoxColumn,
            this.pontosJogadorXDataGridViewTextBoxColumn,
            this.pontosJogadorODataGridViewTextBoxColumn,
            this.empatesDataGridViewTextBoxColumn,
            this.vencedorFinalDataGridViewTextBoxColumn,
            this.dataDaPartidaDataGridViewTextBoxColumn});
            this.ExibeResultado.DataSource = this.dadosPartidasBindingSource;
            this.ExibeResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExibeResultado.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExibeResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExibeResultado.Location = new System.Drawing.Point(0, 0);
            this.ExibeResultado.Name = "ExibeResultado";
            this.ExibeResultado.ReadOnly = true;
            this.ExibeResultado.Size = new System.Drawing.Size(848, 450);
            this.ExibeResultado.TabIndex = 0;
            // 
            // jogoDaVelhaDataSet1
            // 
            this.jogoDaVelhaDataSet1.DataSetName = "JogoDaVelhaDataSet1";
            this.jogoDaVelhaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosPartidasBindingSource
            // 
            this.dadosPartidasBindingSource.DataMember = "DadosPartidas";
            this.dadosPartidasBindingSource.DataSource = this.jogoDaVelhaDataSet1;
            // 
            // dadosPartidasTableAdapter
            // 
            this.dadosPartidasTableAdapter.ClearBeforeFill = true;
            // 
            // partidaDataGridViewTextBoxColumn
            // 
            this.partidaDataGridViewTextBoxColumn.DataPropertyName = "Partida";
            this.partidaDataGridViewTextBoxColumn.HeaderText = "Partida";
            this.partidaDataGridViewTextBoxColumn.Name = "partidaDataGridViewTextBoxColumn";
            this.partidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeJogadorXDataGridViewTextBoxColumn
            // 
            this.nomeJogadorXDataGridViewTextBoxColumn.DataPropertyName = "NomeJogadorX";
            this.nomeJogadorXDataGridViewTextBoxColumn.HeaderText = "NomeJogadorX";
            this.nomeJogadorXDataGridViewTextBoxColumn.Name = "nomeJogadorXDataGridViewTextBoxColumn";
            this.nomeJogadorXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeJogadorODataGridViewTextBoxColumn
            // 
            this.nomeJogadorODataGridViewTextBoxColumn.DataPropertyName = "NomeJogadorO";
            this.nomeJogadorODataGridViewTextBoxColumn.HeaderText = "NomeJogadorO";
            this.nomeJogadorODataGridViewTextBoxColumn.Name = "nomeJogadorODataGridViewTextBoxColumn";
            this.nomeJogadorODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pontosJogadorXDataGridViewTextBoxColumn
            // 
            this.pontosJogadorXDataGridViewTextBoxColumn.DataPropertyName = "PontosJogadorX";
            this.pontosJogadorXDataGridViewTextBoxColumn.HeaderText = "PontosJogadorX";
            this.pontosJogadorXDataGridViewTextBoxColumn.Name = "pontosJogadorXDataGridViewTextBoxColumn";
            this.pontosJogadorXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pontosJogadorODataGridViewTextBoxColumn
            // 
            this.pontosJogadorODataGridViewTextBoxColumn.DataPropertyName = "PontosJogadorO";
            this.pontosJogadorODataGridViewTextBoxColumn.HeaderText = "PontosJogadorO";
            this.pontosJogadorODataGridViewTextBoxColumn.Name = "pontosJogadorODataGridViewTextBoxColumn";
            this.pontosJogadorODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empatesDataGridViewTextBoxColumn
            // 
            this.empatesDataGridViewTextBoxColumn.DataPropertyName = "Empates";
            this.empatesDataGridViewTextBoxColumn.HeaderText = "Empates";
            this.empatesDataGridViewTextBoxColumn.Name = "empatesDataGridViewTextBoxColumn";
            this.empatesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vencedorFinalDataGridViewTextBoxColumn
            // 
            this.vencedorFinalDataGridViewTextBoxColumn.DataPropertyName = "VencedorFinal";
            this.vencedorFinalDataGridViewTextBoxColumn.HeaderText = "VencedorFinal";
            this.vencedorFinalDataGridViewTextBoxColumn.Name = "vencedorFinalDataGridViewTextBoxColumn";
            this.vencedorFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDaPartidaDataGridViewTextBoxColumn
            // 
            this.dataDaPartidaDataGridViewTextBoxColumn.DataPropertyName = "DataDaPartida";
            this.dataDaPartidaDataGridViewTextBoxColumn.HeaderText = "DataDaPartida";
            this.dataDaPartidaDataGridViewTextBoxColumn.Name = "dataDaPartidaDataGridViewTextBoxColumn";
            this.dataDaPartidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.ExibeResultado);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExibeResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPartidasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExibeResultado;
        private JogoDaVelhaDataSet1 jogoDaVelhaDataSet1;
        private System.Windows.Forms.BindingSource dadosPartidasBindingSource;
        private JogoDaVelhaDataSet1TableAdapters.DadosPartidasTableAdapter dadosPartidasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeJogadorXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeJogadorODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontosJogadorXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontosJogadorODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencedorFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDaPartidaDataGridViewTextBoxColumn;
    }
}