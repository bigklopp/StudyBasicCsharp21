using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritTest
{
    class Dog : Animal
    {
        // 특성 -> 속성
        
        public string Color { get; set; }

        // 기본 생성자
        public Dog() { this.Age = 0; this.Color = "흰색"; } //생성자 

        // 액션 ->메서드
        public void Bark() { Console.WriteLine("왈왈 으르렁그르르르르르으르르르르르 왈왈!!"); }
            
    }
}
