using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Marks_Grade
{
    internal class Program
    {
        static void Main(string[] args)
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

            switch (average_marks)
            {
                case var s when (average_marks >= 80): //see the marks is greater than 80
                    Console.WriteLine("Excellent! Your Grade is A");
                    break; //if the mark less than 80, it will pass to next case

                case var s when (average_marks >= 70 && average_marks < 80):
                    Console.WriteLine("Good! Your Grade is B"); //check the marks is greater than 70 or less than 80
                    break; //if the mark is not between 70 to 80, it will pass to next case

                case var s when (average_marks >= 60 && average_marks < 70):
                    Console.WriteLine("Satisfactory. Your grade is C"); //check the marks is greater than 60 or less than 70
                    break; //if the mark is not between 60 to 70, it will pass to next case

                case var s when (average_marks >= 50 && average_marks < 60):
                    Console.WriteLine("Pass. Your Grade is D"); //check the marks is greater than 50 or less than 60
                    break; //if mark is not between 50 to 60, it will pass to next case

                case var s when (average_marks < 50):
                    Console.WriteLine("Fail. Your grade is F"); // check the mark is greater than 50
                    break; //if mark below 50, and fail

                default:
                    Console.WriteLine("Invaild Grade");
                    break;
            }

            Console.ReadKey(); // Display and stay on the screen
        }
    }
}
