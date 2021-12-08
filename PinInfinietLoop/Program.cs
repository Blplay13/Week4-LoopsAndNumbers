using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinInfinietLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm, mis kusib kasutajal sisestada PIN-koodi
            //programm vordleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis kosool kuvab "Tere tulemast!"
            //kui sisestatud PIN-Kood on midagi muud, siis konsool "Vale PIN. Proovi uuesti!"
            //katsete arv on piiramatu

            bool loopActive = true; // boolean --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());
            
                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
             
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi sisestanud {i} korda");

                }

                Console.WriteLine("Kena paeva!");
            }
        }
    }
}
