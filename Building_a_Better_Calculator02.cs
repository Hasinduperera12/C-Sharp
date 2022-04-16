class Building_a_Better_Calculator02{
	
	static void Main(string[] args){
    
        Console.WriteLine("\n");

        Console.Write("Enter Your First Number: ");
        double num1 = Convert.ToDouble (Console.ReadLine());
        Console.Write("Enter Your First Number: ");
        double num2 = Convert.ToDouble (Console.ReadLine());

        Console.Write("You Want to ad another number? type Y/N ");
        string ask1 = Convert.ToString(Console.ReadLine());



        if (ask1 == "y")
        {
            Console.Write("Enter Your Third Number: ");
            double num3 = Convert.ToDouble (Console.ReadLine());

            Console.Write("1 Addition\n2 Subtraction\n3 Multiplication\n4 Division\n Enter You want operator number: ");
            int operators = Convert.ToInt32(Console.ReadLine());

                if (operators == 1)
            {
                Console.Write("Addition = ");
                Console.WriteLine((num1 + num2) + num3);
            }
            else if (operators == 2)
            {
                Console.Write("Subtraction = ");
                Console.WriteLine((num1 - num2) - num3);
            }
            else if (operators == 3)
            {
                Console.Write("Multiplication = ");
                Console.WriteLine((num1 * num2) * num3);
            }
            else if (operators == 4)
            {
                Console.Write("Division = ");
                Console.WriteLine((num1 / num2) / num3);
            }
            else
            {
                Console.WriteLine("Incrrect input please enter the correct input");
            }   


        }else if (ask1 == "n")
        {
            Console.Write("1 Addition\n2 Subtraction\n3 Multiplication\n4 Division\n Enter You want operator number: ");
            int operators = Convert.ToInt32(Console.ReadLine());

              if (operators == 1)
            {
                Console.Write("Addition = ");
                Console.WriteLine(num1 + num2);
            }
            else if (operators == 2)
            {
                Console.Write("Subtraction = ");
                Console.WriteLine(num1 - num2);
            }
            else if (operators == 3)
            {
                Console.Write("Multiplication = ");
                Console.WriteLine(num1 * num2);
            }
            else if (operators == 4)
            {
                Console.Write("Division = ");
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Incrrect input please enter the correct input");
            } 
        }else
        {
            Console.Write("Sorry! you Enter wrong letters please try again!");

        }

    }
}