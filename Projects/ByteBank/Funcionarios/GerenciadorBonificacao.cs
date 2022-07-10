using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            totalBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            totalBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return totalBonificacao;
        }

        
    }
}