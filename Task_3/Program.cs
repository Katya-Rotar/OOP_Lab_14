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
            int age = int.Parse(input[2]);
            Student student = new Student(firstName, lastName, age);
            students.Add(student);
        }
        var output = from student in students
                     where student.Age >= 18 && student.Age <= 24
                     select student;
        foreach (var student in output)
        {
            Console.WriteLine(student);
        }
    }
}