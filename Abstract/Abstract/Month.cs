using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Month
    {
        public void Get(int num)
        {
            switch (num)
            {
                case 1:
                        Console.WriteLine("Yanvar");
                    break;
                
                case 2:
                    Console.WriteLine("Fevral");
                    break;

                case 3:
                    Console.WriteLine("Mart");
                    break;
                default:

                    Console.WriteLine("tapilmadi");
                    break;
                    
       

            }
           
        } 
    }

}
