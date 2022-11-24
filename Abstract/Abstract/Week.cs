using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Week
    {
        public virtual void Get(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("first day");
                    break;
                case 2:
                    Console.WriteLine("second day");
                    break;
                default:
                    Console.WriteLine("tapilmadi");
                    break;
            }
            }
    }
    class Day : Week
    {
        public override void Get(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                default:
                    Console.WriteLine("tapilmadi");
                    break;
            }
        }
    }

}
