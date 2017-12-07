using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_3
{
    class ThirdClass
    {
        private static int objCounter = 0;

        public ThirdClass()
        {
            Console.WriteLine(++objCounter + " object of ThirdClass was created");
        }

        public static int countOfCreatedObj()
        {
            return objCounter;
        }
    }
}
