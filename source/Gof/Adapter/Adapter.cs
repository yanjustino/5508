namespace Gof
{
	public class NotaFiscal
	{
		public virtual int Numero { get; }
		
	}
	
	public class NotaFiscalAdapter : NotaFiscal
	{
		private NotaFiscalXml xml = new NotaFiscalXml();
		
		public override int Numero{get {return xml.RecuperarNumero();} }
	}
	
	public class NotaFiscalXml
	{
		public int RecuperarNumero()
		{
			return 1;
		}
	}

}