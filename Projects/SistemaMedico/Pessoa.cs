
namespace sistemaMedico
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public double peso;

        public Pessoa() { nome = "null"; }

        // public Pessoa(string n, int i, double a, double p)
        // {
        //     nome = n;
        //     idade = i;
        //     altura = a;
        //     peso = p;
        // }

        public void print()
        {
            Console.WriteLine("Sistema Médico DigiDoc\n\n");
            Console.WriteLine("Dados de Paciente");
            Console.WriteLine("Nome:\t" + this.nome);
            Console.WriteLine("Idade:\t" + this.idade);
            Console.WriteLine("Altua:\t" + this.altura);
            Console.WriteLine("Peso:\t" + this.peso);
        }
    }
}
