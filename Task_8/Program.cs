internal class Program
{
    private static void Main(string[] args)
    {
        List<StudentsEnrolled> students = new List<StudentsEnrolled>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "end")
            {
                break;
            }
            string facultyNumber = input[0];
            int[] mark = new int[] { int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]) };
            StudentsEnrolled student = new StudentsEnrolled(facultyNumber, mark);
            students.Add(student);
        }
        var output = students.Where(s => s.FacultyNumber.EndsWith("14") || s.FacultyNumber.EndsWith("15"));
        foreach (StudentsEnrolled student in output) {
            Console.WriteLine(student);
        }
    }
}