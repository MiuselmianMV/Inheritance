using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex2
{
    public class Passport
    {
        protected string Id;
        protected string Name;
        protected string Surname;
        protected string Country;
        protected string City;
        protected string BirthDate;



        public Passport(string id, string name, string surname, 
            string country, string city, string birthdate)
        {
            Id = id; 
            Name = name;
            Surname = surname; 
            Country = country; 
            City = city;
            BirthDate = birthdate;
        }

        public virtual void Show()
        {
            Console.WriteLine("Passport Id:{0}", Id);
            Console.WriteLine("Name & Surname: {0} {1}", Name, Surname);
            Console.WriteLine("Registration: {0}, {1}", Country, City);
            Console.WriteLine("Date of birth: {0}", BirthDate);
        }
    }
}
