//Based on http://www.interact-sw.co.uk/iangblog/2004/03/23/locking

using System;
using System.Threading;
using HelpfulThings.Connect.Steam.Exceptions;

namespace HelpfulThings.Connect.Steam.Concurrency
{
#if DEBUG
    public class TimedLock : IDisposable
#else
    public struct TimedLock : IDisposable
#endif
    {
        private readonly object _target;
        
        private TimedLock (object o)
        {
            _target = o;
        }
        
        public static TimedLock Lock (object obj)
        {
            return Lock (obj, TimeSpan.FromSeconds(10));
        }

        public static TimedLock Lock (object obj, TimeSpan timeout)
        {
            var returnLock = new TimedLock (obj);
            if (Monitor.TryEnter(obj, timeout)) return returnLock;
#if DEBUG
            System.GC.SuppressFinalize(returnLock);
#endif
            throw new LockTimeoutException();
        }

        public void Dispose ()
        {
            Monitor.Exit (_target);

            // It's a bad error if someone forgets to call Dispose,
            // so in Debug builds, we put a finalizer in to detect
            // the error. If Dispose is called, we suppress the
            // finalizer.
#if DEBUG
            GC.SuppressFinalize(this);
#endif
        }

#if DEBUG
        ~TimedLock()
        {
            // If this finalizer runs, someone somewhere failed to
            // call Dispose, which means we've failed to leave
            // a monitor!
            System.Diagnostics.Debug.Fail("Undisposed lock");
        }
#endif
    }
}