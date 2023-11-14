internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "end") {
                break;
            }
            string firstName = input[0] + " " + input[1];
            int group = int.Parse(input[2]);
            Student student = new Student(firstName, group);
            students.Add(student);
        }
        var output = from student in students
                     where student.Group == 2
                     orderby student.FirstName
                     select student;
        foreach(var student in output) {
            Console.WriteLine(student);
        }
    }
}