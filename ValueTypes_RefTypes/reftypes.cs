using System;


//define a class which is a reference type in .NET
/*
public class Car
{
    string color = "red";
    string make = "honda";
    //int regNo = KDA5601;

}
*/

class Car
{
    //define car properties
    string Color = "red";
    string Make = "honda";
    int RegNo = 5601;

    //implement the class
    static void Main(string[] args)
    {
        // create a new instance
        Car derrekCar = new Car();
        Console.WriteLine($"{derrekCar.Color}, {derrekCar.Make}, {derrekCar.RegNo}");

        // Let the second instance be equal to the first.
        Car isaacCar = derrekCar;
        // Change the color of the second instance
        isaacCar.Color = "yellow";
        Console.WriteLine($"{isaacCar.Color}");

        //Check whether the 1st instance's car color changed
        Console.WriteLine($"Derrek's Car color also changes to: {derrekCar.Color}");

        // the property color changes because classes are reference types
        // therefore the variables hold references to the memory address not the value
    }
}