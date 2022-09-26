using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionUserRegistration
{
    public class UC9EmailSamples
    {
        public static void ValidSampleEmail()
        {
            try
            {
                Console.WriteLine("Enter email");
                string email = Console.ReadLine();
                string pattern = @"^([a-z]+)(\.a-z0-9_\+\+)?@([a-z]+)\.([a-z]{2,4})([\.a-z]{2})?$";
                if (Regex.IsMatch(email, pattern))
                {
                    Console.WriteLine("email is :" + email);
                }
                else
                {
                    throw (new Exception(" email  should be last  letter  and more than 2 cherecters and numeric not valid"));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
