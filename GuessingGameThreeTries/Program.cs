using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm genereerib juhusliku numbri 1 kuni 10,=;
            //kasutaja peab seda numbrit ara arvama;
            //kui kasutaja suutis selle numbri ara arvata, siis ta on mangu voitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud arvu ara arvata;
            //siis mangu voidab arvuti;
            //*programm genereerib juhuslikku numbrit vaid uhe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Tere tulemast! Hakkate mangima araarvamismangu. Teil on kolm katsest.");
            Console.WriteLine("Palun arva ara konsooli genereeritud number:");
            int i = 0;

                while(i < 3)
             {
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == cpuNumber)
                {
                    Console.WriteLine("Arvasite oigesti! Olete mangu voitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale arv.Teil on veel {3 - i} katset on jaanud.");
                }

                Console.WriteLine("Kena paeva!");



            }
            }
        }
    }

