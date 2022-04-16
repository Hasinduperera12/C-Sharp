class Area_Volume{

    static void Main(string[] args){

        Console.WriteLine("\n");

        RectCuboid myRectCuboid = new RectCuboid(18, 11, 6);
        SquaresCube mySquaresCube = new SquaresCube(8.5);
        Cylinder myCylinder = new Cylinder(4.2, 5.5);
        Spheres mySpheres = new Spheres(4.5);

        Console.WriteLine("Length of the Rectangle = " + myRectCuboid.length);
        Console.WriteLine("Breadth of the Rectangle = " + myRectCuboid.breadth);
        Console.WriteLine("Height of the Rectangle = " + myRectCuboid.height + "\n");
        Console.WriteLine("Area of the Rectangle = " + myRectCuboid.getAreRect());
        Console.WriteLine("Area of the cuboid = " + myRectCuboid.getAreCuboid());
        Console.WriteLine("Volume of the cuboid = " + myRectCuboid.getVolCuboid() + "\n");

        Console.WriteLine("----------------------------" + "\n");

        Console.WriteLine("Length of the Square = " + mySquaresCube.length + "\n");
        Console.WriteLine("Area of the Square = " + mySquaresCube.getAreSquare());
        Console.WriteLine("Area of the Cube = " + mySquaresCube.getAreCube());
        Console.WriteLine("Volume of the Cube = " + mySquaresCube.getVolCube() + "\n");

        Console.WriteLine("----------------------------" + "\n");

        Console.WriteLine("Radius of the Cylinder = " + myCylinder.radius);
        Console.WriteLine("Height of the Cylinder = " + myCylinder.height + "\n");
        Console.WriteLine("Area of the Cylinder = " + myCylinder.getAreaCylinder());
        Console.WriteLine("Volume of the Cylinder = " + myCylinder.getVolCylinder() + "\n");

        Console.WriteLine("-------------------------------------------" + "\n");

        Console.WriteLine("Radius of the Sphere = " + mySpheres.radius + "\n");
        Console.WriteLine("Area of the Sphere = " + mySpheres.getAreaSphere());
        Console.WriteLine("Volume of the Sphere = " + mySpheres.getVolSphere());

    }

}


class RectCuboid{
    public double length;
    public double breadth;
    public double height;

    public RectCuboid(double length,double breadth,double height)
    {
        this.length = length;
        this.breadth = breadth;
        this.height = height;
    }

    public double getAreRect()
    {
        return length * height;
    }

    public double getAreCuboid()
    {
        return (2 * length * breadth) + (2*length*height)+(2*breadth*height);
    }

    public double getVolCuboid()
    {
        return length*breadth*height;
    }
}

class SquaresCube{

    public double length;

    public SquaresCube(double length)
    {
        this.length = length;
    }

    public double getAreSquare()
    {
        return length * length;
    }

    public double getAreCube()
    {
        return 6 * length * length;
    }

    public double getVolCube()
    {
        return length * length * length;
    }
}

class Cylinder{

    public double radius;
    public double height;

    public Cylinder(double radius,double height)
    {
        this.radius = radius;
        this.height = height;
    }

    public double getAreaCylinder()
    {
        return (2* Math.PI * radius * radius) + (2 * Math.PI * radius * height);
    }

    public double getVolCylinder()
    {
        return Math.PI * radius * radius * height;
    }
}

class Spheres
{
    public double radius;
    

    public Spheres(double radius)
    {
        this.radius = radius;
    }

    public double getAreaSphere()
    {
        return 4 * Math.PI * radius * radius;
    }

    public double getVolSphere()
    {
        return (4 * Math.PI * radius * radius * radius);
    }
}