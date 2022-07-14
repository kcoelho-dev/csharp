using ByteBank.Employees;

namespace ByteBank.Systems
{
    public class InternalSystem
    {
        public bool Login(Authenticable employee, string password)
        {
            bool authenticatedUser = employee.Authenticate(password);
            
            if (authenticatedUser) // If authenticatedUser == true
            {
                Console.WriteLine("Hello " + employee.Name + "!\nWelcome to ByteBank System!");
                return true;
            }
            else
            {
                Console.WriteLine("\t***Invalid Password to user*** '" + employee.Name + "'\n\t***Try again in few seconds!");
                return false;
            }
        }
    } // End of class InternalSystem
} // End of namespace Systems