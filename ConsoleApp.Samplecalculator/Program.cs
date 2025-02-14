// See https://aka.ms/new-console-template for more information



// Global Vars
int numChoice = 0;
int num1, num2 = 0;



while (numChoice != -1)
{
    try
    {
        PrintMenu();
        numChoice = Convert.ToInt32(Console.ReadLine());

        if (numChoice == -1)
        {
            break;
        }

        // prompts
        Console.WriteLine("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());



        // switch statement
        int answer = 0;
        switch (numChoice)
        {
            case 1:
                answer = AddNumbers(num1, num2);
                break;
            case 2:
                answer = SubtractNumbers(num1, num2);
                break;
            case 3:
                answer = MultiplyNumbers(num1, num2);
                break;
            case 4:
                answer = DivideNumbers(num1, num2);
                break;
            case 5:
                answer = Fibonacci(num1, num2);
                break;
            default:
                throw new Exception("Invalid Menu Item selected...");
        }
        Console.WriteLine($"The result is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}

Console.WriteLine("End of program");



// Methods //
void PrintMenu()
{
    // Menu
    Console.Clear();
    Console.WriteLine("-------------- Welcome to the Sample Calculator --------------");
    Console.WriteLine("Please select an operation: (-1 to exit) :");
    Console.WriteLine($"1. Addition");
    Console.WriteLine($"2. Subtraction");
    Console.WriteLine($"3. Multiplication");
    Console.WriteLine($"4. Divison");
    Console.WriteLine($"5. Fibonacci Sequence");
}

int DivideNumbers(int num1, int num2)
{
    return num1 / num2;
}

int MultiplyNumbers(int num1, int num2)
{
    return num1 * num2;
}

int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

int Fibonacci(int num1, int num2)
{
    var answer = 0;

    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    };
    return answer;
}