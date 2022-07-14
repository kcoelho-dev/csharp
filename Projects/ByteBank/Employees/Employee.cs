
namespace ByteBank.Employees
{

    public abstract class Employee
    {
        public static int TotalEmployees { get; private set; }
        public string Name { get; set; }
        public string CPF { get; private set; }

        internal bool Authenticate(string password)
        {
            throw new NotImplementedException();
        }

        public double Wage { get; protected set; }


        public Employee(string cpf)
        {
            CPF = cpf;
            TotalEmployees++;
        }

        public Employee()
        {
            TotalEmployees++;
        }


        public abstract void WageRaise();

        public abstract double GetBonus();

    }
}