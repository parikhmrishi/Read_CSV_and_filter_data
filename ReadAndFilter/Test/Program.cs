using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using read_csv;

namespace Filter_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Csv helper = new Csv();
            // helper.read();
            try
            {
                Console.WriteLine("Select an option");
                Console.WriteLine("1. Filter on location");
                Console.WriteLine("2. Filter on Designation");
                Console.WriteLine("3. Filter on Date");

                int option = 0;
                option = int.Parse(Console.ReadLine());
                select_option(option);

                void select_option(int op)
                {
                    switch (op)
                    {
                        case 1:
                            String location = " ";
                            Console.WriteLine("Enter the location");
                            location = Console.ReadLine();

                            if (Regex.IsMatch(location, @"^[a-zA-Z]+$"))
                            {
                                helper.Filter_location(location);
                            }
                            else
                            {
                                Console.WriteLine("Enter valid location");
                                select_option(1);
                            }
                            break;

                        case 2:
                            String designation = " ";
                            Console.WriteLine("Enter the designation");
                            designation = Console.ReadLine();

                            if (Regex.IsMatch(designation, @"^[a-zA-Z]+$"))
                            {
                                helper.Filter_designation(designation);
                            }
                            else
                            {
                                Console.WriteLine("Enter valid designation");
                                select_option(2);
                            }
                            break;



                        case 3:
                            Console.WriteLine("Enter a date (mm/dd/yyyy): ");
                            DateTime userDateTime;
                            if (DateTime.TryParseExact(Console.ReadLine(),"MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out userDateTime))
                            {
                                String date = userDateTime.ToShortDateString().ToString().Replace('-', '/');
                                helper.Filter_date(date);
                            }
                            else
                            {
                                Console.WriteLine("You have entered an incorrect value.");
                                select_option(3);
                            }
                            break;

                        default:
                            Console.WriteLine("Select a valid option");
                            option = int.Parse(Console.ReadLine());
                            select_option(option);
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                Console.ReadKey();

            }
        }

       
    }
}
