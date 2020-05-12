using HerancaPoliformismo.Enums;

namespace HerancaPoliformismo.Entities
{
    abstract class Shap
    {
        public Colors Colors { get; set; }

        protected Shap(Colors colors)
        {
            Colors = colors;
        }

        public abstract double Area();
    }
}
