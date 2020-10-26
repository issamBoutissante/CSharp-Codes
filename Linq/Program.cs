using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    //Issam Boutissante (boutissante.issam.dev@gmail.com)
    //there is nothing to do with this code cause it was just for review and practice linq

    class Program       {
        static void Main(string[] args)
        {
            //Extention Methods Linq
            var phones=new Phones().GetPhones();
            var redmi = phones.Where(p => p.mark == "Redmi").OrderBy(p=>p.price).Select(p=>p.price);
            foreach (int price in redmi) Console.WriteLine("Redmi Price is : "+price);
            //Query Linq
            var infinix = from p in phones
                          where p.mark == "Infinix"
                          orderby p.price
                          select p.price;
            foreach (int price in infinix) Console.WriteLine("Infinix Price is : "+price);


            var TreePhonesOfMiddle = phones.Skip(2).Take(3) ;
            foreach (Phone p in TreePhonesOfMiddle) Console.WriteLine("the operating System of "+p.mark+" is : "+p.OS);

            var MaxOfTreeMiddle = TreePhonesOfMiddle.Max(p=>p.price);

            Console.WriteLine("the max of tree in middle is "+MaxOfTreeMiddle);
            var Min = phones.Min(p => p.price);
            Console.WriteLine(Min);


            //there is other Linq Methods Like 
            var FirstPhone = phones.First();
            var FirstorDefaultPhone = phones.FirstOrDefault();

            var LastPhone = phones.Last();
            var LastorDefaultPhone = phones.LastOrDefault();

            var single = phones.Single(p=>p.mark=="Infinix");
            //ther is also SingleOrDefault

            var total = phones.Sum(p => p.price);
            var cout = phones.Count();
           

            Console.ReadKey();
        }
    }

    class Phones
    {
        List<Phone> phones = new List<Phone>()
        {
            new Phone{mark="Redmi",OS="Android",price=1144 },
            new Phone{mark="Infinix",OS="Android",price=113 },
            new Phone{mark="Sumsung",OS="Android",price=16 },
            new Phone{mark="Hwawi",OS="Android",price=10 },
            new Phone{mark="Redmi",OS="Android",price=113 },
            new Phone{mark="Redmi",OS="Android",price=11 },
            new Phone{mark="Infinix",OS="Android",price=4 }

        };
        public List<Phone> GetPhones()
        {
            return phones;
        }

    }
    class Phone
    {
        public string mark { get; set; }
        public string OS { get; set; }

        public int price { get; set; }
    }
}
