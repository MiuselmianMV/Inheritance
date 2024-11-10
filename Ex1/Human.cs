using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex1
{
    internal class Human
    {
        protected string Name;
        protected int Age;
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Work()
        {
            Console.WriteLine("Human does housework.");
        }
    }
}

//Завдання 1
//Створіть клас Human, який міститиме інформацію про
//людину. За допомогою механізму спадкування реалізуйте клас Builder (містить інформацію про будівельника),
//клас Sailor (містить інформацію про моряка), клас Pilot
//(містить інформацію про льотчика).
//Кожен із класів повинен містити необхідні для роботи
//методи.