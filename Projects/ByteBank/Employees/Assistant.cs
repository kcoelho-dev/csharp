namespace ByteBank.Employees
{
    public class Assistant : Employee
    {
        public Assistant (string cpf) : base (cpf)
        {
            Console.WriteLine("Creating New Assistant");
        }

        public override double GetBonus()
        {
            return Wage + base.GetBonus();
        }

        public override void WageRaise()
        {
           Wage *= 0.20;
        }
    }
}