using System;

public class POO1
{
	public POO1()
	
	{
		static void main(string[] args)
		{
			console.WriteLine("Hello Word!");
		}

	
	}
		public interface Ipagamento
		{
		    Datetime Vencimento {  get; set; }
		    decimal Valor { get; set; }
		}

	    public class Pagamento : Ipagamento
		{

		}
}
