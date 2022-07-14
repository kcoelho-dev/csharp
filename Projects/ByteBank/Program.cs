using ByteBank.Employees;
using ByteBank.Systems;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando");
            CalculateBonus();

            UsingSystem();

        }

        public static void CalculateBonus()
        {
            BonusManager bm = new BonusManager();

            Employee samara = new Designer("012.123.234-45");
            samara.Name = "Samara Aparecida";
            bm.Register(samara);

            Employee ludimila = new Director("987.876.765-65");
            ludimila.Name = "Ludimila Loiola";
            bm.Register(ludimila);

            Employee amanda = new Assistant("012.234.456-68");
            amanda.Name = "Amanda Torres";
            bm.Register(amanda);

            Employee kelvin = new AccountManager("111.222.333-44");
            kelvin.Name = "Kelvin Coelho";
            bm.Register(kelvin);

            Employee kcoelho = new Developer("055.550.505-50");
            kcoelho.Name = "Kelvin Coelho";
            bm.Register(kcoelho);

            Console.WriteLine("Total de Funcionários Cadastrados: " + Employee.TotalEmployees);
        }

        public static void UsingSystem()
        {
            Console.ReadKey();
            Console.Clear();
            InternalSystem internalSystem = new InternalSystem();
            AccountManager ludimila = new AccountManager("987.876.765-65");
            ludimila.Name = "Ludimila Loiola";

            ludimila.Password = "123";
            internalSystem.Login(ludimila, "123");
            internalSystem.Login(ludimila, "123");

            // Console.WriteLine(internalSystem.Login(ludimila, "123"));
        }
    }
}