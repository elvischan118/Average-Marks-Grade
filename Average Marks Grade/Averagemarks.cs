using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Marks_Grade
{
    internal class Averagemarks
    {
        public int marks { get; set; }
        public string ave_marks { get; set; }

        public int ave_count(int marks)
        {
            int marks_Maths, marks_Physics, marks_Chemistry, marks_ComputerScience;
            decimal average_marks;

            Console.WriteLine("Please enter your marks for Maths"); //Ask the user to enter their math marks
            marks_Maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your marks for Physics"); //Ask the user to enter their physics marks
            marks_Physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your marks for Chemistry"); //Ask the user to enter their chemistry marks
            marks_Chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your marks for Computer Science"); //Ask the user to enter their computer science marks
            marks_ComputerScience = Convert.ToInt32(Console.ReadLine());

            average_marks = (marks_Maths + marks_Physics + marks_Chemistry + marks_ComputerScience) / 4; //Calculate the average mark out of 4 subjects
            Console.WriteLine("Your average marks is " + average_marks); //Display the average marks of 4 subjects

            return marks;
        }

        public string ave_count_group(int marks)
        {
            if (marks >= 80)
            {
                ave_marks = "Excellent! Your grade is A";
            }
            else if (marks >= 70 && marks <= 80)
            {
                ave_marks = "Good! Your grade is B";
            }
            else if (marks >= 60 && marks <= 70)
            {
                ave_marks = "Satisfactory. Your grade is C";
            }
            else if (marks >= 50 && marks <= 60)
            {
                ave_marks = "Pass. Your grade is D";
            }
            else if (marks <= 50)
            {
                ave_marks = "Fail. Your grade is F";
            }

            return ave_marks;

        }
    }
}
