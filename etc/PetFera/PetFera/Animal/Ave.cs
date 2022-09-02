using PetFera.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFera.Animal
{

    internal class Ave : Animal
    {
        public int TamanhoBico { get; set; }
        public int Envergadura { get; set; }
        public Ave(string classe, string nome, string cientifico, char sexo, float tamanho, string dieta, string nomeBatismo, Veterinario veterinario, Tratador tratador)
            : base(classe, nome, cientifico, sexo, tamanho, dieta, nomeBatismo, veterinario, tratador)
        {
        }

    }
}
