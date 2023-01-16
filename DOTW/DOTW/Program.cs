namespace DOTW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine("Hello, please enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            
            if (month > 12 || month < 1)
            {
                Console.WriteLine("That month is invalid. Please enter a valid month.");
                return;
            }
            if (day > 31 || day < 1)
            {
                Console.WriteLine("That day is invalid. Please enter a valid day.");
                return;
            }
            if (month % 2 == 0 && day > 30)
            {
                Console.WriteLine("This month does not have that many days");
                return;
            } 
            else if (month % 2 == 1 && day > 31){
                Console.WriteLine("This month does not have that many days");
                return;
            }

            //month chart determination
            if (month > 2 && month < 12)
            {
                month -= 2;
                Console.WriteLine("The month is: " + month);
            } 
            else if (month == 1 || month == 2)
            {
                month += 10;
                Console.WriteLine("The month is: " + month);
            }

            //year: last two nums
            var end = (year%100);
            //year: first two nums
            var cent = ((year-end) / 100) + 1;

            if (month == 11 || month == 12)
            {
                end -= 1;
            }
            if (year%100 == 0)
            {
                cent -= 1;
            }
            if (month == 13 || month == 14)
            {
                year -= 1;
            }
            int weekday = ( ( (13 * (month + 1) ) / 5) + (end/4)+(cent/4)+day+end-(2*cent) )%7-1;
            if (weekday == -1)
            {
                weekday = 6;
            }
            Console.WriteLine("The weekday is: " + weekdays[weekday]);
            Console.ReadLine();
        }
    }
}