class Program{

    static void Main(string[] args){

        Console.WriteLine("\n");
        
        Chef mychef = new Chef();
        mychef.MakeChicken();
        mychef.MakeSpecialDish();

        ItalianChef myItalianChef = new ItalianChef();
        myItalianChef.MakeSpecialDish();
        myItalianChef.MakePasta();
    }

}