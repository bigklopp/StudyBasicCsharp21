using System;

namespace CodingTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요 : ");
            try
            {
                double rad = double.Parse(Console.ReadLine());
                double area = Math.PI * rad * rad;
                Console.WriteLine($"원의 넓이는 {area} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 {ex.Message}");

            }
            

        }
    }
}
