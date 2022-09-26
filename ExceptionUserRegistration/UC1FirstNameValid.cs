using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionUserRegistration
{
    public class UC1FirstName
    {
        public static void validFirstName()
        {
            try
            {
                Console.WriteLine("Enter first name");
                string firstName = Console.ReadLine();
                string pattern = "^[A-Z]{1}[a-z]{2,}$";
                if (Regex.IsMatch(firstName, pattern))
                {
                    Console.WriteLine("FirstName:" + firstName);
                }
                else
                {
                    throw (new Exception("Firstname should be first letter capital and more than 2 cherecters"));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
