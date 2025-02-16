// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Arrays ****************************");


// Say how many grades / students to be entered
Console.Write("Indicate the number of grades to be entered: ");
int numOfGrades = Convert.ToInt32(Console.ReadLine());

int[] grades = new int[numOfGrades];
string[] students = new string[numOfGrades];



for (int i = 0; i < numOfGrades; i++)
{
    Console.Write("Enter Student's name: ");
    students[i] = Console.ReadLine();

    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The grades you have entered are: ");
for (int i = 0; i < numOfGrades; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}





//string[] studentNames = { };

//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.Write($"Write Student name: ");
//    studentNames[i] = Console.ReadLine();
//}

//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}



