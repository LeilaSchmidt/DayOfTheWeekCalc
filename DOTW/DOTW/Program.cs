namespace DOTW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            bool rerun = true;
            //program runs until user types no or n
            while (rerun == true)
            {
                int year = 0;
                int month = 0;
                int day = 0;
                string neg = ("-");
                bool go = false;

                //-------------YEAR------------//
                //while go false, loop
                 while (go == false)
                {
                    Console.WriteLine("Please enter a valid year: ");
                    string yearr = Console.ReadLine();
                    // checks: if int, negative (both cases)
                    if(!int.TryParse(yearr, out year) || yearr.Contains(neg) || year < 0)
                    {
                        Console.WriteLine("This is not a valid year. ");
                        continue;
                    }
                    go = true;
                }

                //-------------MONTH------------//
                go = false;
                //while go false, loop
                while (go == false)
                {
                    Console.WriteLine("Please enter a valid month: ");
                    string monthh = Console.ReadLine();
                    //checks: if int, if neg, if > 12, if < 1
                    if (!int.TryParse(monthh, out month) || monthh.Contains(neg) || month < 0 || month > 12 || month < 1)
                    {
                        Console.WriteLine("That was not a valid month. ");
                        continue;
                    }
                    go = true;
                }
                
                //-------------DAY------------//
                go = false;
                //while go false, loop
                while (go == false)
                {
                    Console.WriteLine("Please enter a valid day: ");
                    string dayy = Console.ReadLine();
                    //checks if: int, neg, > 31, < 1, no leapyr & feb & >28, even months > 30, odd months > 31
                    if (!int.TryParse(dayy, out day) || dayy.Contains(neg) || day < 0 || day > 31 || day < 1 || (year % 4 != 0 && month == 2 && day > 28) || (month % 2 == 0 && day > 30) || (month % 2 == 1 && day > 31))
                    {
                        Console.WriteLine("That was not a valid day. ");
                        continue;
                    }
                    go = true;
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
                rerun = false;
            }
        }
    }
}
