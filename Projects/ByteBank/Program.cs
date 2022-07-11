using ByteBank;
using ByteBank.Employees;




BonusManager manager = new BonusManager();

Employee carlos = new Employee();
{
    carlos.Name = "Carlos Alberto";
    carlos.Wage = 1000;
    carlos.CPF = "077.147.741-71";
    manager.Registrar(carlos);
    Console.WriteLine("Bonificação de " + carlos.Name + ": R$" + carlos.GetBonus());
}


Director kelvin = new Director();
{
    kelvin.Name  = "Kelvin Coelho";
    kelvin.Wage = 5000;
    kelvin.CPF = "011.101.010-11";
    manager.Registrar(kelvin);
    Console.WriteLine("Bonificação de " + kelvin.Name + ": R$" + kelvin.GetBonus());
}


/**
 * @about   Inserting new Employee as a Diretor
 * @brief   Since the Director class inherits the characteristics of the  class Employee,
            this implies that each object of the Director class shares the same basic characteristics of the Employee class.
 * 
**/
Employee samara = new Director();
{
    samara.Name  = "Samara Aparecida";
    samara.Wage = 3000;
    samara.CPF = "011.101.010-11";
    manager.Registrar(samara);
    Console.WriteLine("Bonificação de " + samara.Name + ": R$" + samara.GetBonus());
}


Console.WriteLine(Employee.TotalEmployees);




// manager.Registrar(kelvin);

Console.WriteLine("O total de bonificações registrado no sistema é: R$" + manager.GetTotalBonus());
