using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class MainMethod
    {   
        static void Main(string[] args)
        {
            Employee jozsi = new Employee("Jozsi", DateTime.Now, 1000, "szerelő");
            jozsi.Room = new Room(666);

            Employee jozsi2 = (Employee)jozsi.Clone();
            jozsi2.Room.Number = 667;

            Console.WriteLine(jozsi.ToString());
            Console.WriteLine(jozsi2.ToString());

            Console.ReadKey();

        }
    }
}