using System;
using System.Collections;

/// <summary>
/// OOP Main Concepts are:
/// 1- Encapsulation
/// 2- Polymorphism
/// 3- Inheritance
/// 4- Abstraction >> 
///         Abstraction Class and methods                                   Interfaces 
///         1- inorder to make an abstraction method,                       1- In the interface : No attributies.
///         the class has to be astracted too by using the                  2- Just heading methods that need to be implemented.
///         keyword abstract
///         2- You are able to have attributies too. 
///         3- abstract is just to make the heading of the function, 
///         without the actual implementation of it.
///         
/// </summary>

namespace Employees
{
    public class Person
    {
        public int Id { get; set; }
    }

    public class Employee : Person  // Inheritance 
    {
        //Attributes 

        private string Name { get; set; }
        private int Age { get; set; }
        private double Salary ;
        private string Address { get; set; }
        private department Department { get; set; }

        // Methods 

        //Constructors 

        public Employee(string name_Inputed, int age_Inputed, double salary_Inputed, string Address_Inputed, department departmentInputed,int idInputed)
        {
            this.Id = idInputed;
            this.Name = name_Inputed;
            this.Age = age_Inputed;
            this.Salary = salary_Inputed;
            this.Address = Address_Inputed;
            this.Department = departmentInputed;
        }

        //Encapsulation
        public void RaiseSalary(double raiseAmount)
        {
            this.Salary = this.Salary + raiseAmount;
        }

        public double getSalary()
        {
            return this.Salary;
        }

    }

    
    public enum department // Enum is a special class that holds a constant variables 
    {
        Work,
        Management

    }

    /// <summary>
    /// Abstraction >> interfaces
    /// </summary>
    public interface IManagerActions
    {
        public void Raise(double rasing_salary);
    }

    public class ManagerActions : IManagerActions
    {
        protected readonly Employee _employee;
        public ManagerActions(Employee employee)
        {
            _employee = employee;
        }
        public void Raise(double rasing_salary)
        {
            _employee.RaiseSalary(rasing_salary);
        }
    }

    /// <summary>
    /// Abstraction Class
    /// </summary>
    public abstract class Manager :Person
    {
        private string Rate;
        public abstract void RatingEmployee();
    }
}

//Polymorphoism

namespace ContactPhoneNumList
{
    public class PhoneContactList
    {
        private int number;
        private string name;
        private string email;

        public void add(int _number, string _name, string _email)
        {
            this.name = _name;
            this.email = _email;
            this.number = _number;
        }
        public void add(int _number)
        {
            this.number = _number;
        }

        public void add(string _name, string _email)
        {
            this.name = _name;
            this.email = _email;
        }
        public void add(int _number, string _name)
        {
            this.name = _name;
            this.number = _number;
        }

        public void Display()
        {
            Console.WriteLine($"This Name: {name}, Email:{email}, Phone: {number}");
        }


    }
}


public class MainClass
{
    public static void Main(string[] args)
    {
        //Employees.Employee emp1 = new EmployeeClass.Employee("mohamed", 20, 2000, "20-14 Cst st", EmployeeClass.department.Work,1);
        //Employees.Employee emp2 = new EmployeeClass.Employee("Ahmed", 22, 2200, "22-15 Ct st", EmployeeClass.department.Management,2);

        //emp1.RaiseSalary(1000);

        //Console.WriteLine(emp1.getSalary());
        //Console.WriteLine(emp2.getSalary());


        //Polymorphoism
        ContactPhoneNumList.PhoneContactList contact1 = new ContactPhoneNumList.PhoneContactList();

        contact1.add(123333, "ahsadasd", "asdh@gma");
        contact1.Display();

        contact1.add(10002311, "hesham");
        contact1.Display();




    }

}