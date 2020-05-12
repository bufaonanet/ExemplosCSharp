namespace HerancaPoliformismo.Entities
{
    /// <summary>
    /// Empregado
    /// </summary>
    class Employee
    {
        public string Name { get; set; }
        public int Hour { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }
        /// <summary>
        /// Contrutor de Empregado
        /// </summary>
        /// <param name="name">Nome do Empregado <see cref="Name"/> </param>
        /// <param name="hour">Horas trabalhadas</param>
        /// <param name="valuePerHour">Valor por hora</param>
        public Employee(string name, int hour, double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }
        /// <summary>
        /// Calcula o pagamento do empregado baseado no valor de horas vezes valor
        /// </summary>
        /// <returns>Retorna o pagamento por hora</returns>
        public virtual double Payment()
        {
            return ValuePerHour * Hour;
        }
    }
}
