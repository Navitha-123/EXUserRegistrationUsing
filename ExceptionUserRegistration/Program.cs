namespace ExceptionUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("choose a option 1.valid \t 2. lastname \t 3.Email \t 4.mobilenumber \t 5.rule1 \t 6.rule2 \t 7.rule \t 9.Emailsample");
            Console.WriteLine("UC1Valid first name");
            Console.WriteLine("UC2 Valid last name");
            Console.WriteLine("UC3 Email");
            Console.WriteLine("UC4 mobile number");
            Console.WriteLine("UC5 rule1 password");
            Console.WriteLine("UC6 rule2 password");
            Console.WriteLine("UC7 Rule3");
            Console.WriteLine("UC9 valid samples");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UC1FirstNameValid.validFirstName();
                    break;
                case 2:
                    UC2LastNameValid.ValidLastName();
                    break;
                case 3:
                    UC3Email.ValidEmail();
                    break;
                case 4:
                    UC4MobileNumber.ValidMobileNumber();
                    break;
                case 5:
                    UC5PasswordRule1.ValidPasswordRule1();
                    break;
                case 6:
                    UC6PasswordRule2.ValidPasswordRule2();
                    break;
                case 7:
                    UC7PasswordRule3.ValidPasswordRule3();
                    break;
                case 9:
                    UC9EmailSamples.ValidSampleEmail();
                    break;
                default:
                    Console.WriteLine("enter wrong choice");
                    break;
            }
        }
    }
}