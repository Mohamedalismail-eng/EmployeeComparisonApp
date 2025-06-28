using System;

namespace EmployeeComparisonApp
{
    // Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        public int Id { get; set; }             // Unique identifier for the employee
        public string FirstName { get; set; }   // Employee's first name
        public string LastName { get; set; }    // Employee's last name

        // Overload == operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Handle null cases safely
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload != operator to ensure both operators are overloaded
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals and GetHashCode for good practice
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            if (other == null) return false;
            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
