class Constructors{
	
	static void Main(string[] args){

        Console.WriteLine("\n");

        Book myBook = new Book("Harry Potter", "JK Rowling", 400);

        Book myBook2 = new Book("Lord of the ring", "Tolkein", 700);

       // Book myBook3 = new Book();

        myBook.title = "The Hobbit";

        Console.WriteLine(myBook.title);
        Console.WriteLine(myBook.author);
        Console.WriteLine(myBook.pages + "\n");

        Console.WriteLine(myBook2.title);
        Console.WriteLine(myBook2.author);
        Console.WriteLine(myBook2.pages);
        

    }

}