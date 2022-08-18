// See https://aka.ms/new-console-template for more information
using System;
class vechile
{
    string Brand_Name;
    public void Quality()
    {
        Console.WriteLine("Quality is so good");
    }
    public void Price( int x)
    {
        Console.WriteLine("The price of the Vechile is"+" " + "" + "" + x);
    }
    public void Customer_Support(string name)
    {
        Console.WriteLine("Customer support is "+""+name);
    }
    static void Main()
    {
        vechile v = new vechile();
        Console.WriteLine(v.Brand_Name = "Royal Enfield");
        v.Quality();
        v.Price(120000);
        v.Customer_Support("Good");
        Console.ReadLine();


    }
}
