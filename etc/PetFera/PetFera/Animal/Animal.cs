using PetFera.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFera.Animal
{
    public abstract class Animal
    {
        public static int ID { get; private set; }
        public string Classe { get; set; }
        public string Nome { get; set; }
        public string Cientifico { get; set; }

        private char Sexo;

        public char GetSexo()
        {
            return Sexo;
        }

        public void SetSexo(char value)
        {
            if (value != 'M' || value != 'm' || value != 'F' || value != 'f')
            {
                throw new ArgumentException("Impossível definir sexo do animal!\nCaracteres aceitos: 'M' para macho ou 'F' para fêmea");
            }
          
            Sexo =  Char.ToUpper(value);
        }

        public float Tamanho { get; set; }
        public string Dieta { get; set; }
        public string NomeBatismo { get; set; }

        Veterinario veterinario = null;
        Tratador tratador = null;

        public Animal(string classe, string nome, string cientifico, char sexo, float tamanho, string dieta, string nomeBatismo, Veterinario veterinario, Tratador tratador)
        {
            ID+=1;
            Classe = classe;
            Nome = nome;
            Cientifico = cientifico;
            SetSexo(sexo);
            Tamanho = tamanho;
            Dieta = dieta;
            NomeBatismo = nomeBatismo;
            this.veterinario = veterinario;
            this.tratador = tratador;
        }
    }
}
