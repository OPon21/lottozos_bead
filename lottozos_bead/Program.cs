using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lottozos_bead
{
    class Program
    {
        
        
        
         static List<Lotto> lista = new List<Lotto>();

        static void feltolt()
        {
            StreamReader sr = new StreamReader("otos.xlsx");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] temp = sor.Split(';');
                Lotto lottoznak = new Lotto();
                lottoznak.evszam = Convert.ToInt32(temp[0]);
                lottoznak.het = Convert.ToInt32(temp[1]);
                lottoznak.datum = Convert.ToInt32(temp[2]);
                lottoznak.fonyertesek_szama = Convert.ToInt32(temp[3]);
                lottoznak.nyeremeny_5 = Convert.ToInt32(temp[4]);
                lottoznak.negy_talatosok_szama = Convert.ToInt32(temp[5]);
                lottoznak.negy_nyeremeny_ft = Convert.ToInt32(temp[6]);
                lottoznak.harom_talalatosok_szama = Convert.ToInt32(temp[7]);
                lottoznak.harom_nyeremeny = Convert.ToInt32(temp[8]);
                lottoznak.ketto_talalatosok_szama = Convert.ToInt32(temp[9]);
                lottoznak.elso_szam = Convert.ToInt32(temp[10]);
                lottoznak.masodik_szam = Convert.ToInt32(temp[11]);
                lottoznak.harmadik_szam= Convert.ToInt32(temp[12]);
                lottoznak.negyedik_szam = Convert.ToInt32(temp[13]);
                lottoznak.otodik_szam = Convert.ToInt32(temp[14]);


                lista.Add(lottoznak);
            }
            sr.Close();
        }



        
        
        
        
        
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
                   
                } while (szam>91 || szam <1);

                tomb[i] = szam;

            }


            Console.WriteLine("program vége!");
            feltolt();
            Console.ReadKey();


        }
    }
}
