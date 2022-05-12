using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Jogo_da_velha
{
    public partial class TelaJogo : Form
    {
        bool Turnos = true;
        Thread NavegaTela;
        public TelaJogo()
        {
            InitializeComponent();
        }
        public class Global
        {
            
        }

        private void BotaoTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close();
            NavegaTela = new Thread(AbrirJanela);
            NavegaTela.SetApartmentState(ApartmentState.STA);
            NavegaTela.Start();
        }

        public void AbrirJanela(object obj)
        {
            Application.Run(new TelaInicio());
        }

        private void Quadrante00_Click(object sender, EventArgs e)
        {
            string[,] QuadrantesOcupados = new string[3, 3];
            Button Quadrante = (Button)sender;
            if (Quadrante.Text == "")
            {
                if (Turnos)
                {
                    Quadrante.Text = "X";
                    Turnos = !Turnos;

                }
                else
                {
                    Quadrante.Text = "O";
                    Turnos = !Turnos;
                }
            }

        }

        private void BotaoReset_Click(object sender, EventArgs e)
        {
            Quadrante00.Text = "";
            Quadrante01.Text = "";
            Quadrante02.Text = "";
            Quadrante10.Text = "";
            Quadrante11.Text = "";
            Quadrante12.Text = "";
            Quadrante20.Text = "";
            Quadrante21.Text = "";
            Quadrante22.Text = "";
        }
    }
}
