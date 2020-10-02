using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottozos_bead
{
    class Program
    {
       static void Main(string[] args)

 

        {
            int[] tomb = new int[5];
            int szam;
           // int szamlalo = 0;
            for (int i = 0; i < 5; i++)
            {
              
                do
                {
                    Console.WriteLine("adjon meg egy számot 1 és 90 között");
                    
                    szam = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("adjon meg egy számot 1 és 90 között");
                    //int masodik_szam;
                    //masodik_szam = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("adjon meg egy számot 1 és 90 között");
                    //int harmadik_szam;
                    //harmadik_szam = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("adjon meg egy számot 1 és 90 között");
                    //int negyedik_szam;
                    //negyedik_szam = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("adjon meg egy számot 1 és 90 között");
                    //int otodik_szam;
                    //otodik_szam = Convert.ToInt32(Console.ReadLine());

                } while (szam>91 || szam <1);

                tomb[i] = szam;

            }


            Console.WriteLine("program vége!");
            Console.ReadKey();


        }
    }
}
