using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Kelvin";
            p1.Id = p1.Id++;
            

            Console.WriteLine("O ID de " + p1.Nome + " é: " + p1.Id);
        }

    }
}
