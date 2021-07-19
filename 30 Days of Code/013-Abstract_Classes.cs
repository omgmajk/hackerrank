class MyBook : Book
{
    private int price = 0;

    public MyBook(string t, string a, int p) : base(t, a)
    {
        this.price = p;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nPrice: {price}");
    }
}
