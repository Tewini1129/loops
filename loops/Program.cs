namespace Loops
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Greet("William");
            /*Miniräknare
            string? userExit = "";
            while (userExit!.ToLower() != "exit")
            {
                Console.WriteLine("Enter first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("What do you want to do? (+, -, *, / )");
                string? op = Console.ReadLine();
                



                switch (op)
                {
                    case "+":
                        Add(a, b);

                        break;
                    case "-":
                        Sub(a, b);
                        break;
                    case "*":
                        Mult(a, b);
                        break;
                    case "/":
                        Div(a, b);
                        break;
                    default:
                        Console.WriteLine("The operator you enter does is not a option");
                        break;
                }
                Console.WriteLine("\nTo exit enter (Exit)");
                Console.WriteLine("or press (Enter) to calculate new numbers");
                userExit = Console.ReadLine();


                
                /* if else/if else
                if (op == "+")
                {
                   
                }
                else if (op == "-")
                {
                   
                }
                else if(op == "*")
                {
                   
                }
                else if (op == "/")
                {
                    
                }
                else
                {
                    Console.WriteLine("The operator you entered was not a option.");
                }
                */
        }
        static void Greet(string name)
        {
            Console.WriteLine("Enter your name");
            Console.WriteLine($"Welcome {name}");
        }
            static void Add(int a, int b)
            {
               int sum = a + b;
                Console.WriteLine($"The sum is: {sum}");
            }


            static void Sub(int a, int b)
            {
                int sum = a - b;
                Console.WriteLine($"The sum is: {sum}");
            }


            static void Mult(int a, int b)
            {
                int sum = a * b;
                Console.WriteLine($"The sum is: {sum}");
            }


            static void Div(int a, int b)
            {
                int sum = a / b;
                Console.WriteLine($"The sum is: {sum}");
            }

        }
        
    }
    
}
