using sqoClassLibraryAI0502Biblio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_velha
{
    public static class sqoClassDB
    {
        
        private static string ConnectionString = @"Provider=SQLOLEDB.1;Password=sequor;Persist Security Info=True;User ID=sa;Initial Catalog=JogoDaVelha;Data Source=SQO-061\SQLEXPRESS";
        public static OleDbConnection oDBconnection = new OleDbConnection(ConnectionString);

        public static void InsertResult(string jogador1, string jogador2, int pontosjogador1, int pontosjogador2, int empates, string vencedor, DateTime data)
        {
            OleDbCommand oCommand = null;
            String sQuery = "";
            
            try
            {
                oDBconnection.Open();
                sQuery = "INSERT into DadosPartidas" +
                         "(NomeJogadorX,NomeJogadorO,PontosJogadorX,PontosJogadorO,Empates,VencedorFinal,DataDaPartida)" +
                         "Values('"+jogador1+"', '" +jogador2+"','"+pontosjogador1+ "',"+pontosjogador2+ ",'"+empates+"','"+vencedor+"','"+data.ToString("yyyy-MM-dd HH:mm:ss")+"')";


                oCommand = new OleDbCommand(sQuery, oDBconnection);
                oCommand.ExecuteNonQuery();
                
            }
            catch(OleDbException ex)
            {
                throw (new Exception("Erro ao inserir os dados. " + ex + ""));
            }
            finally
            {
                oCommand.Dispose();
                oDBconnection.Close();
            }
        }

        public static OleDbDataReader GeraResultado;

        
        

        public static List<resultadoJogoPersistencia> GetResult()
        {

            DataTable dt = new DataTable();
            List<resultadoJogoPersistencia>result = new List<resultadoJogoPersistencia>();

            try
            {
                string sQuery = "";

                sQuery += System.Environment.NewLine + "SELECT base.jogador as jogador";
                sQuery += System.Environment.NewLine + ",sum(base.vitorias) as vitorias";
                sQuery += System.Environment.NewLine + ",sum(base.derrotas) as derrotas";
                sQuery += System.Environment.NewLine + ",sum(base.Empates) as empates";
                sQuery += System.Environment.NewLine + "FROM(";
                sQuery += System.Environment.NewLine + "SELECT [NomeJogadorX] as jogador, [PontosJogadorX] as vitorias, [PontosJogadorO] as derrotas, [Empates] as empates";
                sQuery += System.Environment.NewLine + "FROM [JogoDaVelha].[dbo].[DadosPartidas] union all";
                sQuery += System.Environment.NewLine + "SELECT [NomeJogadorO] as jogador, [PontosJogadorO] as vitorias,[PontosJogadorX] as derrotas, [Empates] as empates";
                sQuery += System.Environment.NewLine + "FROM [JogoDaVelha].[dbo].[DadosPartidas])base";
                sQuery += System.Environment.NewLine + "group by base.jogador";


                result = sqoClassPersistencia.GetListaResultado<resultadoJogoPersistencia>(oDBconnection, sQuery);
                
            }
            catch (Exception ex)
            {
                throw (new Exception("Erro ao buscar os dados. " + ex + ""));
            }

            return result;
        }
    }
}
