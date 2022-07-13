using ByteBank.Employees;


namespace ByteBank
{
    public class BonusManager
    {
        private double totalBonus;
        public void Register(Employee employee)
        {
            totalBonus += employee.GetBonus();
        }


        public double GetTotalBonus()
        {
            return totalBonus;
        }

    }
}