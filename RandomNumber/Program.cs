using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm genereerib juhuslikku numbrit;
            //kui genereeritud nimber on 5, programm lopetab oma tood ja soovib kasutajale "kena paeva";
            //kui genereeritud number on midagi muud, siis programm jatkab oma tood.

            Random rnd = new Random();
            int i = 0;

                while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if(myRandomNumber ==5)
                {
                    i = myRandomNumber;
                }

                Console.WriteLine("Kena paeva!");
            }
        }
    }
}
