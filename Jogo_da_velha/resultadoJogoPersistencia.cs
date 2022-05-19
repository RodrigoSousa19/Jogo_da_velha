using System;
using sqoClassLibraryAI0502Biblio;

namespace Jogo_da_velha
{
	public class resultadoJogoPersistencia
	{

		private String sJogador = "";
		[ColunaAttribute("Jogador", "jogador", TIPO_COLUNA.tcString, -1)]
		public String Jogador
		{
			get { return sJogador; }
			set { sJogador = value; }
		}

		private int nVitorias = 0;
		[ColunaAttribute("Vitorias", "vitorias", TIPO_COLUNA.tcInt, -1)]
		public int Vitorias
		{
			get { return nVitorias; }
			set { nVitorias = value; }
		}

		private int nDerrotas = 0;
		[ColunaAttribute("Derrotas", "derrotas", TIPO_COLUNA.tcInt, -1)]
		public int Derrotas
		{
			get { return nDerrotas; }
			set { nDerrotas = value; }
		}

		private int nEmpates = 0;
		[ColunaAttribute("Empates", "empates", TIPO_COLUNA.tcInt, -1)]
		public int Empates
		{
			get { return nEmpates; }
			set { nEmpates = value; }
		}

	}
}
