
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
            this.dadosPartidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogoDaVelhaDataSet1 = new Jogo_da_velha.JogoDaVelhaDataSet1();
            this.dadosPartidasTableAdapter = new Jogo_da_velha.JogoDaVelhaDataSet1TableAdapters.DadosPartidasTableAdapter();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPartidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dadosPartidasBindingSource
            // 
            this.dadosPartidasBindingSource.DataMember = "DadosPartidas";
            this.dadosPartidasBindingSource.DataSource = this.jogoDaVelhaDataSet1;
            // 
            // jogoDaVelhaDataSet1
            // 
            this.jogoDaVelhaDataSet1.DataSetName = "JogoDaVelhaDataSet1";
            this.jogoDaVelhaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosPartidasTableAdapter
            // 
            this.dadosPartidasTableAdapter.ClearBeforeFill = true;
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid.Location = new System.Drawing.Point(0, 0);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.Size = new System.Drawing.Size(637, 321);
            this.dtGrid.TabIndex = 0;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 321);
            this.Controls.Add(this.dtGrid);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosPartidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDaVelhaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private JogoDaVelhaDataSet1 jogoDaVelhaDataSet1;
        private System.Windows.Forms.BindingSource dadosPartidasBindingSource;
        private JogoDaVelhaDataSet1TableAdapters.DadosPartidasTableAdapter dadosPartidasTableAdapter;
        private System.Windows.Forms.DataGridView dtGrid;
    }
}