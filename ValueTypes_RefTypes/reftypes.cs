using System;


//define a class which is a reference type in .NET

class ReferenceTypes
{
    //implement the class
    static void Main(string[] args)
    {
        // create a new instance
        Car derrekCar = new Car();
        Console.WriteLine($"{derrekCar.color}, {derrekCar.make}, {derrekCar.regNo}");

        // Let the second instance be equal to the first.
        Car isaacCar = derrekCar;
        // Change the color of the second instance
        isaacCar.color = "yellow";
        Console.WriteLine($"{isaacCar.color}");

        //Check whether the 1st instance's car color changed
        Console.WriteLine($"Derrek's Car color also changes to: {derrekCar.color}");

        // the property color changes because classes are reference types
        // therefore the variables hold references to the memory address not the value
    }
}

class Car
{
    // must  make the variables in my Car class publicly available for use
    public string color = "red";
    public string make = "honda";
    public int regNo = 5601;

}