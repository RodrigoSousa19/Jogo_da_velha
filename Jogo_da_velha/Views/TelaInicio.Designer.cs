
namespace Jogo_da_velha
{
    partial class TelaInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicio));
            this.LabelJogador1 = new System.Windows.Forms.Label();
            this.txtboxjogador2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxjogador1 = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.btnEstatisticas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelJogador1
            // 
            this.LabelJogador1.AutoSize = true;
            this.LabelJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LabelJogador1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(211)))), ((int)(((byte)(202)))));
            this.LabelJogador1.Location = new System.Drawing.Point(54, 134);
            this.LabelJogador1.Name = "LabelJogador1";
            this.LabelJogador1.Size = new System.Drawing.Size(340, 29);
            this.LabelJogador1.TabIndex = 0;
            this.LabelJogador1.Text = "Digite o nome de quem será X";
            // 
            // txtboxjogador2
            // 
            this.txtboxjogador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtboxjogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxjogador2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(211)))), ((int)(((byte)(202)))));
            this.txtboxjogador2.Location = new System.Drawing.Point(154, 231);
            this.txtboxjogador2.Name = "txtboxjogador2";
            this.txtboxjogador2.Size = new System.Drawing.Size(152, 30);
            this.txtboxjogador2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(211)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(54, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome de quem será O";
            // 
            // txtboxjogador1
            // 
            this.txtboxjogador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtboxjogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxjogador1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(211)))), ((int)(((byte)(202)))));
            this.txtboxjogador1.Location = new System.Drawing.Point(154, 166);
            this.txtboxjogador1.Name = "txtboxjogador1";
            this.txtboxjogador1.Size = new System.Drawing.Size(152, 30);
            this.txtboxjogador1.TabIndex = 1;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(211)))), ((int)(((byte)(202)))));
            this.BtnIniciar.Location = new System.Drawing.Point(175, 352);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(116, 30);
            this.BtnIniciar.TabIndex = 2;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEstatisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstatisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEstatisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(211)))), ((int)(((byte)(202)))));
            this.btnEstatisticas.Location = new System.Drawing.Point(175, 388);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(116, 30);
            this.btnEstatisticas.TabIndex = 3;
            this.btnEstatisticas.Text = "Estatisticas";
            this.btnEstatisticas.UseVisualStyleBackColor = false;
            this.btnEstatisticas.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(211)))), ((int)(((byte)(202)))));
            this.button1.Location = new System.Drawing.Point(175, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resultados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(477, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEstatisticas);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.txtboxjogador1);
            this.Controls.Add(this.txtboxjogador2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelJogador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicio";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelJogador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.TextBox txtboxjogador2;
        private System.Windows.Forms.TextBox txtboxjogador1;
        private System.Windows.Forms.Button btnEstatisticas;
        private System.Windows.Forms.Button button1;
    }
}

