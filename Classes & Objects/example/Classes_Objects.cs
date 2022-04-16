class Classes_Objects{
	static void Main(string[] args){

        Console.WriteLine("\n");

        Book myBook = new Book();
        myBook.title = "Harry Potter";
        myBook.author = "JK Rowling";
        myBook.pages = 400;

        Book myBook2 = new Book();
        myBook2.title = "Lord of the ring";
        myBook2.author = "Tolkein";
        myBook2.pages = 700;


        Console.WriteLine(myBook.title);
        Console.WriteLine(myBook.author);
        Console.WriteLine(myBook.pages + "\n");

        Console.WriteLine(myBook2.title);
        Console.WriteLine(myBook2.author);
        Console.WriteLine(myBook2.pages);

    }
}