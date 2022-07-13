using ByteBank.Employees;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateBonus();
            Console.ReadLine();
        }   // End Main

        public static void CalculateBonus()
        {
            BonusManager bm = new BonusManager();
            
            Designer samara = new Designer("111.222.333-44");
            samara.Name = "Samara Aparecida";
            bm.Registrar(samara);

            Director ludimila = new Director("554.765.123-82");
            ludimila.Name = "Ludimila Loiola";
            bm.Registrar(ludimila);

            Assistant amanda = new Assistant("332.224.563-22");
            amanda.Name = "Amanda Torres";
            bm.Registrar(amanda);

            AccountManager kelvin = new AccountManager("241.214.142-12");
            kelvin.Name = "Kelvin Coelho";
            bm.Registrar(kelvin);
        }



    }   // End Program

}   // End namespace ByteBank