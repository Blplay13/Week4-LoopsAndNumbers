using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab seda numbrit ara arvama;
            //kui kasutaja suutis numbri arvata, siis ta on mangu voitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku nubrit vaid uhe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Tere tulemast! Hakkate mangima araarvamismangu.");
            Console.WriteLine("Palun arva ara konsooli genereeritud number:");

            bool loopActive = true;
            while (loopActive)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == cpuNumber)
                {
                    Console.WriteLine("Arvasite oige numbri! Palju onne, olete voitnud");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale arv. Proovi uuesti.");
                }
            }

            Console.WriteLine("Kena paeva!");
        }
    }
}
