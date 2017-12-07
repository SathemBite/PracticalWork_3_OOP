using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass first = new FirstClass();
            SecondClass second = new SecondClass();
            Console.WriteLine("Singleton name in firstclass: " + first.getName());
            Console.WriteLine("Singleton name in secondtclass: "  + second.getName());

            for (int i = 0; i < 10; i++)
            {
                new ThirdClass();
            }

            Console.WriteLine("Count of objects of ThirdClass: " + ThirdClass.countOfCreatedObj());
            Console.ReadKey();
        }
    }
}
