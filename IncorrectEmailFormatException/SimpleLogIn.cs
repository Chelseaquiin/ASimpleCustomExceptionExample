using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IncorrectEmailFormatException
{
    internal class SimpleLogIn
    {
        public string Username { get; set; }
        public int ID { get; set; }

        public SimpleLogIn(string username, int id)
        {
            Username = username;
            ID = id;
        }

        public void ValidateEmail()    
        {
            Console.WriteLine("Please input your email");

            string email = Console.ReadLine();

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (!match.Success)
            {

                throw new IncorrectEmailFormatException("Email not in the correct format", DateTime.Now ) 
                {
                    HelpLink = "https://snov.io/knowledgebase/what-is-a-valid-email-address-format/",
                    Data =
                    {
                        {"TimeStamp", $"Invalid Email at {DateTime.Now}" },
                        {"Cause", $"{email} doesn't have an @ and a dot" }
                    }
                };
            }
            Console.WriteLine($"Email is {email}");
            Console.WriteLine($"Username: {Username} \nPin:{ID} \nEmail:{email}");


        }
 

    }
}
