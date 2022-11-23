using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncorrectEmailFormatException
{
    internal class IncorrectEmailFormatException : ApplicationException
    {
        private string _errorMessage = string.Empty;

        public string CauseOfError { get; set; }

        public DateTime ErrorTimeStamp { get; set; }

        public IncorrectEmailFormatException()
        {

        }

        public IncorrectEmailFormatException(string causeOfError, DateTime errorTimeStamp) : this(string.Empty, causeOfError, errorTimeStamp)
        {

        }
        public IncorrectEmailFormatException(string errorMessage, string causeOfError, DateTime errorTimeStamp) 
            :this(errorMessage, causeOfError, errorTimeStamp, null)
        {
                
        }

        public IncorrectEmailFormatException(string errorMessage, string causeOfError, DateTime errorTimeStamp, System.Exception inner)
            : base(errorMessage, inner)
        {
            _errorMessage = errorMessage;
            CauseOfError = causeOfError;
            ErrorTimeStamp = errorTimeStamp;
        }
    }
}
