using PetFera.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFera.Animal
{
    internal class Reptil : Animal
    {
        public bool Venenoso { get; set; }
        public string TipoVeneno { get; set; }
        public Reptil(string classe, string nome, string cientifico, char sexo, float tamanho, string dieta, string nomeBatismo, Veterinario veterinario, Tratador tratador)
            : base(classe, nome, cientifico, sexo, tamanho, dieta, nomeBatismo, veterinario, tratador)
        {
        }
    }
}
