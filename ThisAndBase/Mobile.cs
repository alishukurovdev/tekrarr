using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBase
{
    public class Mobile : Device
    {
        public string[] SimCards;

        public Mobile(int SimCardCount) 
        {
            if(SimCardCount <1 || SimCardCount>2) {

                Console.WriteLine("SimCardCount between 1 or 2");
            }
            SimCards = new string[SimCardCount];
        }

        public void GetNumbers()
        {
            Console.WriteLine("You number");
            for (int i = 0; i < SimCards.Length; i++)
            {
                
                Console.WriteLine($"{i}. {SimCards[i]}");
            }
        }

        public void AddNumber(int index, string number)
        {

            SimCards[index] = number;
            }
        public void RemoveNumber(int index)
        {
           // SimCards[index] = null;
        }
    }
}
//Mobile:   +++
//string[] SimCards field - ı var. +++
//Mobile classından obyekt yaranan zaman SimCardCount parametrini məcbur qəbul edir. +++
//SimCardCount minimum 1 maksimum 2 ola bilər.++
//Bu parametr SimCards field-inin uzunluğunu təyin edir.++
//AddNumber++, RemoveNumber, GetNumbers++ methodları ilə istifadəçi nömrələrə baxa, nömrə əlavə və ya nömrənin indeksini bildirərək silə bilər.
