using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IncorrectEmailFormatException
{
    internal class SimpleLogIn
    {
        public string Username { get; set; }
        public string Email { get; set; }
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

            if (!email.Contains('@'))
            {
               // Console.WriteLine($"Invalid Email");

                throw new IncorrectEmailFormatException($"A valid email {Email} must have an @", "The wrong placement of @", DateTime.Now) 
                {
                    HelpLink = "https://snov.io/knowledgebase/what-is-a-valid-email-address-format/",
                    Data =
                    {
                        {"TimeStamp", $"Invalid Email at {DateTime.Now}" },
                        {"Cause", $"{Email} doesn't have an @" }
                    }
                };
            }
            Console.WriteLine($"Email is {Email}");

           
        }
        public void DisplayInfo()
        {
            ValidateEmail();

            Console.WriteLine($"Username: {Username} \nPin:{ID} \nEmail:{Email}");
        }

    }
}
