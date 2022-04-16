class If_Statements_(con't)
{
	static void Main(string[] args)
    {
       Console.WriteLine(GetMax(20 , 10, 40));
    }

    static int GetMax(int num1 , int num2, int num3)
    {
        int result;

        if (num1 >= num2  && num1 >= num3)
        {
            result = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            result = num2;
        }
        else
        {
            result = num3;
        }

        /*
        if (num1 > num2){
            result = num1;
        }
        else
        {
            result = num2;
        }*/

        return result;
    }
}