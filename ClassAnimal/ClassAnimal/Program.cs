using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int maxAge;

            public virtual void MakeNoise()
            {
                Console.WriteLine("animal noises");
            }
        }
        class Dog : Animal 
        {
            public string breed;
            public override void MakeNoise() 
            {
                Console.WriteLine("wof woof");
            }
        }
        class Cat: Animal
        {
            public string furColour;
            public override void MakeNoise()
            {
                Console.WriteLine("meaw meow");
            }
        }
        static void Main(string[] args)
        {
            Animal newAnimal = new Animal();
            newAnimal.MakeNoise();

            Dog newDog=new Dog();
            newDog.name = "Hund";
            newDog.maxAge = 13;
            newDog.breed = "fox";
            Console.WriteLine($"Dog name is {newDog.name} max age is {newDog.maxAge} breed is {newDog.breed} ");
            newDog.MakeNoise();

            Cat newCat = new Cat();
            newCat.name = "lex";
            newCat.maxAge = 13;
            newCat.furColour = "black";
            Console.WriteLine($"Cat name is {newCat.name} max age is {newCat.maxAge} fur is {newCat.furColour} ");
            newCat.MakeNoise();


            Console.ReadKey();
        }
    }
}
