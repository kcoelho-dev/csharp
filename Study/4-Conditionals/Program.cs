using System;

class Program
{
    static void Main(string[] args)
    {
        int idade = 17;
        int qnt_pessoas = 1;
        if (idade >= 18)
        {
            Console.WriteLine("João tem " + idade + " anos e é maior de idade. Pode entrar!");
        }
        else
        {
            if (qnt_pessoas > 1)
            {
                Console.WriteLine("João é menor de idade. Felizmente ele está acompanhado. Pode entrar João!");
            }
            else
            {
                Console.WriteLine("João está sozinho e não é maior de idade. Vai pra casa João!");
            }

        }
    }
}