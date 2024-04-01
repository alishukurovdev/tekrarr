using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirus
{
    internal class Tesla : ElectricCar
    {
        public string Model { get; }
        public const string Test = "Salam";
        public Tesla(string model)
        {
            Model = model;
        }
        public void MaxSpeed()
        {
            switch (Battery)
            {
                case > 80:
                    Console.WriteLine("Max speed is 350");
                    break;
                case > 60:
                    Console.WriteLine("Max speed is 300");
                    break;
                case > 40:
                    Console.WriteLine("Max speed is 220");
                    break;
                case > 20:
                    Console.WriteLine("Max speed is 150");
                    break;
            }
        }
        public void Drive()
        {
            Random r = new Random();
            int usedBattery = r.Next(30);
            Battery -= usedBattery;
            Console.WriteLine($"Driver used {usedBattery}% battery. Battery : {Battery}");
        }

    }
}