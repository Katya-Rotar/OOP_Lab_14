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
            string email = input[2];
            Student student = new Student(firstName, lastName, email);
            students.Add(student);
        }
        var output = students.Where(s => s.Email.EndsWith("@gmail.com"));
        foreach(var student in output)
        {
            Console.WriteLine(student);
        }
    }
}