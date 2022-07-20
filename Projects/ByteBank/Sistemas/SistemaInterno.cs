namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo ao Sistema ByteBank!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }	//End of class SistemaInterno
}	//End of namespace ByteBank.Sistemas