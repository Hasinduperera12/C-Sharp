class Program{

    static void Main(string[] args){

        Console.WriteLine("\n");

        Movie avengers = new Movie("The Avengers", "Joss Whedon", "DOG");
        Movie shrek  = new Movie("Shrek" , "Adam Admsom", "PG");
        // G, PG, PG-13, R, NR
        avengers.Rating = "PG-13";
        shrek.Rating = "Dog";
        Console.WriteLine(avengers.Rating);

        Console.WriteLine(shrek.Rating);

    }

}