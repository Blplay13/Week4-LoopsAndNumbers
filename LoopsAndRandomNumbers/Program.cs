using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm, mis kusib kasutajal sisestada PIN-koodi
            //programm vordleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis kosool kuvab "Tere tulemast!"
            //kui sisestatud PIN-Kood on midagi muud, siis konsool "Vale PIN. Proovi uuesti!"
            //kasutajal on kolm katset. i < 3

            int i = 0; //i - iteration

            while (i < 3) //while-loop >> i = 1; 1 < 3 -->; 2 < 3 --> true; 3 < 3 --> false;
            {
                Console.WriteLine("Sisestage oma PIN-kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1 == i++
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jaanud.");
                }


                Console.WriteLine("Kena paeva!");
            }

        }
    }
}
