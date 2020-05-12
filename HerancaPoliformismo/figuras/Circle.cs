using System;
using HerancaPoliformismo.Enums;

namespace HerancaPoliformismo.Entities
{
    class Circle : Shap
    {
        public double Radius { get; set; }

        public Circle(double radius, Colors colors) : base(colors)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
