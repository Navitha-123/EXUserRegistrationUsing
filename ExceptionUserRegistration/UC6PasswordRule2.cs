using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionUserRegistration
{
    public class UC6PasswordRule2
    {
        public static void ValidPasswordRule2()
        {
            try
            {
                Console.WriteLine("Enter password");
                Console.ReadLine();
                string password = Console.ReadLine();
                var hasLowerChar = new Regex("^(?=.*[a-z]).{8,}$");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMiniChar = new Regex(@".{8,}");
                var pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z].{8,}$)");
                if(pattern.IsMatch(password))
                {
                    Console.WriteLine("password is" +password);
                }
                else if(!hasMiniChar.IsMatch(password))
                {
                    throw (new Exception("password should have mini 8 characters"));
                }
                else if  (!hasLowerChar.IsMatch(password))
                {
                    throw (new Exception("password is not valid .... it must contain 8 characters"));

                    Console.WriteLine("password should be minimum 8 characters and atleast 1 lower char");
                }
                else if (!hasUpperChar.IsMatch(password))
                {
                    Console.WriteLine("password should have atleast one upper case letter");
                }
                else
                {
                    throw (new Exception("invalid password"));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
