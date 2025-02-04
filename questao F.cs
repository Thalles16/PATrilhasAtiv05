using System;

namespace alvin
{


	class Program
	{
	
	
	
	    public static void Main(string[] args)
	    {
	    	Console.WriteLine("insira um numero inteiro");
	    	int numero = int.Parse(Console.ReadLine());
	    
	    	
	    	
	    	
	    	
	    	switch (numero)  {
	    	
	    		case  0:
	    			
	    			
	    	
	    			Console.WriteLine("o numero é igual a 0");break;
	    	
	    		case 1:
	    	
	    	Console.WriteLine("o numero é positivo");break;
	    	
	    		case -1:
	    	
	       Console.WriteLine("o numero é negativvo");break;
	    	}
	    	
	    	
	    	Console.WriteLine ("aperte qualquer coisa para sair");
	    	Console.ReadKey();
	    }
	}


}
