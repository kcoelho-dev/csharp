using PetFera.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFera.Animal
{
    internal class Anfibio : Animal
    {
        public int TotalMudas { get; set; }
        public string UltimaMuda { get; set; }
        public Anfibio(string classe, string nome, string cientifico, char sexo, float tamanho, string dieta, string nomeBatismo, Veterinario veterinario, Tratador tratador)
                : base(classe, nome, cientifico, sexo, tamanho, dieta, nomeBatismo, veterinario, tratador)

        {
        }
    }
}
