// declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

// prompt user input
Console.WriteLine("Please enter your name:");
name = Console.ReadLine();

Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

// process data
int workingYearsRemaining = retirementAge - age;


// output results
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
