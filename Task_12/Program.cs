internal class Program
{
    private static void Main(string[] args)
    {
        List<Orders> orders = new List<Orders>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" - ");
            string company = input[0];
            int amount = int.Parse(input[1]);
            string product = input[2];
            Orders order = new Orders(company, amount, product);
            orders.Add(order);
        }
        var output = orders.GroupBy(g => g.Company)
                           .OrderBy(o => o.Key);
        foreach (var order_2 in output)
        {
            Console.Write($"{order_2.Key}: ");
            var product = order_2.GroupBy(g => g.Product)
                                 .Select(s => $"{s.Key}-{s.Sum(a => a.Amount)}");
            Console.WriteLine(string.Join(", ", product));
        }
    }
}