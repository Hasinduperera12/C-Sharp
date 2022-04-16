class Working_With_Numbers{
	
	
	static void Main(string[] args)
    {
        Console.WriteLine("\n");

        Console.WriteLine(50 + 60);
        Console.WriteLine(70 - 60);
        Console.WriteLine(70 * 60);
        Console.WriteLine(72 / 5.0);
        Console.WriteLine(5 % 2);
        Console.WriteLine((4 + 2.3) * 3);

        Console.WriteLine("----------------------" + "\n");

        int num = 6;
        num++;  // -- / ++
        Console.WriteLine(num);

        Console.WriteLine("----------------------" + "\n");

        Console.WriteLine(Math.Abs(-40));
        Console.WriteLine(Math.Pow(5.3 , 2));
        Console.WriteLine(Math.Sqrt(36));
        Console.WriteLine(Math.Max(40 , 120));
        Console.WriteLine(Math.Min(40 , 120));
        Console.WriteLine(Math.Round(8.5));
    }
	
}