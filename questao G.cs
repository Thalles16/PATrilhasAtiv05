using System;

namespace alvin
{


	class Program
	{
	
	
	
	    public static void Main(string[] args)
	    {
	    	Console.WriteLine("insira um numero inteiro");
	    	string cor = (Console.ReadLine());
	    
	    	
	    	
	    	
	    	
	    	switch (cor)  {
	    	
	    		case  "vermelho":
	    			
	    			
	    	
	    			Console.WriteLine("a cor escolhida foi vermelho");break;
	    	
	    		case "azul":
	    	
	    	Console.WriteLine("a cor escolhida foi azul");break;
	    	
	    		case "verde":
	    	
	       Console.WriteLine("cor escolhida foi verde");break;
	    	}
	    	
	    	
	    	Console.WriteLine ("aperte qualquer coisa para sair");
	    	Console.ReadKey();
	    }
	}


}
