using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.Function1(2).Function2(2);
        }
    }

    class MyClass
    {
        public bool referToUnderwriting { get; set; }

        public MyClass Function1(int input)
        {
            if (input > 1)
                referToUnderwriting = true;
            else
                referToUnderwriting = false;

            return this;
        }

        public MyClass Function2(int input)
        {
            if ((this.referToUnderwriting) && (input > 3))
                referToUnderwriting = true;
            else
                referToUnderwriting = false;

            return this;
        }
    }
}
