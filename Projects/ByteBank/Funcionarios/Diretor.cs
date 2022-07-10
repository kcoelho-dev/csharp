using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor
    {
        public Diretor(string nome, string cPF, double salario) { Nome = nome; CPF = cPF; Salario = salario; }

        // Property 1
        public string Nome { get; set; }
        // Property 2
        public string CPF { get; set; }
        // Property 3
        public double Salario { get; set; }


        public double GetBonificacao()
        {
            return Salario;
        }
    }
}