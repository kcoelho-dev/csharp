
namespace ByteBank.Clientes
{
    public class Cliente
    {
        public string Nome { get; set; } = "NULL";
        public string CPF { get; set; } = "NULL";
        public string Profissao { get; set; } = "NULL";

 
        public Cliente (){}
        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            CPF = cpf;
            Profissao = profissao;
        }

    }	//End of class Cliente
}	//End of namespace ByteBank.Clientes
