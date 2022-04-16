class Program{

    static void Main(string[] args){

        Console.WriteLine("\n");

        student mystudent = new student("Jim", "Business", 4.8);

        student mystudent2 = new student("Pam", "Art", 2.6);

        Console.WriteLine(mystudent.hasHonors());
        Console.WriteLine(mystudent2.hasHonors());

        /*
        Console.WriteLine(mystudent.name);
        Console.WriteLine(mystudent.major);
        Console.WriteLine(mystudent.gpa + "\n");

        Console.WriteLine(mystudent2.name);
        Console.WriteLine(mystudent2.major);
        Console.WriteLine(mystudent2.gpa);
        */

    }

}