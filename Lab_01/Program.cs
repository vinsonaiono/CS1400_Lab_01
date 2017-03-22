// File Prologue
// Name: Vinson Aiono
// Project: Lab_01
// Date: 01/13/2016

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //These strings store my student information
            string name = "Vinson Aiono";
            string course = "CS 1400";
            string section = "Section 001";
            string project = "Lab_01";
            //This code will display the strings on the console.
            WriteLine("Name: {0}", name);
            WriteLine("Course: {0}", course);
            WriteLine("Section: {0}", section);
            WriteLine("Project: {0}", project);

            WriteLine("Press any key to continue");
            ReadKey(true);

            Console.ReadLine();
        }//End Main
    }//End Class
}//End Namespace
