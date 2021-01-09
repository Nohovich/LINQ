using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Select clause in SQL allows to specify what columns we want to retrieve. 
            // In a similar fashion LINQ SELECT standard query operator allows us to specify what properties we want to retrieve. 
            // It also allows us to perform calculations.

            // Retrieves just the EmployeeID property of all employees
            IEnumerable<int> employeeIds = Employee.GetAllEmployees()
                .Select(emp => emp.EmployeeID);
            foreach (int id in employeeIds)
            {
                Console.WriteLine(id);
            }

            // Computes FullName and MonthlySalay of all employees and projects these 2 new computed properties into anonymous type.
            var result = Employee.GetAllEmployees().Select(emp => new
            {
                FullName = emp.FirstName + " " + emp.LastName,
                MonthlySalary = emp.AnnualSalary / 12
            });

            foreach (var v in result)
            {
                Console.WriteLine(v.FullName + " - " + v.MonthlySalary);
            }

            // SelectMany Operator belong to Projection Operators category. 
            // It is used to project each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence.

            // Projects all subject strings of a given a student to an IEnumerable<string>. In this example since we have 4 students,
            // there will be 4 IEnumerable<string> sequences, which are then flattened to form a single sequence i.e a single IEnumerable<string> sequence.
            IEnumerable<string> allSubjects = Student.GetAllStudetns().SelectMany(s => s.Subjects);
            foreach (string subject in allSubjects)
            {
                Console.WriteLine(subject);
            }

            //  Projects each string to an IEnumerable<char>. 
            // In this example since we have 2 strings, there will be 2 IEnumerable<char> sequences,
            // which are then flattened to form a single sequence i.e a single IEnumerable<char> sequence.

            string[] stringArray =
                {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            IEnumerable<char> resultChar = stringArray.SelectMany(s => s);

            foreach (char c in resultChar)
            {
                Console.WriteLine(c);
            }

        }
    }
}
