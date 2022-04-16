class Building_a_Mad_Lib
{
	
	static void Main(string[] args)
    {
        Console.WriteLine("\n");

        string color,pluralNoune, celebrity;

        Console.Write("Enter a color: ");
        color = Console.ReadLine();

        Console.Write("Enter a pluralNoune: ");
        pluralNoune = Console.ReadLine();

        Console.Write("Enter a celebrity: ");
        celebrity = Console.ReadLine();

        Console.WriteLine("Rose are " + color);
        Console.WriteLine(pluralNoune +" is blue");
        Console.WriteLine("I Love " + celebrity);
        
    }
}