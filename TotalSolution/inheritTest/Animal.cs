using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritTest
{
    // Access Modifier(접근 제한자) : public, protected, private
    class Animal 
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("먹습니다"); }
        public void Sleep() { Console.WriteLine("잡니다"); }

    }
}
