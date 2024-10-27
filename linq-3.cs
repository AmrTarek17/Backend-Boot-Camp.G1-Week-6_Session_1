using System;
using System.Collections.Generic;
using System.Linq;

public class Subject
{
    public int Code { get; set; }
    public string Name { get; set; }
}

public class Student
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Subject[] Subjects { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { ID = 1, FirstName = "Ali", LastName = "Mohammed", 
                Subjects = new Subject[] 
                {
                    new Subject { Code = 22, Name = "EF" },
                    new Subject { Code = 33, Name = "UML" }
                } 
            },
            new Student { ID = 2, FirstName = "Mona", LastName = "Gala", 
                Subjects = new Subject[]
                {
                    new Subject { Code = 22, Name = "EF" },
                    new Subject { Code = 34, Name = "XML" },
                    new Subject { Code = 25, Name = "JS" }
                } 
            },
            new Student { ID = 3, FirstName = "Yara", LastName = "Yousf", 
                Subjects = new Subject[]
                {
                    new Subject { Code = 22, Name = "EF" },
                    new Subject { Code = 25, Name = "JS" }
                } 
            },
            new Student { ID = 4, FirstName = "Ali", LastName = "Ali", 
                Subjects = new Subject[]
                {
                    new Subject { Code = 33, Name = "UML" }
                } 
            }
        };

        // Query1: Display Full name and number of subjects for each student
        Console.WriteLine("Full Name and Number of Subjects:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Subjects.Length} subjects");
        }

        Console.WriteLine(); // Add a new line for separation

        // Query2: Order by FirstName Descending, LastName Ascending, and display First and Last Names
        Console.WriteLine("Ordered Names:");
        var orderedStudents = students
            .OrderByDescending(s => s.FirstName)
            .ThenBy(s => s.LastName)
            .Select(s => new { s.FirstName, s.LastName });

        foreach (var student in orderedStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
    }
}
