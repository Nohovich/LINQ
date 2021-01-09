using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // OrderBy, OrderByDescending, ThenBy, and ThenByDescending can be used to sort data. Reverse method simply reverses the items in a given collection.
          
            // Sort Students by Name in ascending order
            IEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.Name);
            foreach (Student student in result)
            {
                Console.WriteLine(student.Name);
            }

            // OrderBy, OrderByDescending, ThenBy, and ThenByDescending can be used to sort data. Reverse method simply reverses the items in a given collection.
            // OrderBy or OrderByDescending work fine when we want to sort a collection just by one value or expression. 
            // If want to sort by more than one value or expression, that's when we use ThenBy or ThenByDescending along with OrderBy or OrderByDescending.

            // Sorts Students first by TotalMarks in ascending order(Primary Sort) 
            // The 4 Students with TotalMarks of 800, will then be sorted by Name in ascending order(First Secondary Sort)
            // The 2 Students with Name of John, will then be sorted by StudentID in ascending order(Second Secondary Sort)
            
            IEnumerable<Student> resultStudent = Student.GetAllStudents()
                .OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenBy(s => s.StudentID);
            foreach (Student student in resultStudent)
            {
                Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
            }
        }
    }
}
