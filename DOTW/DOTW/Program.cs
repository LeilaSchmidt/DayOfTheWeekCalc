namespace DOTW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            bool rerun = true;
            //program runs until user types no or n
            while (rerun == true)
            {
                int year;
                int month;
                int day;
                string neg = ("-");

                //-------------YEAR------------//
                //asks for year
                Console.WriteLine("Hello, please enter a year: ");
                var yearr = Console.ReadLine();
                //checks if input is int
                while (!int.TryParse(yearr, out year))
                {
                    Console.WriteLine("This is not an integer, please try again: ");
                    yearr = Console.ReadLine();
                }
                //checks if input is negative
                while (yearr.Contains(neg))
                {
                    Console.WriteLine("The year must be after the death of Christ, please try again: ");
                    yearr = Console.ReadLine();
                }
                year = Convert.ToInt32(yearr);



                //----------MONTH---------------//
                //asks for month, checks if int entered
                Console.WriteLine("Please enter a month: ");
                var monthh = Console.ReadLine();

                //checks if input is int
                while (!int.TryParse(monthh, out month))
                {
                    Console.WriteLine("This is not an integer, please try again: ");
                    monthh = Console.ReadLine();
                }
                //checks if input is negative
                while (monthh.Contains(neg))
                {
                    Console.WriteLine("There are no negative months, please try again: ");
                    monthh = Console.ReadLine();
                }
                month = Convert.ToInt32(monthh);
                //month parameters
                while (month > 12 || month < 1)
                {
                    Console.WriteLine("That month is invalid. Please enter a valid month.");
                    month = Convert.ToInt32(Console.ReadLine());
                }


                //---------------DAY----------------//
                //asks for day, checks if int entered
                Console.WriteLine("Please enter a day: ");
                var dayy = Console.ReadLine();

                //checks if input is int
                while (!int.TryParse(dayy, out day))
                {
                    Console.WriteLine("This is not an integer, please try again: ");
                    dayy = Console.ReadLine();
                }
                //checks if input is negative
                while (dayy.Contains(neg))
                {
                    Console.WriteLine("There are no negative days, please try again: ");
                    dayy = Console.ReadLine();
                }
                day = Convert.ToInt32(dayy);
                //day parameters
                while (day > 31 || day < 1)
                {
                    Console.WriteLine("That day is invalid. Please enter a valid day.");
                    day = Convert.ToInt32(Console.ReadLine());
                }



                //leap year feb parameters
                while (year % 4 != 0 && month == 2 && day > 28)
                {
                    Console.WriteLine("This is not a valid day, please try again: ");
                    day = Convert.ToInt32(Console.ReadLine());
                }
                //monthly max day parameters
                if (month % 2 == 0 && day > 30)
                {
                    Console.WriteLine("This month does not have that many days, please try again: ");
                    day = Convert.ToInt32(Console.ReadLine());
                }
                else if (month % 2 == 1 && day > 31)
                {
                    Console.WriteLine("This month does not have that many days, please try again: ");
                    day = Convert.ToInt32(Console.ReadLine());
                }


                //---------------CALCULATIONS-------------------//

                //month chart determination
                if (month > 2 && month < 12)
                {
                    month -= 2;
                }
                else if (month == 1 || month == 2)
                {
                    month += 10;
                }
                //year: last two nums
                var end = (year % 100);
                //year: first two nums
                var cent = ((year - end) / 100) + 1;

                //adjusting date calculations
                if (month == 11 || month == 12)
                {
                    end -= 1;
                }
                if (year % 100 == 0)
                {
                    cent -= 1;
                }
                if (month == 13 || month == 14)
                {
                    year -= 1;
                }
                //weekday calculation
                int weekday = (((13 * (month + 1)) / 5) + (end / 4) + (cent / 4) + day + end - (2 * cent)) % 7 - 1;
                if (weekday == -1)
                {
                    weekday = 6;
                }
                Console.WriteLine("The weekday is: " + weekdays[weekday]);
                Console.WriteLine("Do you want to try another date? ");
                string yeaorno = Console.ReadLine();

                if (yeaorno == "no" || yeaorno == "n")
                {
                    rerun = false;
                }
            }
        }
    }
}
