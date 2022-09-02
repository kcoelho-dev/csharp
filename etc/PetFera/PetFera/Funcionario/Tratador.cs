using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFera.Funcionario
{
    internal class Tratador : Funcionario
    {


        public Tratador(int id, string name, short idade, short tipoSanguineo, char fatorRH, string especialidade)
                     : base(id, name, idade, tipoSanguineo, fatorRH, especialidade)
        {
        }
    }
}
