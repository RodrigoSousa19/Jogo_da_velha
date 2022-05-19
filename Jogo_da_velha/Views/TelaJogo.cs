using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Jogo_da_velha
{
    public partial class TelaJogo : Form
    {
        public string NomeJogador1 { get; set; }
        public string NomeJogador2 { get; set; }

        int pontosJogador1;
        int pontosJogador2;
        int rodadas;
        int empates;
        string vencedor;
        string[] posicao = new string[9];
        bool turnos = true;
        DateTime data = DateTime.Now;
        
        public TelaJogo()
        {
            InitializeComponent();
        }

        public TelaJogo(string nome1, string nome2)
        {
            InitializeComponent();
            this.NomeJogador1 = nome1;
            this.NomeJogador2 = nome2;

            //Alterar para simplificar código
            ExibeJogador1.Text = "Jogador X: " + nome1;
            ExibeJogador2.Text = "Jogador O: " + nome2;
        }


        private void BotaoSairSalvar_Click(object sender, EventArgs e)
        {
            sqoClassDB.InsertResult(NomeJogador1, NomeJogador2, pontosJogador1, pontosJogador2, empates, vencedor, data);
            this.Close();
        }

        private void BotoesTabuleiro_Click(object sender, EventArgs e)
        {
            Button Quadrante = (Button)sender;
            int IndexBotao = Quadrante.TabIndex;
            if (Quadrante.Text == "")
            {
                if (turnos)
                {
                    Quadrante.Text = "X";
                    posicao[IndexBotao] = "X";
                    turnos = !turnos;
                    rodadas++;
                    VerificaSeGanhou(ExibeJogador1.Text);
                    txtnumrodadas.Text = Convert.ToString(rodadas);

                }
                else
                {
                    Quadrante.Text = "O";
                    posicao[IndexBotao] = "O";
                    turnos = !turnos;
                    rodadas++;
                    VerificaSeGanhou(ExibeJogador2.Text);
                    txtnumrodadas.Text = Convert.ToString(rodadas);
                }
            }
            
        }

        private void BotaoReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                posicao[i] = "";
            }
            Quadrante00.Text = "";
            Quadrante01.Text = "";
            Quadrante02.Text = "";
            Quadrante10.Text = "";
            Quadrante11.Text = "";
            Quadrante12.Text = "";
            Quadrante20.Text = "";
            Quadrante21.Text = "";
            Quadrante22.Text = "";
            rodadas = 0;
            pontosJogador1 = 0;
            pontosJogador2 = 0;
            empates = 0;
            txtpontosjogador1.Text = "0";
            txtpontosjogador2.Text = "0";
            txtEmpates.Text = "0";
            
        }

        private void VerificaSeGanhou(string nomejogador)
        {
            string auxiliar;
            if (nomejogador == ExibeJogador1.Text)
            {
                auxiliar = "X";
            }
            else
            {
                nomejogador = ExibeJogador2.Text;
                auxiliar = "O";
            }

            for (int i = 0; i < 8; i += 3)
            {
                if (auxiliar == posicao[i])
                {
                    if (posicao[i] == posicao[i + 1] && posicao[i] == posicao[i + 2])
                    {
                        MostrarGanhador(nomejogador);
                        ResetQuandoGanha();
                        return;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (auxiliar == posicao[i])
                {
                    if (posicao[i] == posicao[i + 3] && posicao[i] == posicao[i + 6])
                    {
                        MostrarGanhador(nomejogador);
                        ResetQuandoGanha();
                        return;
                    }
                }
            }

            for (int i = 0; i < 1; i++)
            {
                if (auxiliar == posicao[i])
                {
                    if (posicao[i] == posicao[i + 4] && posicao[i] == posicao[i + 8])
                    {
                        MostrarGanhador(nomejogador);
                        ResetQuandoGanha();
                        return;
                    }
                }
            }

            for (int i = 2; i < 3; i++)
            {
                if (auxiliar == posicao[i])
                {
                    if (posicao[i] == posicao[i + 2] && posicao[i] == posicao[i + 4])
                    {
                        MostrarGanhador(nomejogador);
                        ResetQuandoGanha();
                        return;
                    }
                }
            }

            if(rodadas >= 9)
            {
                MessageBox.Show("Empate!");
                ResetQuandoGanha();
                empates++;
                txtEmpates.Text = Convert.ToString(empates);
                return;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarGanhador(string Jogador)
        {
            if (Jogador == ExibeJogador1.Text)
            {
                MessageBox.Show(ExibeJogador1.Text + " Venceu!");
                pontosJogador1++;
                txtpontosjogador1.Text = Convert.ToString(pontosJogador1);
                turnos = true;
            }
            else
            {
                MessageBox.Show(ExibeJogador2.Text + " Venceu!");
                pontosJogador2++;
                txtpontosjogador2.Text = Convert.ToString(pontosJogador2);
                turnos = false;
            }

            DefineGanhador();
        }

        private void DefineGanhador()
        {
            if(pontosJogador1 > pontosJogador2)
            {
                vencedor = NomeJogador1;
            }
            else if(pontosJogador2 > pontosJogador1)
            {
                vencedor = NomeJogador2;
            }
            else
            {
                vencedor = "Empate";
            }
        }

        private void ResetQuandoGanha()
        {
            for (int i = 0; i < 9; i++)
            {
                posicao[i] = "";
            }
            Quadrante00.Text = "";
            Quadrante01.Text = "";
            Quadrante02.Text = "";
            Quadrante10.Text = "";
            Quadrante11.Text = "";
            Quadrante12.Text = "";
            Quadrante20.Text = "";
            Quadrante21.Text = "";
            Quadrante22.Text = "";
            rodadas = 0;
        }
    }
}