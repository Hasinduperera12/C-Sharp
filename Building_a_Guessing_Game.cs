class Building_a_Guessing_Game{
	
	static void Main(string[] args){
    
        Console.WriteLine("\n");

        string secretWorld = "magic";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outtOfGuess = false;

        do            // while (guess != secretWorld && !outtOfGuess);
        {
            if (guessCount < guessLimit)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;   
            }else
            {
                outtOfGuess = true;
            }
        }while (guess != secretWorld && !outtOfGuess);

        if (outtOfGuess)
        {
            Console.WriteLine("You Lose!");   
        }else
        {
            Console.WriteLine("You Win!");
        }
    }
}