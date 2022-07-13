namespace ByteBank.Employees
{
    public class AccountManager : Employee
    {
        public AccountManager (string cpf) : base (cpf)
        {
            Console.WriteLine("Creating New Account Manager");
        }

        public override double GetBonus()
        {
            return Wage + base.GetBonus();
        }

        public override void WageRaise()
        {
           Wage *= 0.25;
        }
    }
}