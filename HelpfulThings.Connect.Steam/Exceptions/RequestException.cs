using System;

namespace HelpfulThings.Connect.Steam.Exceptions
{
    public class RequestException : Exception
    {
        public RequestException(int code, string friendlyStatus, string advice) : 
            base($"The server returned the '{friendlyStatus}'({code}) status code. {advice}.") { }
    }
}