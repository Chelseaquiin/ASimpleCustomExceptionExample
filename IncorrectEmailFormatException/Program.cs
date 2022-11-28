namespace IncorrectEmailFormatException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SimpleLogIn user = new SimpleLogIn("Amaka",  1234);

                user.ValidateEmail();
            }
            catch(IncorrectEmailFormatException e)
            {
                Console.WriteLine(e.CauseOfError);
            }
            }
    }
}