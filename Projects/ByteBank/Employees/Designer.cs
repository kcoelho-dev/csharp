namespace ByteBank.Employees
{
    public class Designer : Employee
    {
        public Designer (string cpf) : base (cpf)
        {
            Console.WriteLine("Creating New Designer");
        }

        public override double GetBonus()
        {
            return Wage + base.GetBonus();
        }

        public override void WageRaise()
        {
           Wage *= 0.17;
        }
    }
}