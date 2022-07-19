using ByteBank;
using ByteBank.Clientes;

// Console.WriteLine("Nome do cliente null: >" + cc2.NomeTitular + "<");





Cliente kelvin = new Cliente();
kelvin.Nome = "Kelvin Coelho Loiola";
kelvin.CPF = "038.515.295-70";
kelvin.Profissao = "Estudante";

ContaCorrente cc = new ContaCorrente(kelvin, 11234, 221, 12332.32);

cc.Titular = kelvin;

cc.InformacoesConta();

