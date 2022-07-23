/**
 *
 *  Para fazer que esse código funcione "corretamente", é necessário o uso de várias condicionais para fazer o tratamento 'manual'
 *  das excessões que podem surgir ao longo da execução.
 *  Erros comuns podem surgir como:
 *      - Erro quando dividir valor por zero;
 *      - Problemas de conversão quando a operação resultar em números decimais;
 *      - Necessidade de grande quantidade de código para reverter o não uso das excessões.
 *
**/
namespace _NoException
{
    class NoException
    {
        static void Main(string[] args)
    {
        Metodo();
        Console.ReadLine();
    }

        private static void Metodo()
        {
                TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
                int resultado = Dividir(10, divisor);

                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
                return numero / divisor;
        }
    }
}