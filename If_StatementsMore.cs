class If_StatementsMore
{
    static void Main(string[] args)
    {
       Console.WriteLine("\n");

       Console.Write("Enter your first subject Mark: ");
       int num1 = Convert.ToInt32(Console.ReadLine());

       Console.Write("Enter your second subject Mark: ");
       int num2 = Convert.ToInt32(Console.ReadLine());

       Console.Write("Enter your third subject Mark: ");
       int num3 = Convert.ToInt32(Console.ReadLine());

       int count = (num1 + num2 + num3);
       float finalcount = count/3;

       Console.WriteLine("---------------------------------" + "\n");
       Console.WriteLine("Your Final Mark is = " + finalcount + "\n");

       if (finalcount >= 75 && finalcount <= 100)
       {
          Console.WriteLine("Grat! You have \" A \" ");
       }
       else if (finalcount >= 65 && finalcount <= 75)
       {
           Console.WriteLine("Congralutation! You have \" B \" ");
       }
       else if (finalcount >= 55 && finalcount < 65)
       {
           Console.WriteLine("Congralutation! You have \" C \" ");
       }
       else if (finalcount >= 45 && finalcount < 55)
       {
           Console.WriteLine("Try again! You have \" S \" ");
       }
       else
       {
           Console.WriteLine("Sorry! You have \" F \" ");
       }
       
    
    }
}
