using ByteBank.Employees;
using ByteBank.Systems;



public abstract class Authenticable : Employee
{
    // Property 
    public string Password { get; set; }
    public Authenticable(string cpf) : base(cpf) {/****/}
    public bool Authenticate(string password)
    {
        return Password == password;
    }
}