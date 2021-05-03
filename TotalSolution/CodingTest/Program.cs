using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //예외가 발생할 가능성이 있는 로직 은 try 안에 다 넣어 준다. 그리고 아래처럼
                // catch를 사용해서 적어 준다.
                Console.WriteLine("값을 입력하세요 : ");
                string input = Console.ReadLine();
                float result = float.Parse(input); // 예외 발생 코드
                
                // 반드시 입력 값은 정수형이어야 한다. 정수형이 아닌 문자 or 소수 등이면 오류(예외) 발생
                Console.WriteLine($"입력한 값은 {input} 입니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }

            /* 구구단 출력
            for (int i =2; i < 10;i++)
            {
                for(int j = 1; j<10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
            */

            /*for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

        }
    }
}
