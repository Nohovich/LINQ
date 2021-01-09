using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingLINQQueries
{
    // There are 2 ways to write LINQ queries
    // 1. Using Lambda Expressions
    // 2. Using SQL like query expressions
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ query using Lambda Expressions.
            IEnumerable<Student> studentsLambda = Student.GetAllStudents()
                .Where(student => student.Gender == "Male");

           // LINQ query using using SQL like query expressions
            IEnumerable<Student> studentsQuery = from student in Student.GetAllStudents()
                                                 where student.Gender == "Male"
                                            select student;
            foreach(Student student in studentsLambda)
            {
                Console.WriteLine(student.Name);

            }
            Console.ReadKey();
        }
    }
}
