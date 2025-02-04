using System;

namespace alvin
{


	class Program
	{
	
	
	
	    public static void Main(string[] args)
	    {
	    	Console.WriteLine("insira uma letra");
	    	char letra = char.Parse(Console.ReadLine());
	    
	    	
	    	
	    	
	    	
	    	switch (letra)  {
	    	
	    			default	: Console.WriteLine("não é vogal");break;
	    		case  'a':
	    			
	    			
	    	
	    			Console.WriteLine("a letra é vogal");break;
	    	
	    		case  'e':
	    			
	    			
	    	
	    			Console.WriteLine("a letra é vogal");break;
	    			case  'i':
	    			
	    			
	    	
	    			Console.WriteLine("a letra é vogal");break;
	    	
	    			case  'o':
	    			
	    			
	    	
	    			Console.WriteLine("a letra é vogal");break;
	    	case  'u':
	    			
	    			
	    	
	    			Console.WriteLine("a letra é vogal");break;
	    			
	    	
	    	}
	    	
	    	
	    	Console.WriteLine ("aperte qualquer coisa para sair");
	    	Console.ReadKey();
	    }
	}


}
