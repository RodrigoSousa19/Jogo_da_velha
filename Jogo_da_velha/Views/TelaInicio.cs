using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Jogo_da_velha
{

    public partial class TelaInicio : Form
    {


        public TelaInicio()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            TelaJogo Nomes = new TelaJogo(txtboxjogador1.Text, txtboxjogador2.Text);


            SqlConnection conexao = new SqlConnection(@"Data Source=SQO-061\SQLEXPRESS;Initial Catalog=JogoDaVelha;Integrated Security=True");

            SqlCommand comandos = new SqlCommand("INSERT into DadosJogador(NomeJogador) VALUES(@nome)", conexao);

            comandos.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtboxjogador1.Text;


            try
            {
                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Bom Jogo!");
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

            Nomes.Show();
        }

    }
}
