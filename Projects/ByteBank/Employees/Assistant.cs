namespace ByteBank.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string cpf) : base(cpf)
        {
            Console.WriteLine("Creating New Assistant");
        }


        public override void WageRaise()
        {
            Wage *= 1.10;
        }

        public override double GetBonus()
        {
            return Wage * 0.20;
        }
    }
}