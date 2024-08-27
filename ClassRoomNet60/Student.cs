namespace ClassRoomNet60;

public class Student
{
    public string Name { get; private set; }
    public int Birth_month { get; private set; }
    public int Birthday { get; private set; }


    public Student(string name, int birthMonth, int birthday)
    {
        Name = name;
        Birth_month = birthMonth;
        Birthday = birthday;
    }
}
