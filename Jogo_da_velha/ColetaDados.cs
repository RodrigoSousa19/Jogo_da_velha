using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_velha
{
    public class ColetaDados
    {
        Conexao conexao = new Conexao();
        SqlCommand Comando = new SqlCommand();
        public string status = "";
        public ColetaDados(string Jogador1, string Jogador2)
        {
            Comando.CommandText = "insert into JogoDaVelha (NomeJogador) values (@Jogador1)";

            Comando.CommandText = "insert into JogoDaVelha (NomeJogador) values (@Jogador2)";

            Comando.Parameters.AddWithValue("@Jogador1",Jogador1);

            Comando.Parameters.AddWithValue("@Jogador2", Jogador2);
            try
            {
                Comando.Connection = conexao.Conectar();
               
                Comando.ExecuteNonQuery();

                this.status = "Bom jogo!";

            }
            catch (SqlException e)
            {

                this.status = "Erro durante a conxão com o banco de dados" + e;
            }
            finally
            {
                conexao.Desconectar();
                this.status = "Conexão fechada";
            }
        }
    }
}
