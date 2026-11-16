using System;

class NullableValueTypes
{
    static void Main(string[] args)
    {
        //define a nullable type (T?)
        int? sum;

        int? a, b;

        string? firstNum, secondNum;

        Console.WriteLine("Enter 1st Value:");
        //assign value 1
        firstNum = Console.ReadLine();

        Console.WriteLine("Enter 2nd Value:");
        //assign value 2
        secondNum = Console.ReadLine();

        // handle the exception of a null value
        try
        {
            a = Convert.ToInt32(firstNum);
            b = Convert.ToInt32(secondNum);
            sum = a + b;
            Console.WriteLine($"The sum is {sum}");
        }
        catch //(Exception e)
        {
            if (firstNum == "" || secondNum == "")
            {
                if (firstNum == "")
                {
                    Console.WriteLine("First number has no value");
                }
                else if (secondNum == "")
                {
                    Console.WriteLine("Second number has no value");
                }
            }
            else
            {
                Console.WriteLine("Both numbers were not input");
            }

        }
    }
}