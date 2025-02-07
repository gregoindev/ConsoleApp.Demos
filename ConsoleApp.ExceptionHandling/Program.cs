// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



try
{
    Console.WriteLine("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old.");
}
catch (Exception )
{
    Console.WriteLine("You entered an invalid value. ");
    throw;
}
finally
{
    Console.WriteLine("Thank you for using this program... ");
}

 