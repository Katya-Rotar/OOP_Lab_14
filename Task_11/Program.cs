internal class Program
{
    private static void Main(string[] args)
    {
        List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "students:") { break; }
            string specialtyName = input[0] + " " + input[1];
            string facultyNumber = input[2];
            StudentSpecialty specialty = new StudentSpecialty(specialtyName, facultyNumber);
            studentSpecialties.Add(specialty);
        }
        List<Students> students = new List<Students>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "end") { break; }
            string facultyNumber = input[0];
            string name = input[1] + " " + input[2];
            Students student = new Students(name, facultyNumber);
            students.Add(student);
        }
        var output = from student in students
                     join specialties in studentSpecialties on student.FacultyNumber equals specialties.FacultyNumber
                     orderby student.Name
                     select new
                     {
                         StudentName = student.Name,
                         FacultyNumber = student.FacultyNumber,
                         SpecialtyName = specialties.SpecialtyName
                     };
        foreach(var result in output)
        {
            Console.WriteLine($"{result.StudentName} {result.FacultyNumber} {result.SpecialtyName}");
        }
    }
}