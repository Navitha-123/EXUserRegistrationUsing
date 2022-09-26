using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionUserRegistration
{
    public class UC5PasswordRule1
    {
        public static void ValidPasswordRule1()
        {
            try
            {
                Console.WriteLine("Enter password");
                 Console.ReadLine();
                string password = Console.ReadLine();
                var hasLowerChar = new Regex("^(?=.*[a-z]).{8,}$");
                if (!hasLowerChar.IsMatch(password))
                {
                    throw (new Exception("password is not valid .... it must contain 8 characters"));

                    Console.WriteLine("password should be minimum 8 characters");
                }
                else
                {
                    Console.WriteLine("password is " + password);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
