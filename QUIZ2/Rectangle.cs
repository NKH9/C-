using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace quiz1_nikakhorbaladze
{
    class Rectangle:Shape
    {
        private double length;
        private double width;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
        }
        public string getarea()
        {
            return $"Circle Area:  {area}";
        }
    }
}
