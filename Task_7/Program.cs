internal class Program
{
    private static void Main(string[] args)
    {
        List<ExcellentStudents> students = new List<ExcellentStudents>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "end")
            {
                break;
            }
            string firstName = input[0];
            string lastName = input[1];
            int[] mark = new int[]{ int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]) };
            ExcellentStudents student = new ExcellentStudents(firstName, lastName, mark);
            students.Add(student);
        }
        var output = students.Where(m => m.Mark.Contains(6));
        foreach (var student in output) {
            Console.WriteLine(student);
        }
    }
}