namespace Pessoa
{
	public class Endereco
	{
		public string? Logradouro { get; set; }
		public int NumeroResidencia { get; set; }
		public string? Bairro { get; set; }
		public string? Cidade { get; set; }
		public string? UF { get; set; }
		public string? CEP { get; set; }

		public Endereco(string logradouro, int numeroResidencia, string bairro, string cidade, string uf, string cep)
		{
			this.Logradouro = logradouro;
			this.NumeroResidencia = numeroResidencia;
			this.Bairro = bairro;
			this.Cidade = cidade;
			this.UF = uf;
			this.CEP = cep;
		}


		public void printAdress() 
		{
			Console.WriteLine();
		}
	}	//End of class Endereco
}	//End of namespace Pessoa