using System.Globalization;

// declare variables
char choice = char.MinValue;
string? firstName = string.Empty;
string? lastName = string.Empty;
int age = 0;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue;
bool isWorking = false;

List<Person> persons = new List<Person>();


while(choice != 'E') {


    // prompt user input
    Console.Write("Please enter your first name: ");
    firstName = Console.ReadLine();

    Console.Write("Please enter your last name: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your date of birth (mm/dd/yyyy): ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "mm/dd/yyyy",
        CultureInfo.InvariantCulture);

    Console.Write("Please enter your salary: ");
    string salaryInput = Console.ReadLine();
    salary = decimal.Parse(salaryInput);

    Console.Write("Please enter your gender (M or F): ");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you working (true or false): ");
    isWorking = Convert.ToBoolean(Console.ReadLine());

    Person person = new(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        Gender = gender,
        IsWorking = isWorking,
        Salary = salary
    };



    persons.Add(person);

    Console.WriteLine("C - Continue | E - Exit");
    choice = Convert.ToChar(Console.ReadLine());
}

foreach (var person in persons)
{
    // output results
    Console.WriteLine($"Full name: {person.ToString()}");
    Console.WriteLine($"Age: {person.GetAge()}");
    Console.WriteLine($"Salary: {person.Salary.ToString("C")}");
    Console.WriteLine($"Gender: {person.Gender}");
    Console.WriteLine($"Currently working: {person.IsWorking}");
    Console.WriteLine($"Working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
    Console.WriteLine($"Estimated retirement year: {person.GetEstimatedRetirementDate()}");
}



