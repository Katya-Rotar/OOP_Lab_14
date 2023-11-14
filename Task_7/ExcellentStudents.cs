class ExcellentStudents{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int[] Mark {  get; set; }    
    public ExcellentStudents(string firstName, string lastName, int[] mark)
    {
        FirstName = firstName;
        LastName = lastName;
        Mark = mark;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
