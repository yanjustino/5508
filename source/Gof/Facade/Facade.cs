using System;
using System.Collections.Generic;

namespace Gof
{
	
	public interface RepositorioCliente{}
	
	public interface RepositorioNota
	{
		DomainNota Recuperar(int numero);
		void Atualizar(DomainNota nota);
	}
	
	public interface RepositorioProduto{}
	
	
	public class DomainNota
	{
		public int Numero { get; set; }
		public bool Enviada { get; private set; }
		
		
		public void MaracarComoEnviada()
		{
			Enviada = true;
		}
		
	}
	
	
	public class NotaFiscalService
	{
		private RepositorioCliente _clientes;
		private RepositorioProduto _produtos;
		private RepositorioNota _notas;
		
		public NotaFiscalService(
			RepositorioNota notas,
			RepositorioCliente clientes, 
			RepositorioProduto produtos)
		{
			_clientes = clientes;
			_produtos = produtos;
			_notas = notas;
		}
		
		public void EnviarNota(int numero)
		{
			var nota = _notas.Recuperar(numero);
			
			nota.MaracarComoEnviada();
			
			_notas.Atualizar(nota);
		}
    }
}