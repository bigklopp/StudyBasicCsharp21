using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritTest
{
    class Cat : Animal
    {   
        // 특성 -> 속성
        

        // 기본 생성자
        public Cat() { this.Age = 0; } //생성자 

        // 액션 ->메서드
       

        public void Meow() { Console.WriteLine("냥냥 펀치! 건드리지 말라옹"); }

    }
}
