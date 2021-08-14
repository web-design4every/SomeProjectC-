using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RunningApplication
{
    class Validate
    {
        public int checkInput(int min, int max)
        {
            while (true)
            {
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice < min || choice > max)
                    {
                        throw new Exception();
                    }
                    return choice;
                }
                catch(Exception)
                {
                    Console.WriteLine("Please enter number in range [" + min + "," + max + "]: ");
                    Console.WriteLine("Enter again!");
                }
            }
        }
        public bool IsValidDateFormat(string date)
        {
                try
                {
                    DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    return true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid date format!");
                     return false;
                }
        }
    }
}
