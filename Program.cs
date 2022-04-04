class car
{
    string colour = "Blacku";
    string name = "BMW";
    int model = 2022;

    static void Main(String[]args)
    {
        car krish = new car();
        Console.WriteLine("Colour of my BMW is "+ krish.colour);
        Console.WriteLine("Name of my car is "+ krish.name);
        Console.WriteLine("Model of my BMW is " +krish.model);
    }
}