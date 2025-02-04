using System;

namespace alvin
{


	class Program
	{
	
	
	
	    public static void Main(string[] args)
	    {
	    	Console.WriteLine("Que dia é hoje? E que horas são ?");
	    	
	    	DateTime horaAtual = DateTime.Now;
	    	
	    	Console.WriteLine ("agora sao exatas "+horaAtual);
	    	
	    	Console.WriteLine ("aperte qualquer coisa para sair");
	    	Console.ReadKey();
	    }
	}


}
