namespace Gof
{
	public class ConexaoBancoDados
	{
		private static GerenciadorConexao _gerenciador;
		
		public static GerenciadorConexao Current 
		{
			get
			{
				_gerenciador = _gerenciador ?? new GerenciadorConexaoOracle();
				
				return _gerenciador;
			}
		}
	}
}