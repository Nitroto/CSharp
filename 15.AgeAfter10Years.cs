using System;

class AgeAfter10Years
{
    static void AgeCalculator(DateTime birth)
    {
        DateTime today = DateTime.Today;
        TimeSpan span = today - birth;
        DateTime age = DateTime.MinValue + span;
        int years = age.Year - 1;
        int months = age.Month - 1;
        int days = age.Day - 1;
        Console.WriteLine(years.ToString() + " Years, " + months.ToString() + " Months and " + days.ToString() + " Days");
        int yearsAfter = years + 10;
        Console.WriteLine("After 10 years, your age will be: " + yearsAfter.ToString() + " Years, " + months.ToString() + " Months and " + days.ToString() + " Days");
    }
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter your birth date (DD/MM/YYYY): ");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            if (today < birth)
            {
                Console.WriteLine("The entered date is in the future! Welcome Dr. Brown !!!");
                Console.WriteLine("If you are not Dr. Brown please enter the correct date.");
            }
            else
            {
                if (today.Year >= birth.Year + 4)
                {
                    AgeCalculator(birth);
                    break;
                }
                else
                {
                    Console.WriteLine("You learn to write and read at that age. Your parents probably are proud of you.");
                    AgeCalculator(birth);
                    break;
                }
            }
        }
        Console.ReadLine();
    }
}
