// See https://aka.ms/new-console-template for more information



// Global Vars
int numChoice = 0;
int num1, num2 = 0;



while (numChoice != -1)
{
    try
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
                answer = num1 + num2;
                break;
            case 2:
                answer = num1 - num2;
                break;
            case 3:
                answer = num1 * num2;
                break;
            case 4:
                answer = num1 / num2;
                break;
            case 5:
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
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