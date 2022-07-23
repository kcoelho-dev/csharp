using SampleClass;

namespace _UsingExceptions
{
    class UsingExceptions
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch(NullReferenceException) // Quando a referência 
            {
                Console.WriteLine("Aconteceu um erro!");
            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Não é possível realizar uma divisão por 0!");
            }

        }
    
        private static int Dividir(int numero, int divisor)
        {
                Sample s = new Sample();
                Console.WriteLine(s.AnString);
                return numero / divisor;
        }

       
    }
}