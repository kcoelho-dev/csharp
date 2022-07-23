namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
            

			CarregarContas();
			Console.WriteLine("Execução finalizada. Tecle enter para sair");
		}

		private static void CarregarContas()
		{

            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }
			// LeitorDeArquivo leitor = null;
			// try
			// {
            //     leitor = new LeitorDeArquivo("contas.txt");

			// 	leitor.LerProximaLinha();
			// 	leitor.LerProximaLinha();
			// 	leitor.LerProximaLinha();
			// }
			// catch (IOException)
			// {
			// 	Console.WriteLine("Excessão do tipo IOException capturada e tratada!");
			// }
			// finally
			// {
            //     if(leitor != null)
            //     {
			// 	    leitor.Fechar();
            //     }
			// }
		}
		private static void TestaInnerException()
		{
			try
			{
				ContaCorrente conta1 = new ContaCorrente(4564, 789684);
				ContaCorrente conta2 = new ContaCorrente(7891, 456794);

				// conta1.Transferir(10000, conta2);
				conta1.Sacar(10000);
			}
			catch (OperacaoFinanceiraException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);

				// Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

			}
		}
	}

}
