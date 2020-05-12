using System;
using System.Collections.Generic;
using System.Text;
using HerancaPoliformismo.Enums;

namespace HerancaPoliformismo.Entities
{
    class Rectangle : Shap
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Colors colors) : base(colors)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
