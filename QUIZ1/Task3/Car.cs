using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2_NikaKhorbaladze.Task3
{
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Car is accelerating");
        }
    }
}
