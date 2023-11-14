class Person{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Group { get; set; }

    public Person(string firstName, string lastName, int group) {
        FirstName = firstName;
        LastName = lastName;
        Group = group;
    }
}
