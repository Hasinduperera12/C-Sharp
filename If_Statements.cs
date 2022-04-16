class If_Statements
{
    static void Main(string[] args)
    {
       
       bool isMale = true;
       bool isTall = false;

       if (isMale && isTall)
       {
           Console.WriteLine("You are tall and male");
       }
       else if (isMale && !isTall)
       {
           Console.WriteLine("You are short male");
       }
       else if (!isMale && isTall)
       {
           Console.WriteLine("You are not male but you are tall");
       }
       else
       {
           Console.WriteLine("You are not male and not tall");
       }

    }
    
}
