// // namespace DateTimeTest
// // {
// //     public class DateTimes
// //     {
// //     //     public int Year { get; set; }
// //     //     public int Month { get; set; }
// //     //     public int Day { get; set; }
        

// //     //     public DateTimes(int year, int month, int day)
// //     //     {
// //     //         Year = year;
// //     //         Month = month;
// //     //         Day = day;
            
// //     //     }

// //     //     public override string ToString()
// //     //     {
// //     //         return $"{Day}-{Month}-{Year}";
// //     //     }
// //     // }
// // }


// //jj
// try
//             {
//                 while(true)
//             {
//             Console.WriteLine("Enter your Date of Birth: ");
//             Console.Write("Year: ");
//             int year =  int.Parse(Console.ReadLine());

//             Console.Write("Month: ");
//             int month =  int.Parse(Console.ReadLine());

//             Console.Write("Day: ");
//             int day =  int.Parse(Console.ReadLine());

//             DateTime getDOB = new DateTime(year, month, day);

//             DateTime CurrentTime = DateTime.Now;
//             TimeSpan diff = CurrentTime.Subtract(getDOB);
//             //int newAge = new DateTime(CurrentTime.Subtract(getDOB).Ticks).Year - 1;
//             DateTime Age = DateTime.MinValue.AddDays(diff.Days);
//             //Console.Write($"{Age}");

//             if(getDOB.Month == CurrentTime.Month && getDOB.Day == CurrentTime.Day)
//             {
//                 Console.WriteLine($"Your Age is: {Age.Year-1}\nFantastic it is your Birthday\nHappy Birthday!!!");
//                 break;
//             }else if((Age.Year - 1) >= 1 && (Age.Year -1) <= 135)
//             {
//                 Console.Write($"Your current Age is: {Age.Year-1} Years");
//                 break;
                
                
//             }else if (Age.Year < CurrentTime.Year){
//                 Console.WriteLine("Please input Correct Year. Your Year input has exceeded the current Year");
//                 continue;
//             }else{
//                 Console.Write("Enter a valid input!");
//             }
//             }
//             }
//             catch (Exception e)
//             {
                
//                 Console.Write($"{e.Message}");
//             }