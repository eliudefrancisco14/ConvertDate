using System;

namespace ConvertDate
{

    public class Program
    {

        static void Main(string[] args)
        {
            Program pr = new Program();
            // pr.UsingConvert();
            pr.UsingParse();
            pr.WorkingWithDate();
            pr.SplitingDates();
            pr.UsingTimeSpan();
        }

        // Function that not executable
        public void UsingConvert()
        {
            DateTime mydate = Convert.ToDateTime(1000);
            Console.WriteLine();

            Console.Read();
        }

        // Converting Date to a String
        public void UsingParse()
        {
            Console.WriteLine("============UsingParse===============");
            string dateInput = "Jan 1, 2018";
            DateTime myDate = DateTime.Parse(dateInput);
            Console.WriteLine(myDate);
            // DISPLAYS THE DATE IN THE FORMATE 1/1/2018 12:00:00 AM
            Console.WriteLine("==========================="); // For Separate
        }

        // Getting Today’s date and time
        public void WorkingWithDate()
        {
            Console.WriteLine("============WorkingWithDate===============");
            Console.WriteLine(DateTime.Today); //Returns the current date
            Console.WriteLine(DateTime.UtcNow.Date); //Returns the current date
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine(DateTime.Today.ToString("dd-MM-yyyy"));
            DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            Console.WriteLine("==========================="); // For Separate
        }

        // Extracting Day, Month and Year from Date
        public void SplitingDates()
        {
            Console.WriteLine("============SplitingDates===============");
            String myDate = DateTime.Now.ToString(); //GET THE CURRENT DATE
            DateTime datevalue = (Convert.ToDateTime(myDate.ToString())); //CONVERTS THE myDate to a      DateTime TYPE

            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yr = datevalue.Year.ToString();

            Console.WriteLine("The day is: " + dy);
            Console.WriteLine("The month is: " + mn);
            Console.WriteLine("The year is: " + yr);
            Console.WriteLine("==========================="); // For Separate
        }

        // About TimeSpan Data Type

        /* According the the msdn documentation, a TimeSpan represents a time interval.
        Think of TimeSpan as a diffrence in time. When you subtract or add two dates, the result you have will be a TimeSpan. That is why it is called ‘a time interval’.

        Just like a Date contains day, month and year, a TimeSpan contains the following:

            Days
            Hours
            Milliseconds
            Minutes
            Second */

        public void UsingTimeSpan()
        {
            Console.WriteLine("============UsingTimeSpan===============");
            TimeSpan span = DateTime.Now - DateTime.Now.Date;
            int days = span.Days;
            int hours = span.Hours;
            int mins = span.Minutes;
            int seconds = span.Seconds;
            int milisecs = span.Milliseconds;

            Console.WriteLine("Days: " + days);
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Minutes: " + mins);
            Console.WriteLine("Seconds: " + seconds);
            Console.WriteLine("Milliseconds: " + milisecs);
            Console.WriteLine("==========================="); // For Separate
        }
    }
}