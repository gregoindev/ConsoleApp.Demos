// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Console.WriteLine("Please enter student's grade:");
//int grade = Convert.ToInt32(Console.ReadLine());

// pass or fail //
//if (grade > 50) {
//    Console.WriteLine("Student passed");
//}
//else
//{
//    Console.WriteLine("Student have failed");
//    Console.WriteLine("Please reach out to your course instructor");
//}



// if else if //
//if (grade < 0 || grade > 100)
//{
//    Console.WriteLine("Please enter a number between 0 and 100");
//}
//else if(grade <= 50)
//{
//    Console.WriteLine("Student failed - F");

//}
//else if (grade >= 50 && grade <= 64)
//{
//    Console.WriteLine("C-");
//}

//else if(grade >= 65 && grade <= 74 )
//{
//    Console.WriteLine("C");
//} 
//else if (grade >= 75 && grade <= 84)
//{
//    Console.WriteLine("B");
//} 
//else if(grade >= 85 && grade <= 100)
//{
//    Console.WriteLine("Good job -> A");
//}



//// end 
//Console.WriteLine("Thank you for using our program");



// SWITCH CASES: //

Console.WriteLine("Type today's date: ");

int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek) 
{
    case 1:
        Console.WriteLine("Sunday");
        break;

    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break; 
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Type a number betweek 1-7");
        break;
}