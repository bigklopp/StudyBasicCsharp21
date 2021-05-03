using System;

namespace CodingTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("이름을 입력하세요 : ");
                string name = Console.ReadLine();
                Console.Write("나이를 입력하세요 : ");
                int age =int.Parse(Console.ReadLine());
                Console.Write("주소를 입력하세요 : ");
                string address = Console.ReadLine();

                Console.WriteLine($"반갑습니다. 저는 {address}에 살고 있는 {age}살 {name}입니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            
        }
    }
}
