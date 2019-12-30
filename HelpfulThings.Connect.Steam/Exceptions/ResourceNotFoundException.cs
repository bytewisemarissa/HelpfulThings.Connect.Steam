using System;

namespace HelpfulThings.Connect.Steam.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException() : 
            base($"The server returned a 'Not Found'(404) status code.  HelpfulThings.Connect.Steam may be outdated, please check for updates.") { }
    }
}