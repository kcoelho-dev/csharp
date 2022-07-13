namespace ByteBank.Employees
{
    public class Designer : Employee
    {
        public Designer(string cpf) : base(cpf)
        {
            Console.WriteLine("Creating New Designer");
        }

        public override void WageRaise()
        {
            Wage *= 1.11;
        }
        
        public override double GetBonus()
        {
            return Wage * 0.17;
        }

    }
}