using System;

namespace Gof
{
	public abstract class Prototype<T> where T :class
	{
		public abstract T Clone();
 
        
        public T ClonarExibindoTipo()
        {
            ExibirTipo();
            return Clone();            
        }
        
        public abstract void ExibirTipo();
        
	}

    public class NFe : Prototype<NFe>
    {
        public override NFe Clone()
        {
            throw new NotImplementedException();
        }

        public override void ExibirTipo()
        {
            Console.WriteLine("NFe");
        }
    }
}