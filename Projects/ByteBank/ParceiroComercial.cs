using ByteBank.Sistemas;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }	//End of class ParceiroComercial : IAutenticavel
}   //End of namespace ByteBank