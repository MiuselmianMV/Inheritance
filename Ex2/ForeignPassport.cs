using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Ex2
{
    public class ForeignPassport : Passport
    {
        protected string Visas;
        protected string ForeignId;


        public ForeignPassport(string visas,string foreignId, 
            string id, string name, string surname, 
            string country, string city, string birthdate)
            : base( id,  name,  surname,  country,  city,  birthdate)
        {
            Visas = visas;
            ForeignId = foreignId;
        }


        public override void Show()
        {
            Console.WriteLine("Foreign passport: ");
            base.Show();
            Console.WriteLine("Foreign passport number: {0}", ForeignId);
            Console.WriteLine("Visas: {0}", Visas);
            Console.WriteLine();
        }
    }
}
