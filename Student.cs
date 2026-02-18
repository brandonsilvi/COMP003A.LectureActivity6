using System;

namespace COMP003A.LectureActivity6;

public class Student
{
    //Fields
    public string Name;
    public int Age;

    public Student(string name, int age) //constructor
    {
        Name = name;
        Age = age;
    }
    //instance method
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}