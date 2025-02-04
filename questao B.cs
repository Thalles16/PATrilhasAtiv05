using System;

namespace alvin
{


	class Program
	{
	
	
	
	    public static void Main(string[] args)
	    {
	    	Console.WriteLine("Que dia é hoje? E que horas são ?");
	    	
	    	DateTime data1 = new DateTime (2022,09,16);
	    	
	    	DateTime data2 = new DateTime (2007,09,17);
	    	
	    	TimeSpan diferenca = data1 - data2;
	    	
	    	Console.WriteLine ("a diferenca de data é "+ diferenca.TotalDays);
	    	
	    	Console.WriteLine ("aperte qualquer coisa para sair");
	    	Console.ReadKey();
	    }
	}


}
