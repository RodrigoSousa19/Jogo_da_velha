using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_velha
{
   public class Conexao
    {

        SqlConnection Conecta = new SqlConnection();

        public Conexao()
        {
            Conecta.ConnectionString = "Data Source=SQO-061\\SQLEXPRESS;Initial Catalog=JogoDaVelha;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if(Conecta.State == System.Data.ConnectionState.Closed)
            {
                Conecta.Open();
            }
            return Conecta;
        }

        public void Desconectar()
        {
            if (Conecta.State == System.Data.ConnectionState.Open)
            {
                Conecta.Close();
            }
        }
    }
}
