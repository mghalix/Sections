using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ClassesOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(9, 12, 2021);
            employee.FirstName = "Mohanad";
            employee.LastName = "Ghali";
            employee.BirthDate.Day = 19;
            employee.BirthDate.Month = 11;
            employee.BirthDate.Year = 2002;
            
            employee.display();
        }
    }
    class Date
    {
        private int day;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Date()
        {

        }
        public void display()
        {
            Console.Write($"{Day:00}/{Month:00}/{Year:0000}");
        }
    }
    class Employee
    {
        private Date birthDate;

        public Date BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private Date hireDate;

        public Date HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Employee()
        {

        }

        public Employee(int day, int month, int year)
        {
            birthDate = new Date();
            hireDate = new Date();
            hireDate.Day = day;
            hireDate.Month = month;
            hireDate.Year = year;
        }

        public void display ()
        {
            Console.Write($"Name:{FirstName} {LastName} \nBirthDate:");
            BirthDate.display();
            Console.Write("\nHire Date:");
            HireDate.display();
        }
    }
}