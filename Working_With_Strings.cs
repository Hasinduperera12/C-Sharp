class Working_With_Strings{
	
	static void Main(string[] args)
    {
        Console.WriteLine("\n");

        //string phrase = "Sashen Hasindu " + "is Cool";
        string phrase = "Enter The Magic";
                            //0123

        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase.ToUpper());
        Console.WriteLine(phrase.ToLower());
        Console.WriteLine(phrase[0]);
        Console.WriteLine(phrase[2]);
        Console.WriteLine(phrase[7]);
        Console.WriteLine(phrase.IndexOf("Magic"));
        Console.WriteLine(phrase.IndexOf("T"));
        //Console.WriteLine(phrase.Substring(10, 2) );


        Console.WriteLine("\n");

        Console.WriteLine("Enter The Magic");
        Console.WriteLine("Enter\nThe\nMagic");
        Console.WriteLine("Enter The \"Magic\"");
    }
	
	
	
}