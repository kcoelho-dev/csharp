namespace ByteBank.Employees
{
    public class AccountManager : Employee
    {
        public AccountManager (string cpf) : base (cpf)
        {
            Console.WriteLine("Creating New Account Manager");
        }

        public override void WageRaise()
        {
           Wage *= 1.05;
        }

        public override double GetBonus()
        {
            return Wage * 0.25;
        }

    }
}