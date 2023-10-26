using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2_NikaKhorbaladze.Task3
{
    public class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Bike is accelerating");
        }
    }
}
