using ByteBank;
using ByteBank.Funcionarios;


GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario carlos = new Funcionario("Carlos Alberto","166.666.777-89", 13321.83);
gerenciador.Registrar(carlos);
Console.WriteLine("Bonificação de " + carlos.Nome);
Diretor kelvin = new Diretor("Kelvin Coelho", "111.333.888-88", 22331.66);
gerenciador.Registrar(kelvin);

Console.WriteLine("O total de bonificação registrado no sistema é: R$" + gerenciador.GetTotalBonificacao());

Console.WriteLine("Ok");
Console.WriteLine("Ok");
Console.WriteLine("Ok");
Console.WriteLine("Ok");