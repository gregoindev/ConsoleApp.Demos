// See https://aka.ms/new-console-template for more information


DateTime date = new DateTime();


var dateOfBirth = new DateTime(1980, 12, 25);

Console.WriteLine($"My DOB is {dateOfBirth}");

Console.WriteLine($"The day was {dateOfBirth.DayOfWeek}");
Console.WriteLine($"The day of the year was the{dateOfBirth.DayOfYear}th");

var now  = DateTime.Now;
Console.WriteLine($"The time NOW is {now}");

Console.WriteLine("What is your DOB");
var userDOB = DateTime.Parse(Console.ReadLine());

Console.WriteLine(userDOB);