using System;
using System.Collections.Generic;

namespace Gof
{
	public abstract class Registro
	{
        public int Abertura { get; set; }
        
		public abstract void Add(Registro d);
    	public abstract void Remove(Registro d);
    	public abstract void Display(int indent);	
	}

    public class RegistroA1 : Registro
    {
        private Registro pai;
        
        public int AberturaA1 { get; set; }
        
        
        public override void Add(Registro d)
        {
            pai = d;
        }

        public override void Display(int indent)
        {
            pai.Display(0);
            Console.WriteLine(pai.Abertura);
            Console.WriteLine(AberturaA1);
            
            throw new NotImplementedException();
        }

        public override void Remove(Registro d)
        {
            throw new NotImplementedException();
        }
    }


    public class SPED : Registro
    {
		 private List<Registro> elements = 
      new List<Registro>();
		
        public override void Add(Registro d)
        {
            elements.Add(d);
        }

        public override void Display(int indent)
        {
            foreach (var item in elements)
            {
                item.Display(0);
            }
        }

        public override void Remove(Registro d)
        {
            throw new NotImplementedException();
        }
    }
}