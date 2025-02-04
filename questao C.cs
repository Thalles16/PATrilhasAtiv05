using System;

namespace alvin
{


	class Program
	{
	
	
	
	    public static void Main(string[] args)
	    {
	    	Console.WriteLine("digite sua data de nascimento (yyyy-mm-dd)");
	    	DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
	    	
	    	DateTime dataAtual = DateTime.Now;
	    	
	    	int idade = dataAtual.Year - dataNascimento.Year;
	    	
	    	Console.WriteLine("sua idade é: "+ idade);
	    	
	    	Console.WriteLine ("aperte qualquer coisa para sair");
	    	Console.ReadKey();
	    }
	}


}
