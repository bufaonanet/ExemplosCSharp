using System;
using System.Globalization;

namespace Figuras
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }
        
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Colors
                + ", Radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)              
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
