using System;

namespace HelpfulThings.Connect.Steam.Exceptions
{
    public class LockTimeoutException : Exception
    {
        public LockTimeoutException () : base("Timeout waiting for lock") { }
    }
}