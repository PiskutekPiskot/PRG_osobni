using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
       public class Human
        {
            public int age;
            public int height;
            public int weight;
            public string name;
            public string hairColor;
            public Human partner;
            public Human(int age, int height, int weight, string name)
            {
            this.age = age;
            this.height = height;   
            this.weight = weight;
            this.name = name;
            }
            public Human()
            {

            }

            public void IntroduceHuman()
            {
                Console.WriteLine($"jmenuju se {name}, je mi {age}let, vážim {weight}kg, měřim {height}cm.");
            }
            public float BodyMassIndex()
            {
                float bmih = height / 100f;
                float bmi=weight/(bmih*bmih);
                return bmi;
            }

            public static Human makeHuman(Human human1, Human human2)
            {
                if (human1.partner==human2 &&human2.partner==human1)
                {
                    Human child = new Human();
                    child.age = 0;
                    child.height = (human1.height+human2.height)/2;
                    child.weight = (human1.weight + human2.weight) / 2;
                    child.hairColor = human1.hairColor + "nebo "+human2.hairColor;
                    child.name = human1.name;
                    return child;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] intArray=new int[5];
            Human human1 = new Human();
            human1.age = 36;
            human1.height = 165;
            human1.weight = 60;
            human1.name = "Alžběta";
            human1.hairColor = "hnědá";
            human1.IntroduceHuman();

            Human human2= new Human();
            human2.age = 22;
            human2.height = 200;
            human2.weight = 80;
            human2.name = "Bobeš";
            human2.hairColor = "modrá";
            human2.IntroduceHuman();

            Human human3 = new Human(50,170,70, "Cecilie");
            human3.IntroduceHuman();

            float bmi = human3.BodyMassIndex();
            Console.WriteLine($"bmi je {bmi}");
            human1.partner=human2;
            human2.partner=human1;
            Console.ReadKey();

        }
    }
}
