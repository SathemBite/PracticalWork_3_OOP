using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_3
{
    class SecondClass
    {
        Singleton single = Singleton.Instance;
        public SecondClass() { }
        public string getName()
        {
            return single.getName;
        }
    }
}
