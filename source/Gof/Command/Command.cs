using System;

namespace Gof
{
	class ServicoNota
	{
		public void GerarNota(CriacaoNovaNotaCommand comand)
		{
			
		}
	}
	
	class CriacaoNovaNotaCommand
	{
		public int Numero { get; set; }
		public int IdCliente { get; set; }
		
		public DateTime DataCriacao { get; set; }
	}
}