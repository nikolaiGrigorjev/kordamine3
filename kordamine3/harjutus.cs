using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine3
{
    class harjutus
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
           /* int A = rnd.Next(1, 5);//arvuti arv 
            int AA; //kasutaja arv 
            int K = 1; //katsed 
            do
            {
                Console.WriteLine("{0}. Katse. Mis arv?", K);
                AA = int.Parse(Console.ReadLine());
                K=K+1;
            } while (AA!=A && K!=6);
            if(AA==A)
            {
                Console.WriteLine("Palju õnne!");
            }
            else
            {
                Console.WriteLine("Proovi veel!");
            }*/



            Console.WriteLine("--------------------UUS harjutus---------------------");



            int arv;
            int[] arvud = new int[4];
            for(int i = 0; i<4;i++)
            {
                Console.WriteLine("Sisesta {0} arv:",i+1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            Array.Sort(arvud);
            foreach(var a in arvud)
            {
                Console.Write(a);
            }
            int arv4=1;
            Array.Reverse(arvud);
            foreach (var a in arvud)
            {
                arv4 = arv4 * 10 + a;

            }
            Console.Write(arv4);
            Console.ReadLine();
        }
    }
}
