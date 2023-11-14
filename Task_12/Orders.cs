class Orders{
    public string Company {  get; set; }
    public int Amount { get; set; }
    public string Product {  get; set; }
    public Orders(string company, int amount, string product)
    {
        Company = company;
        Amount = amount;
        Product = product;
    }
}
