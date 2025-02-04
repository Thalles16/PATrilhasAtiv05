using System;

namespace alvin
{


	class Program
	{
	
	
	
	    public static void Main(string[] args)
	    {
	    	Console.WriteLine("escolha o tamanho da sua roupa (P, M ou G)");
	    	char tamanho = char.Parse(Console.ReadLine());
	    
	    	
	    	
	    	
	    	
	    	switch (tamanho)  {
	    	
	    			default	: Console.WriteLine("Digite um tamanho valido");break;
	    		case  'P':
	    			
	    			
	    	
	    			Console.WriteLine("o tamanho P custa 40 reais");break;
	    	
	    		case  'M':
	    			
	    			
	    	
	    			Console.WriteLine("o tamanho M custa 60 reais");break;
	    			case  'G':
	    			
	    			
					Console.WriteLine("o tamanho G custa 80 reais");break;
	    	}
	    	
	    	
	    	Console.WriteLine ("aperte qualquer coisa para sair");
	    	Console.ReadKey();
	    }
	}


}
