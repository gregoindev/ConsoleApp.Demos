// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Methods!");


// void methods //
void PrintName()
{
    Console.WriteLine(" Full Name");
}




// value returning //
int GetFiveYearsAgo() 
{
    int year = DateTime.Now.AddYears(-5).Year;

    return year; 
}

// with parameters //
void PrintNameWithParams(string name) 
{
    Console.WriteLine($"Your name is  {name}");
}

int GetYearDifferenceWithParams(int year) 
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}


int GetFutureOrPastYear(int numberOfYears = 0) 
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

// nullable parameters //
void PrintNameNullableParam(string? name, int? count)
{
    //if (string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";
    //}
    //if (!count.HasValue)
    //{
    //    count = 1;
    //}
    name ??= "Default Name";
    count ??= 1;

    for (int i = 0; i < count.Value; i++)
    {
        Console.WriteLine(name);
    }
}

// function calls //
//PrintName();    
//int fiveYearsAgo = GetFiveYearsAgo();
//Console.WriteLine($"Five years ago was : {fiveYearsAgo}");

//Console.WriteLine("Enter your name");
//string name1 = Console.ReadLine();
//PrintNameWithParams(name1);

//Console.WriteLine("Enter a year");
//int pastYear = Convert.ToInt32(Console.ReadLine());
//int yearsAgo = GetYearDifferenceWithParams(pastYear);
//Console.WriteLine($"This was {yearsAgo} years ago. ");

//Console.WriteLine("Enter a number of year in the future or past: ");
//int numberOfYears = Convert.ToInt32(Console.ReadLine());

//var pastYear1 = GetFutureOrPastYear();
//Console.WriteLine($"The year is: {pastYear1}");

//var pastYear2 = GetFutureOrPastYear(numberOfYears);
//Console.WriteLine($"The year is : {pastYear2}");


PrintNameNullableParam("Gwego", 3);