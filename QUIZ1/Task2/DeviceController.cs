using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2_NikaKhorbaladze.Task2
{
    public class DeviceController : IDevice
    {
        private string DeviceType;
        public DeviceController(string deviceType)
        {
            DeviceType = deviceType;
        }
        public void Activate()
        {
            Console.WriteLine($"The {DeviceType} is now active.");
        }
    }
}
