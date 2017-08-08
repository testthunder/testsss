/*
 *  C# Program to Demonstrate Properties of the Class
 */
using System;
class Student
{
    private string myName = "N/A";
    private int myAge = 0;
    public string Name
    {
        get
        {
            return myName;
        }
        set
        {
            myName = value;
        }
    }
    public int Age
    {
        get
        {
            return myAge;
        }
        set
        {
            myAge = value;
        }
    }
 
    public override string ToString()
    {
        return "Name = " + Name + ", Age = " + Age;
    }
 
    public static void Main()
    {
        Student Student = new Student();
        Console.WriteLine("Student details - {0}", Student);
        Student.Name = "BOB";
        Student.Age = 40;
        Console.WriteLine("Student details - {0}", Student);
        Student.Age += 25;
        Console.WriteLine("Student details - {0}", Student);
        Console.ReadLine();
    }
}