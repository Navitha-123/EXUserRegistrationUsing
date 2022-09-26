using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionUserRegistration
{
    public class UC4MobileNumber
    {
        public static void ValidMobileNumber()
        {
            try
            {
                Console.WriteLine("Enter mobile number");
                string mobilenumber = Console.ReadLine();
                string pattern = "^[+][91]{3}[..][6-9]{2}[0-9]{9}$";
                if (Regex.IsMatch(mobilenumber, pattern))
                {
                    Console.WriteLine("mobilenumber is :" + mobilenumber);
                }
                else
                {
                    throw (new Exception(" mobile number is not valid  ... it must contain 10 nnumbers"));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
