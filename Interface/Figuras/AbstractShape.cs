using Enums;

namespace Figuras
{
    abstract class AbstractShape : IShape
    {
        public Colors Colors { get; set; }
        public abstract double Area();
    }
}
