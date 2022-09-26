namespace ExceptionUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("choose a option 1.valid \t 2. lastname \t 3.Email");
            Console.WriteLine("UC1Valid first name");
            Console.WriteLine("UC2 Valid last name");
            Console.WriteLine("UC3 Email");

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
                default:
                    Console.WriteLine("enter wrong choice");
                    break;
            }
        }
    }
}