namespace ByteBank.Employees
{

    public class Employee
    {
        public static int TotalEmployees { get; private set;}
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Wage { get; set; }


        public Employee ()
        {
            Console.WriteLine("Criando Funcionario '" + Name + "'");
            TotalEmployees++;
        }

        /**
*@about    Using tag 'virtual'
*@brief    To better explain the operation of the 'virtual' tag, we can describe, for this situation, that the Employee class is the main class
           of this Employees family (in addition to the Employees namespace). A type of "Default Class".
           Then we can say that the standard bonus rate for the Employees family is 10%.
           In order to ensure that subclasses (or child classes) can override this 10% default bonus, the 'virtual' tag must be used,
           allowing the correct use of the 'override' tag in the child classes, consequently changing the call of this method.
**/
        public virtual double GetBonus() { return Wage * 0.10; }


    }
}