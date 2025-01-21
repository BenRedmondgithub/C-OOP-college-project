using System;

class Employee 
{

    public string empID, empName, department, depNO;

    public double salary;


    public void showEmployeeData()
    {

        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Emp ID: " +empID);
        Console.WriteLine("Employee name: {0}" ,empName);
        Console.WriteLine("Department: {0}" ,department);
        Console.WriteLine("Dept No: {0}" ,depNO);
        Console.WriteLine("Salary: {0}" ,salary);
        Console.WriteLine("-----------------------------------------------------------");

    }
}

class Program 
{
static void Main(string [] agrs)

{

    Employee e1 = new Employee();

    e1.empID = "H32651";
    e1.empName = "James Smith";
    e1.department ="IT";
    e1.depNO = "02";
    e1.salary = 25000;

    e1.showEmployeeData();

}

}