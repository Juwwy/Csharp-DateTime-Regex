using System;


namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while(true)
            {
            Console.WriteLine("Enter your Date of Birth: ");
            Console.Write("Year: ");
            int year =  int.Parse(Console.ReadLine());

            Console.Write("Month: ");
            int month =  int.Parse(Console.ReadLine());

            Console.Write("Day: ");
            int day =  int.Parse(Console.ReadLine());

            DateTime getDOB = new DateTime(year, month, day);

            DateTime CurrentTime = DateTime.Now;
            int Age = new DateTime(CurrentTime.Subtract(getDOB).Ticks).Year - 1;
            //Console.Write($"{Age}");

            if(getDOB.Month == CurrentTime.Month && getDOB.Day == CurrentTime.Day)
            {
                Console.WriteLine($"Your Age is: {Age}\nFantastic it is your Birthday\nHappy Birthday!!!");
                break;
            }else if(getDOB.Year > CurrentTime.Year)
            {
                Console.WriteLine("Please input Correct Year. Your Year input has exceeded the current Year");
                continue;
            }else{
                Console.Write($"Your current Age is: {Age} Years");
                break;
            }
            }
            }
            catch (Exception e)
            {
                
                Console.Write($"{e.Message}");
            }


        }

    }
}
