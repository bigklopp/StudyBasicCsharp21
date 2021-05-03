using System;

namespace CodingTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int i = 1; i <= 10; i++)
            {
                
                for (int j = 1; j<=10; j++)
                {
                    Console.Write("*");
                    if (i==j)
                    {
                        if (j == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine();
                        break;
                    }
                    
                }
                
            }
        }
    }
}
