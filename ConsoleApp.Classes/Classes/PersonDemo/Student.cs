using ConsoleApp.Classes.Utils;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp.Classes.Classes.PersonDemo;

internal class Student : Person
{

    public void GenerateStudentIdNumber()
    {
        _idNumber = PersonHelper.GenerateIdNumber("STU");

    }
}
