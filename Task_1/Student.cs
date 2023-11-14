class Student{
    public string FirstName { get; set; }
    public int Group {  get; set; }
    public Student(string firstName, int group) {
        FirstName = firstName;
        Group = group;
    }
    public override string ToString()
    {
        return $"{FirstName} {Group}";
    }
}
