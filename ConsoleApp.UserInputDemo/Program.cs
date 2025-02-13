using System.Globalization;

// declare variables
string? firstName = string.Empty;
string? lastName = string.Empty;
int age = 0;

DateOnly dob = new DateOnly();

int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool isWorking = false;

// prompt user input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your date of birth (mm/dd/yyyy): "); 
dob = DateOnly.ParseExact(Console.ReadLine(), "mm/dd/yyyy", 
    CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year;

Console.Write("Please enter your salary: ");
string salaryInput = Console.ReadLine();
salary = decimal.Parse(salaryInput);

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
isWorking = Convert.ToBoolean(Console.ReadLine());



// process data
int workingYearsRemaining = retirementAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);


// output results
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary: {salary.ToString("C")}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Currently working: {isWorking}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
Console.WriteLine($"Estimated retirement year: {estimatedRetirementDate.Year}");
