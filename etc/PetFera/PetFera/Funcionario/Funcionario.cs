using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFera.Funcionario
{
    public abstract class Funcionario
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public short Idade { get; set; }
        public short TipoSanguineo { get; set; }
        public char FatorRH { get; set; }
        public string Especialidade { get; set; }

        public Funcionario (int id, string name, short idade, short tipoSanguineo, char fatorRH, string especialidade)
        {
            ID = id;
            Name = name;
            Idade = idade;
            TipoSanguineo = tipoSanguineo;
            FatorRH = fatorRH;
            Especialidade = especialidade;
        }
    }
}
