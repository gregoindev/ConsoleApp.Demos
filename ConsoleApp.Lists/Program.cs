// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// **************** LISTS

List<int> grades = new List<int>();
List<string> students = new List<string>();
int grade = 0;
string name;
int gradeCount = 0;
int @continue;
//var grades = new List<int>();
//List<int> grades = new();

//grades.Add(45);
//Console.WriteLine(grades);

do
{
    gradeCount+= 1;
    Console.Write("Enter Student's name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("Enter grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    grades.Add(grade);

    Console.Write("Do you wish to continue? (1 = yes | 2 = no): ");
    @continue = Convert.ToInt32(Console.ReadLine());

  
} while (@continue == 1);

//Console.WriteLine("Printing grades using for loop");
//for (int i = 0; i < grades.Count; i++) 
//{
//    Console.WriteLine(grades[i]);
//}
Console.WriteLine("The grades you have entered are:");
for (int i = 0; i < gradeCount; i++) 
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

//// foreach loop
//Console.WriteLine("Printing grades using foreach");
//foreach (int g in grades) 
//{
//    Console.WriteLine(g);
//}