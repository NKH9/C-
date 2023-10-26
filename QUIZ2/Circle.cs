using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1_nikakhorbaladze
{
    class Circle:Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            this.radius = radius;
            area = Math.PI * Math.Pow(radius, 2);
        }
        public string getarea()
        {
            return $"Rectangle Area: {area}";
        }
    }
}
