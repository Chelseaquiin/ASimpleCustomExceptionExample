namespace IncorrectEmailFormatException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SimpleLogIn user = new SimpleLogIn("Amaka", 1234);

                user.DisplayInfo();
            }
            catch(IncorrectEmailFormatException e)
            {
                Console.WriteLine(e.Message);
            }
            }
    }
}