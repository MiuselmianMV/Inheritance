using Inheritance.Ex1;
using Inheritance.Ex2;
using Inheritance.Ex3;
using Inheritance.Ex4;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
        }

        static void TestEx1(Human human)
        {
            human.Work();
        }

        static void Ex1()
        {
            var human = new Human("Human", 50);
            var sailor = new Sailor("Seaman", 40);
            var builder = new Builder("Stoneman", 30);
            var pilot = new Pilot("Skyman", 20);
            Console.WriteLine("\n----------------------------------Ex1----------------------------------\n");

            Console.WriteLine("Methods Work:\n");

            human.Work();
            sailor.Work();
            builder.Work();
            pilot.Work();

            Console.WriteLine("\nTest method: \n");

            TestEx1(human);
            TestEx1(sailor);
            TestEx1(pilot);
            TestEx1(builder);
        }
        static void Ex2()
        {
            Console.WriteLine("\n----------------------------------Ex2----------------------------------\n");
            
            Console.WriteLine("Methods Show:\n");

            var passport = new Passport("04953241AF", "Karl", "Lebowski", "Zimbabwe", "Harare", "01.01.1921");
            var foreignPassport = new ForeignPassport("USA, Ukraine, Columbia, Dubai", "1231231", "AK9281234", "Monter", "Maltin", "Mexica", "Mexico", "23.04.2011");
            
            passport.Show();
            Console.WriteLine();
            foreignPassport.Show();

            Console.WriteLine("\nTest method: \n");
            Test2(passport);
            Test2(foreignPassport);

        }
        static void Test2(Passport passport)
        {
            passport.Show();
            Console.WriteLine();
        }

        static void Ex3()
        {
            Console.WriteLine("\n----------------------------------Ex3----------------------------------\n");
            Console.WriteLine("Methods Show:\n");

            var animal = new Animal(100, "Animal", 0, 0);
            var tiger = new Tiger(50, "Evgeniy", 200, 150);
            var kenguru = new Kenguru(70, "Boxer", 123, 200);
            var croc = new Crocodile(100, "Gena", 400, 45);
            animal.Show();
            tiger.Show();
            kenguru.Show();
            croc.Show();
        }
        
        static void Ex4()
        {
            Shape[] shapes = [new Shape(1), 
                            new Triangle(2, 5, 10),
                            new Rectangle(3, 4, 9), 
                            new Square(4, 10), 
                            new Circle(5, 10),
                            ];

            Console.WriteLine("\n----------------------------------Ex4----------------------------------\n");
            Console.WriteLine("Methods Show:\n");
            foreach (var shape in shapes)
            {
                shape.Show();
                Console.WriteLine("================================");
            }
            Console.WriteLine("\nMethods Area:\n");
            foreach (var shape in shapes)
            {
                shape.Area();
                Console.WriteLine("================================");
            }
        }
    }
}
