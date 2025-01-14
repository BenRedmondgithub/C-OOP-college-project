using System;

public class Taxi 
{
    public string brandName;

    public Taxi() 
    {
        brandName = "BMW";
    }
}

class TestTaxi 
{
    static void Main () 
    {
        Taxi t = new Taxi();
        Console.WriteLine(t.brandName);
    }
}
