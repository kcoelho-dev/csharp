namespace ByteBank.Employees
{
    /**
     * @about Class Director 
     * @param 
     * 
    **/
    public class Director : Employee
    {
        // public Director(string nome, string cPF, double Wage) { Nome = nome; CPF = cPF; Wage = Wage; }


        public Director ()
        {
            Console.WriteLine("Criando Diretor '" + Name + "'");
        }
        /**
         *@about    Using 'override' tag and 'base'
         *@brief    Override - We need to use 'override' explicitly to determine that this function will replace the one contained in
                    its parent class, Employee. If 'override' is not explicit, the function GetBonus() that will be used is the of its
                    superior instance, returning the salary with 10% bonus instead of 100% (as should be from Director class).
                    Base - References a specific function, method or variable of the base class (Employee).
         *
        **/
        public override double GetBonus()
        {
            return Wage + base.GetBonus(); // Returns Wage + Default 10%
        }
    }
}