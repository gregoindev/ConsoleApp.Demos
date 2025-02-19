using ConsoleApp.Classes.Utils;

namespace ConsoleApp.Classes.Classes.PersonDemo
{
    internal class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("TCH");

        }
    }
}
