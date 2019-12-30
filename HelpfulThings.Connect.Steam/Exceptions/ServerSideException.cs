using System;

namespace HelpfulThings.Connect.Steam.Exceptions
{
    public class ServerSideException : Exception
    {
        public ServerSideException() : 
            base("The server returned an 'Internal Server Error'(500) status code. Please try again later.") { }
    }
}