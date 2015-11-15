using System;

namespace Gof
{
    public class Program
    {
        public void Main(string[] args)
        {
            var conexao = ConexaoBancoDados.Current;
            
            
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
