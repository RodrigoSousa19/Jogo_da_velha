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
    }
}
