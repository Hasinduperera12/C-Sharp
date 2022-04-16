class Methods
{
    static void Main(string[] args)
    {
        SayHi("Hasindu" ,20);
        SayHi("John" , 42);
        SayHi("Tom" , 67);

        Console.WriteLine("\n");
    }

    static void SayHi(string name, int age)
    {
        Console.WriteLine("Hello user " + name + " you are " + age);
    }
}
