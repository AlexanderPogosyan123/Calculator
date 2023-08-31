namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("enter num1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operation");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    Console.WriteLine($"{number1} + {number2} = {number1+number2}");
                    break;
                case '-':
                    Console.WriteLine($"{number1} - {number2} = {number1-number2}");
                    break;
                case '*':
                    Console.WriteLine($"{number1} * {number2} = {number1*number2}");
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("нельзя делить на нуль");
                        break;
                    }
                    Console.WriteLine($"{number1} / {number2} = {number1/number2}");
                    break;
                default:
                    break;
            }

            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");


            Console.WriteLine("Bye");
            Console.WriteLine("Bye");
            Console.WriteLine("Bye");
            Console.WriteLine("Bye");

            Console.WriteLine("!");
            Console.WriteLine("!");
            Console.WriteLine("!");
            
            
            
        }

    }
}
