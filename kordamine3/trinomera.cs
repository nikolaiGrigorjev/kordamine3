using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine3
{
    class trinomera
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vali number alates 1 kuni 30 :");
            
            int a = int.Parse(Console.ReadLine()); ;


            
            if (a>1 && a<10)
            {
                Console.WriteLine("***");
            }
            else if(a > 11 && a < 20)
            {
                Console.WriteLine("*****");
            }
            else if (a > 21 && a < 30)
            {
                Console.WriteLine("*******");
            }
            else
            {
                Console.WriteLine("minus");
            }





            Console.ReadLine();

        }
    }
}
