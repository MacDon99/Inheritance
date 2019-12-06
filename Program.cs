using System;

namespace Inheritance
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //all managers creating options
            Manager manager1 = new Manager();
            //all workers creating options
            Worker worker1 = new Worker();

            Worker worker2 = new Worker("Jan","Kowalski","12345678901");
            
            Worker worker3 = new Worker("Jan", "Kowalski", "12345678901", "Kochanowskiego",12,"Reda","12-200");

            Worker worker4 = new Worker("Jan", "Kowalski", "12345678901", "Kochanowskiego", 12, "Reda", "12-200", "Programista");

            Worker worker5 = new Worker("Jan", "Kowalski", "12345678901", "Kochanowskiego", 12, "Reda", "12-200", "Programista",manager1);
            
            
            //
            //all clients creating options
            Client client1 = new Client();
            Client client2 = new Client("Adam","Nowak","12345678901");
            Client client3 = new Client("Adam","Nowak","12345678901","Orzechowej",12,"Kostkowo","34-400");
            Client client4 = new Client("Drewex","someNIP","Kocia",56,"Kosakowo","23-100");
            Console.ReadKey();
        
        }
       
    }
}
