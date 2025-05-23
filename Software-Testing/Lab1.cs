using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");         Console.Write("Enter first number: ");         double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter an operator (+, -, *, /): ");         char op = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter second number: ");         double num2 = Convert.ToDouble(Console.ReadLine());         double result = 0;
        // Apply breakpoint on this switch block
        switch (op)
        {             case '+':
                result = num1 + num2;                 break;
            case '-':
                result = num1 - num2;                 break;
            case '*':
                result = num1 * num2;                 break;
            case '/':
                if (num2 != 0)                     result = num1 / num2;
                else
                    Console.WriteLine("Cannot divide by zero!");                 break;
            default:
                Console.WriteLine("Invalid operator");                 break;         }
        Console.WriteLine($"Result: {result}");
    }
}
