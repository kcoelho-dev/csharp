namespace ByteBank.Pessoa
{
	public class Pessoa
	{
		public string Nome { get; set; } /* A property to the name of a person. */
		public string Cpf { get; set; } /* A property to the Cpf of a person */
		public string Telefone { get; set; } /* A property to the Phone of a person */
		public string  Endereco { get; set; } /* A property to the Adress of a Person */

		public Pessoa(string nome, string cpf, string telefone, string endereco)
		{
			this.Nome = nome;
			this.Cpf = cpf;
			this.Telefone = telefone;
			this.Endereco = endereco;
		}

	}
}