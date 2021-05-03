using System;

namespace CodingTest5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9! 3,6,9! 3,6,9! 3,6,9!!");

            for(int i = 0; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("");
                }
                
                if ((i.ToString()).Contains("3"))
                {
                    Console.Write("짝!\t");
                }
                else if ((i.ToString()).Contains("6"))
                {
                    Console.Write("짝!\t");
                }
                else if ((i.ToString()).Contains("9"))
                {
                    Console.Write("짝!\t");
                }
                else if (i==0)
                {
                    Console.Write("짝!\t");
                }
                else
                {
                    Console.Write($"{i}\t");
                }
                
            }
            
        }
    }
}
