using ByteBank.Employees;


namespace ByteBank
{
    public class BonusManager
    {
        private double totalBonus;
        public void Registrar(Employee employee)
        {
            totalBonus += employee.GetBonus();
        }


        public double GetTotalBonus()
        {
            return totalBonus;
        }

    }
}