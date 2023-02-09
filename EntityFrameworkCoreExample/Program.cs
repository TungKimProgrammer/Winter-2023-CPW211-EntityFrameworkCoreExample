using EntityFrameworkCoreExample;

using StudentContext dbContext = new ();

// Add with EF Core
Student s = new()
{
    FullName = "Tung Kim",
    EmailAddress = "tung.kim@gmail.com",
    DateOfBirth = new DateTime(2000, 1, 1)
};

dbContext.Students.Add (s); // prepares the Student insert statement
dbContext.SaveChanges(); // executes pending insert. (In actuality: Execute any pending insert/update/delete query)

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax
/*
allStudents = (from stu in dbContext.Students
               select stu).ToList(); // Query syntax
*/

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}
