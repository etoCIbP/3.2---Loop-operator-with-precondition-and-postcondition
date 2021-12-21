using System;

namespace _3._2___Loop_operator_with_precondition_and_postcondition
{
    class Program
    {
		static void Main(string[] args)
		{
			int n;

			Console.Write("n = ");
			n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				if (i < 10 && i == (i * i) % 10)
				{
					Console.Write(i + " " + i * i);
				}

			}
		}
    }
}
