﻿using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
            //Random random = new Random();
            //Console.WriteLine(random.Next(2)); //0-1
            //Console.WriteLine(random.NextDouble()); ==> 0.0 - 1.0
            //Console.WriteLine(random.Next(10,20)); ==> 10 - 19

            Console.WriteLine("Choose option\n 1.Check Attendance");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1: 
                    EmpPresentAbsent.EmployeeAttendanceCheck();
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }


        }
    }
}
