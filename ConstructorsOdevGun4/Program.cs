using System;

namespace ConstructorsOdevGun4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id=09, Name="Özgür",LastName="Özyiğit",City="Aydın"};

            Customer customer2 = new Customer ( 44, "Nurhan", "Özyiğit", "Malatya" );
            
            Console.WriteLine(customer2.Name);

        }
    }
}
class Customer
{
    public Customer()
    {
        

    }
    public Customer(int id, string name, string lastName, string city)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}

