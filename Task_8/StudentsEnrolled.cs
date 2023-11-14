using System.Text;

class StudentsEnrolled{
    public string FacultyNumber {  get; set; }
    public int[] Mark {  get; set; }
    public StudentsEnrolled(string facultyNumber, int[] mark) {
        FacultyNumber = facultyNumber;
        Mark = mark;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < Mark.Length; i++) {
            sb.Append(Mark[i].ToString() + " ");
        }
        return sb.ToString();
    }
}
