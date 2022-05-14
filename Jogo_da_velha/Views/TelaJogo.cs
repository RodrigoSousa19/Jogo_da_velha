using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Jogo_da_velha
{
    public partial class TelaJogo : Form
    {
        //Propriedades para atribuir ao Banco de dados
        public string NomeJogador1 { get; set; }
        public string NomeJogador2 { get; set; }
        //============================================//

        int PontosJogador1, PontosJogador2, Rodadas, Empates;
        string Vencedor;
        string[] Posicao = new string[9];
        bool Turnos = true;

        //Construtor Padrão
        public TelaJogo()
        {
            InitializeComponent();
        }

        //Construtor criado para coletar nomes
        public TelaJogo(string nome1, string nome2)
        {
            InitializeComponent();
            this.NomeJogador1 = nome1;
            this.NomeJogador2 = nome2;
            ExibeJogador1.Text = "Jogador X: " + nome1;
            ExibeJogador2.Text = "Jogador O: " + nome2;
        }


        //Retorna para a tela inicial
        //Salva dados no Banco de Dados
        private void BotaoSairSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=SQO-061\SQLEXPRESS;Initial Catalog=JogoDaVelha;Integrated Security=True");

            SqlCommand comandos = new SqlCommand("INSERT into DadosPartidas(NomeJogadorX,NomeJogadorO,PontosJogadorX,PontosJogadorO,Empates,VencedorFinal,DataDaPartida) VALUES(@Jogador1,@Jogador2,@PontosJogador1,@PontosJogador2,@Empates,@Vencedor,@Data)", conexao);

            comandos.Parameters.Add("@Jogador1", SqlDbType.VarChar).Value = NomeJogador1;
            comandos.Parameters.Add("@Jogador2", SqlDbType.VarChar).Value = NomeJogador2;
            comandos.Parameters.Add("@PontosJogador1", SqlDbType.Int).Value = PontosJogador1;
            comandos.Parameters.Add("@PontosJogador2", SqlDbType.Int).Value = PontosJogador2;
            comandos.Parameters.Add("@Empates", SqlDbType.Int).Value = Empates;
            comandos.Parameters.Add("@Vencedor", SqlDbType.VarChar).Value = Vencedor;
            comandos.Parameters.Add("@Data", SqlDbType.DateTime).Value = DateTime.Now;



            try
            {
                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Salvando informações...");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ops, algo deu errado!" + ex);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Informações salvas!");
            }

            this.Close();
        }

        //Quadrante usado de base para replicar os comandos de atribuição de X ou O
        private void Quadrante00_Click(object sender, EventArgs e)
        {
            Button Quadrante = (Button)sender;
            int IndexBotao = Quadrante.TabIndex;
            if (Quadrante.Text == "")
            {
                if (Turnos)
                {

                    Quadrante.Text = "X";
                    Posicao[IndexBotao] = "X";
                    Turnos = !Turnos;
                    Rodadas++;
                    VerificaSeGanhou(ExibeJogador1.Text);
                    txtnumrodadas.Text = Convert.ToString(Rodadas);

                }
                else
                {
                    Quadrante.Text = "O";
                    Posicao[IndexBotao] = "O";
                    Turnos = !Turnos;
                    Rodadas++;
                    VerificaSeGanhou(ExibeJogador2.Text);
                    txtnumrodadas.Text = Convert.ToString(Rodadas);
                }
            }
            
        }

        //Reseta tudo
        private void BotaoReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Posicao[i] = "";
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
            Rodadas = 0;
            PontosJogador1 = 0;
            PontosJogador2 = 0;
            Empates = 0;
            txtpontosjogador1.Text = "0";
            txtpontosjogador2.Text = "0";
            txtEmpates.Text = "0";
            
        }

        //Rotina de verificações
        private void VerificaSeGanhou(string nomejogador)
        {
            //atribui valor para não bugar o resultado.
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
            //========================================//

            //Verifica linhas horizontais
            for (int i = 0; i < 8; i += 3)
            {
                if (auxiliar == Posicao[i])
                {
                    if (Posicao[i] == Posicao[i + 1] && Posicao[i] == Posicao[i + 2])
                    {
                        Ganhador(nomejogador);
                        ResetQuandoGanha();
                        return;
                    }
                }
            }

            //Verifica linhas Verticais
            for (int i = 0; i < 3; i++)
            {
                if (auxiliar == Posicao[i])
                {
                    if (Posicao[i] == Posicao[i + 3] && Posicao[i] == Posicao[i + 6])
                    {
                        Ganhador(nomejogador);
                        ResetQuandoGanha();
                        return;
                    }
                }
            }

            //Verifica diagonal Esquerda superior - Direita inferior
            for (int i = 0; i < 1; i++)
            {
                if (auxiliar == Posicao[i])
                {
                    if (Posicao[i] == Posicao[i + 4] && Posicao[i] == Posicao[i + 8])
                    {
                        Ganhador(nomejogador);
                        ResetQuandoGanha();
                        return;
                    }
                }
            }

            //Verifica diagonal Direita superior - Esquerda inferior
            for (int i = 2; i < 3; i++)
            {
                if (auxiliar == Posicao[i])
                {
                    if (Posicao[i] == Posicao[i + 2] && Posicao[i] == Posicao[i + 4])
                    {
                        Ganhador(nomejogador);
                        ResetQuandoGanha();
                        return;
                    }
                }
            }

            //Verifica Empate
            if(Rodadas >= 9)
            {
                MessageBox.Show("Empate!");
                ResetQuandoGanha();
                Empates++;
                txtEmpates.Text = Convert.ToString(Empates);
                return;
            }

        }

        //Sai sem salvar os dados da partida
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Exibe mensagem informando o ganhador
        private void Ganhador(string Jogador)
        {
            if (Jogador == ExibeJogador1.Text)
            {
                MessageBox.Show(ExibeJogador1.Text + " Venceu!");
                PontosJogador1++;
                txtpontosjogador1.Text = Convert.ToString(PontosJogador1);
                Turnos = true;
            }
            else
            {
                MessageBox.Show(ExibeJogador2.Text + " Venceu!");
                PontosJogador2++;
                txtpontosjogador2.Text = Convert.ToString(PontosJogador2);
                Turnos = false;
            }

            Campeao();
        }

        //Define o vencedor da partida
        private void Campeao()
        {
            if(PontosJogador1 > PontosJogador2)
            {
                Vencedor = NomeJogador1;
            }
            else
            {
                Vencedor = NomeJogador2;
            }
        }

        //Reseta: quadrantes.text, posicaoIndex e rodadas 
        private void ResetQuandoGanha()
        {
            for (int i = 0; i < 9; i++)
            {
                Posicao[i] = "";
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
            Rodadas = 0;
        }
    }
}