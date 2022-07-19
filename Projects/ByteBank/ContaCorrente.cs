using ByteBank.Clientes;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; } = new Cliente("NULL", "NULL", "NULL");
        // public Cliente Titular { get; set; } = new Cliente();


        private int _NumeroAgencia;
        public int NumeroAgencia
        {
            get { return _NumeroAgencia; }
            set
            {
                if (value <= 0) return;
                _NumeroAgencia = value;
            }
        }
        

        public int NumeroConta { get; private set; }

        private double _Saldo;
        public double Saldo
        {
            get { return _Saldo; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _Saldo = value;
            }
        }
        public static int QuantidadeContasCriadas { get; private set; }
        


        public ContaCorrente() { QuantidadeContasCriadas++; }

        public ContaCorrente(Cliente titular, int numeroagencia, int numeroconta, double saldo)
        {
            Titular = titular;
            NumeroAgencia = numeroagencia;
            NumeroConta = numeroconta;
            Saldo = saldo;
            QuantidadeContasCriadas++;
            Console.WriteLine("Nova Conta Criada!\n");
            Console.WriteLine("Titular da Conta: " + Titular.Nome);
            Console.WriteLine("Número da Agência: " + NumeroAgencia);
            Console.WriteLine("Número da Conta: " + NumeroConta);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("************************");
            Console.WriteLine("Quantidade de Clientes ativos: " + QuantidadeContasCriadas);
        }

        public bool Sacar(double valor)
        {
            if (Saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }

        }

        public bool Depositar(double valor)
        {
            if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo += valor;
                return true;
            }
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                contaDestino.Saldo += valor;
                return true;
            }
        }

        public void InformacoesConta()
        {
            Console.WriteLine("Titular da conta: " + Titular.Nome);
            Console.WriteLine("CPF do titular: " + Titular.CPF);
            Console.WriteLine("Profissão: " + Titular.Profissao);
            Console.WriteLine("Número da Conta: " + NumeroConta);
            Console.WriteLine("Número da Agência: " + NumeroAgencia);
            Console.WriteLine("Saldo atual: R$" + Saldo);
        }


    }   //End of class ContaCorrente
}   //End of namespace ByteBank