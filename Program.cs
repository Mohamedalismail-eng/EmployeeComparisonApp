using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object and assign properties
            Employee emp1 = new Employee()
            {
                Id = 101,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create second Employee object and assign properties
            Employee emp2 = new Employee()
            {
                Id = 102,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded ==
            if (emp1 == emp2)
            {
                Console.WriteLine("Both employees have the same ID.");
            }
            else
            {
                Console.WriteLine("The employees have different IDs.");
            }

            // Compare the two Employee objects using the overloaded !=
            if (emp1 != emp2)
            {
                Console.WriteLine("Confirmed: The employees are not the same.");
            }
            else
            {
                Console.WriteLine("Confirmed: The employees are the same.");
            }

            // Keep the console open
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
