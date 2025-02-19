// See https://aka.ms/new-console-template for more information
using ConsoleApp.Classes;
using ConsoleApp.Classes.Classes.PersonDemo;
using ConsoleApp.Classes.Classes.ShapeDemo;

Console.WriteLine("********************************* Classes and Objects ");

// object of type person
Person person; // will be null by default


Person baby = new Person();
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateofBirth = new DateOnly(2023, 10, 29);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine(taxNumber);

var person1 = new Person("Developer", "One", new DateOnly(2000, 10, 31));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Devie", "Two", "677824411");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();

var teacher = new Teacher();
teacher.FirstName = "Erlinda";
teacher.LastName = "Angeles";
teacher.DateofBirth = new DateOnly(1969, 01, 21);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teacherTaxNumber);
teacher.GenerateTeacherIdNumber();

var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine(teacherIdNumber);

Student student = new();
student.FirstName = "Gwego";
student.LastName = "Bwuno";
student.DateofBirth = new DateOnly(2011, 10, 22);

student.PrintFullName();   
student.PrintInitials();
student.GenerateTaxNumber();
var studentTaxNumber = student.GetTaxNumber();
Console.WriteLine(studentTaxNumber);
student.GenerateStudentIdNumber();

var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);


Rectangle rectangle = new(10, 20);
var rectangleArea = rectangle.Area();
Console.WriteLine($"Rectangle Area: {rectangleArea}");

Square square = new(50);
var squareArea = square.Area();
Console.WriteLine($"Square Area: {squareArea}");

Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidVolume = cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();
Console.WriteLine($"Cuboid area : {cuboidArea}");
Console.WriteLine($"Cuboid volume : {cuboidVolume}");
Console.WriteLine($"Cuboid perimeter : {cuboidPerimeter}");


Sphere sphere = new(7);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"{nameof(Sphere)} : {sphereVolume}");
Console.WriteLine($"{nameof(Sphere)} : {sphereCircumference}");
