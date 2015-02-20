using System;

namespace _09.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday (DD/MM/YYYY:)");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = 0;
            if (birthday.Month > today.Month)
            {
                age = today.Year - birthday.Year - 1; 
            }
            else if (birthday.Day > today.Day)
            {
                age = today.Year - birthday.Year - 1; 
            }
            else
                age = today.Year - birthday.Year; 
            Console.WriteLine("Your age is: {0},in ten years it will be {1}",age, age + 10);
        }
    }
}
