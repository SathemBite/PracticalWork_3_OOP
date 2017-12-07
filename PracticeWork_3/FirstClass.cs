using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_3
{
    class FirstClass
    {
        Singleton single = Singleton.Instance;
        public FirstClass() { }
        public string getName()
        {
            return single.getName;
        }
    }
}
