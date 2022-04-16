class Return_Statement
{
	static void Main(string[] args)
    {
       int cubeNumber = cube(6);
       Console.WriteLine(cubeNumber);
        //Console.WriteLine(cube(5));

    }

    static int cube(int num)
    {
        int result = num * num * num;
        return result;
    }

}