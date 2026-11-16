using System;

class ValueTypes
{
    //Value types hold a copy of the value in the specific instance

    static int addition(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int sum = addition(1, 2);
        Console.WriteLine($"{sum} is the answer");

        //the same "sum" variable can hold different values since only a copy of the data is stored
        sum = addition(a, b);
        Console.WriteLine($"{sum} is the second answer");
    }

}
