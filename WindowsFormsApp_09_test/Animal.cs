using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_09_test
{
    public class Animal
    {
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine($"{Name}: 동물이 소리를 냅니다.");
        }

    }
    public class Dog : Animal
    {
        public Dog() : base() { }

        public void DogSpeak()
        {
            Console.WriteLine("멍");
        }

    }

    public class Cat : Animal
    {
        public Cat() : base() { }

        public void CatSpeak()
        {
            Console.WriteLine("야옹");
        }

    }

    public class Bird : Animal
    {
        public Bird() : base() { }

        public void BirdSpeak()
        {
            Console.WriteLine("짹");
        }

    }
}
