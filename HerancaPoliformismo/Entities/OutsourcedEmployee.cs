namespace HerancaPoliformismo.Entities
{
    /// <summary>
    /// Empregado terceirizado. A classe <see cref="OutsourcedEmployee"/> herda de <see cref="Employee"/>
    /// </summary>
    class OutsourcedEmployee : Employee
    {
        /// <summary>
        /// <see cref="AddicionalCharge"/> armazena os custos adiciona. do
        /// funcionário terceirizado
        /// </summary>
        public double AddicionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }
        public OutsourcedEmployee(string name, int hour, double valuePerHour, double addicionalCharge)
            : base(name, hour, valuePerHour)
        {
            AddicionalCharge = addicionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() * 1.1 + AddicionalCharge;
        }

    }
}
