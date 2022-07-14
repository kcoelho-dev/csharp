namespace ByteBank.Employees
{
    /**
     * @about Class Director 
     * @param 
     * 
    **/
    public class Director : Authenticable
    {
 
        public Director(string cpf) : base(cpf)
        {
            Console.WriteLine("Creating New Director");
        }

  
        /**
         *@about    Using 'override' tag and 'base'
         *@brief    Override - We need to use 'override' explicitly to determine that this function will replace the one contained in
                    its parent class, Employee. If 'override' is not explicit, the function GetBonus() that will be used is the of its
                    superior instance, returning the salary with 10% bonus instead of 100% (as should be from Director class).
                    Base - References a specific function, method or variable of the base class (Employee).
         *
        **/
        public override void WageRaise()
        {
            Wage *= 1.15;
        }

        public override double GetBonus()
        {
            return Wage * 0.50; // Returns Wage + Default 10%
        }


    }
}