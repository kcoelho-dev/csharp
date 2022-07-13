namespace ByteBank.Employees
{
    public class Developer : Employee
    {

        public Developer(string cpf) : base(cpf)
        {
            Console.WriteLine("Creating New Developer");
        }

        public override void WageRaise()
        {
            Wage *= 1.15;
        }
        public override double GetBonus()
        {
            return Wage * 0.10;
        }

    }
}