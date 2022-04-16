class Building_an_Exponent_Method{
	
	static void Main(string[] args){
    
        Console.WriteLine("\n");
        Console.WriteLine(GetPow(5 ,2));
    }

    static int GetPow(int baseNum, int powNum){

        int result = 1;

        for (int i = 0; i < powNum; i++)
        {
            result = result * baseNum;
        }

        return result;
    }
}