namespace ExceptionUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("choose a option 1.valid \t 2. lastname");
            Console.WriteLine("UC1Valid first name");
            Console.WriteLine("UC2 Valid last name");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UC1FirstNameValid.validFirstName();
                    break;
                case 2:
                    UC2LastNameValid.ValidLastName();
                    break;
                default:
                    Console.WriteLine("enter wrong choice");
                    break;
            }
        }
    }
}