internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "end") { break; }
            string firstName = input[0];
            string lastName = input[1];
            int group = int.Parse(input[2]);
            Person person  = new Person(firstName, lastName, group);
            people.Add(person);
        }
        var output = people.GroupBy(p => p.Group).OrderBy(o => o.Key);
        foreach (var person in output) {
            Console.Write($"{person.Key} - ");
            var names = person.Select(s => $"{s.FirstName} {s.LastName}");
            Console.WriteLine(string.Join(", ", names));
        }
    }
}