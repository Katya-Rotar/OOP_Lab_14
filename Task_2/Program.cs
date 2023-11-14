internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "end")
            {
                break;
            }
            string firstName = input[0];
            string lastName = input[1];
            Student student = new Student(firstName, lastName);
            students.Add(student);
        }
        var output = from student in students
                     where student.FirstName.ElementAt(0) < student.LastName.ElementAt(0)
                     select student;
        foreach (var student in output)
        {
            Console.WriteLine(student);
        }
    }
}