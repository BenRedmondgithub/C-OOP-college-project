using System;

class Student 

{

    public int studID, year_admission;

    public string Name, Programme;


    public void showStudentData()

    {

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Student ID: " +studID);
        Console.WriteLine("Student name: " +Name);
        Console.WriteLine("Programme: " +Programme);
        Console.WriteLine("Year of Admission: " +year_admission);
        Console.WriteLine("--------------------------------------------");

    }

}

class program {

static void Main(string [] args) 

{

Student s1 = new Student();

s1.studID = 1234;
s1.year_admission = 2025;
s1.Name = "John Fisher";
s1.Programme ="H.Dip. Science in Computing";

s1.showStudentData();

} 

}