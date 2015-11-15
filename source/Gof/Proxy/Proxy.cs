using System;

namespace Gof
{
	
	class Correntista
	{
		public long CPF { get; set; }
		
		public void Validar()
		{
			
		}
	}
	
	public interface IConta
	{
		void Debitar(double valor);
		void Creditar(double valor);
	}
	
	class Conta : IConta
	{
		Correntista correntista = new Correntista();
		
		public void Debitar(double valor)
		{
			
		}
		
		public void Creditar(double valor)
		{
			
		}
	}

    class OperacaoContaCorrenteCPMF : IConta
    {
		Conta conta = new Conta();
		
        public void Creditar(double valor)
        {
			RecolherImposto(valor, 0.033);
			
            conta.Creditar(valor);
        }

        public void Debitar(double valor)
        {
			RecolherImposto(valor, 0.033);
			
            conta.Debitar(valor);
        }
		
		
		private void RecolherImposto(double valor, double taxa)
		{
			
		}
    }
}