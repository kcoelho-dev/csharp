using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NamespaceDiferente;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse mc = new MinhaClasse(); //Criando um novo objeto com as características da classe MinhaClasse usando construtor padrão
            MinhaClasse m2 = null; //Criando um novo objeto com as características da classe MinhaClasse como referência Nula
            OutraClasse outra = new OutraClasse(); // Como a OutraClasse foi definida dentro do mesmo namespace, é possível referenciar um objet do tipo OutraClasse sem problemas
            ClasseNamespaceDiferente cnd = new ClasseNamespaceDiferente(); // Como esta classe contém um namespace diferente dos demais, é necessário incluir o namespace no inicio do código (linha 6)
        }
    }

    class MinhaClasse
    {

    }
}
