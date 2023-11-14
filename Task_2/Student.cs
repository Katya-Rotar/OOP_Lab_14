using System.Text.RegularExpressions;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
