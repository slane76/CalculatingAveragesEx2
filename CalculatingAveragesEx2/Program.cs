using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAveragesExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradeOne, gradeTwo, gradeThree, gradeFour, gradeFive, gradeSix, gradeSeven, gradeEight, gradeNine, gradeTen;
            double sumOfGrades;
            double gradePointAverage;


            Console.WriteLine($"Please enter your first Grade. ");
            gradeOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Second Grade. ");
            gradeTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Third Grade. ");
            gradeThree = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Fourth Grade. ");
            gradeFour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Fifth Grade. ");
            gradeFive = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Sixth Grade. ");
            gradeSix = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Seventh Grade. ");
            gradeSeven = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Eighth Grade. ");
            gradeEight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Ninth Grade. ");
            gradeNine = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Tenth Grade. ");
            gradeTen = Convert.ToDouble(Console.ReadLine());

            sumOfGrades = gradeOne + gradeTwo + gradeThree + gradeFour + gradeFive + gradeSix + gradeSeven + gradeEight + gradeNine + gradeTen;

            gradePointAverage = sumOfGrades / 10;

            Console.WriteLine($"The Sum of your numbers is : {sumOfGrades} out of 1000 possible points. ");

            Console.WriteLine($"Your Grade Point Average (GPA) is : {gradePointAverage}. ");

            if (gradePointAverage >= 90)
            {
                Console.WriteLine("Your Final grade is an A.");
            }
            else if (gradePointAverage >= 80)
            {
                Console.WriteLine("Your Final grade is an B.");
            }
            else if (gradePointAverage >= 70)
            {
                Console.WriteLine("Your Final grade is an C.");
            }
            else if (gradePointAverage >= 60)
            {
                Console.WriteLine("Your Final grade is an D.");
            }
            else if (gradePointAverage <= 59)
            {
                Console.WriteLine("You have failed this course.");
            }


        }
    }
}
