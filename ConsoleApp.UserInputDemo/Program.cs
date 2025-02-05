// declare variables

string? firstName = string.Empty;
string? lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool isWorking = false;

// prompt user input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: "); 
age = Convert.ToInt32(Console.ReadLine());


Console.Write("Please enter your salary: ");
string salaryInput = Console.ReadLine();
salary = decimal.Parse(salaryInput);

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
isWorking = Convert.ToBoolean(Console.ReadLine());



// process data
int workingYearsRemaining = retirementAge - age;


// output results
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Currently working: {isWorking}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
