// declare variables
using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

// prompt user input
Console.WriteLine("Please enter your first name:");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
lastName = Console.ReadLine();


Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

// process data
int workingYearsRemaining = retirementAge - age;


// output results
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
