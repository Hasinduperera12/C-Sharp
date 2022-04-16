class Arrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");

        int [] luckyNumber = {4 ,8, 15, 16, 23, 42};
        string[] friends = new string[5];
        friends[0] = "Hasindu";
        friends[1] = "Jim";


        Console.WriteLine(luckyNumber[0]);
        Console.WriteLine(luckyNumber[3]);

        luckyNumber[1] = 900;

        Console.WriteLine(luckyNumber[1]);

        Console.WriteLine(friends[0]);
        Console.WriteLine(friends[1]);
        
    }
}
