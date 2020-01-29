﻿using System;

namespace UniversityClinicHospital
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.listOfEmployees.Add(new Doctor("George", 1234));
            employee.listOfEmployees.Add(new Nurse("Paul", 12345));
            /*employee.listOfEmployees[1] = new Employee("Paul", 12345, 40000, true);
            employee.listOfEmployees[2] = new Employee("Louis", 123456, 50000, false);
            employee.listOfEmployees[3] = new Employee("Bob", 1234567, 45000, false);*/

            Console.WriteLine("University Clinic Hospital");
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. View List of Employees");
            Console.WriteLine("2. Pay Employees");
            Console.WriteLine("3. Select Medical Employee Task");
            Console.WriteLine("4. Exit Interface");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    {
                        employee.PrintEmployeeList();
                        break;
                    }
            }
        }
    }
}
