using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionUserRegistration
{
    public class UC2LastName
    {
        public static void ValidLastName()
        {
            try
            {
                Console.WriteLine("Enter last name");
                string lastname = Console.ReadLine();
                string pattern = "^[A-Z]{1}[a-z]{2,}$";
                if (Regex.IsMatch(lastname, pattern))
                {
                    Console.WriteLine("FirstName:" + lastname);
                }
                else
                {
                    throw (new Exception("last name  should be last  letter capital and more than 2 cherecters and numeric"));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
