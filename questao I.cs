using System;

namespace alvin
{


	class Program
	{
	
	
	
	    public static void Main(string[] args)
	    {
	    	Console.WriteLine("insira um numero de 1 A 7");
	    	int numero = int.Parse(Console.ReadLine());
	    
	    	
	    	
	    	
	    	
	    	switch (numero)  {
	    	
	    			default	: Console.WriteLine("digite um numero valido");break;
	    		case  1:
	    			
	    			
	    	
	    			Console.WriteLine("Hoje é domingo");break;
	    	
	    		case  2:
	    			
	    			
	    	
	    			Console.WriteLine("Hoje é segunda");break;
	    			case  3:
	    			
	    			
	    	
	    			Console.WriteLine("Hoje é terça");break;
	    	
	    			case  4:
	    			
	    			
	    	
	    			Console.WriteLine("Hoje é quarta");break;
	    	case  5:
	    			
	    			
	    	
	    			Console.WriteLine("Hoje é quinta");break;
	    		
			case  6:
	    			
	    			
	    	
	    			Console.WriteLine("Hoje é sexta");break;	

			case  7:
	    			
	    			
	    	
	    			Console.WriteLine("Hoje é sabado");break;	    			
	    	
	    	}
	    	
	    	
	    	Console.WriteLine ("aperte qualquer coisa para sair");
	    	Console.ReadKey();
	    }
	}


}
