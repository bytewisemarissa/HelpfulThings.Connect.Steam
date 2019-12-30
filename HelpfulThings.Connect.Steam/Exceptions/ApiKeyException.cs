using System;

namespace HelpfulThings.Connect.Steam.Exceptions
{
    public class ApiKeyException : Exception

    {
        public ApiKeyException() : 
            base("The server returned a 'Unauthorized'(401) status code. Please check your API key."){}
    }
}