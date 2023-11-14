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
        var output = students.OrderBy(x => x.LastName)
                             .ThenByDescending(y => y.FirstName);
        foreach (var student in output)
        {
            Console.WriteLine(student);
        }
    }
}