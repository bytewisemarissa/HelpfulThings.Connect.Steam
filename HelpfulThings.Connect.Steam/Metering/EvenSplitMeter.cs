using System;
using HelpfulThings.Connect.Steam.Concurrency;
using HelpfulThings.Connect.Steam.Interfaces;

namespace HelpfulThings.Connect.Steam.Metering
{
    public class EvenSplitMeter : ISteamRequestMeter
    {
        private readonly object _concurrencyLock;
        private readonly double _secondsPerRequest;
        private DateTime _lastRequestScheduledTime;
        
        public EvenSplitMeter(SteamApiOptions options)
        {
            _concurrencyLock = new object();
            
            var meteringPeriodHoursDouble = Convert.ToDouble(options.MeteringPeriodHours);
            var requestLimitDouble = Convert.ToDouble(options.RequestLimit);

            var meteringPeriodSeconds = meteringPeriodHoursDouble * 3600; //Magic number -> 1 hour * 60 minutes * 60 seconds
            _secondsPerRequest = meteringPeriodSeconds / requestLimitDouble;
            
            _lastRequestScheduledTime = DateTime.UtcNow;
        }

        public DateTime ScheduleRequest()
        {
            using (TimedLock.Lock(_concurrencyLock))
            {
                _lastRequestScheduledTime = _lastRequestScheduledTime < DateTime.UtcNow.AddSeconds(_secondsPerRequest)
                    ? DateTime.UtcNow
                    : _lastRequestScheduledTime.AddSeconds(_secondsPerRequest);

                return _lastRequestScheduledTime;
            }
        }
    }
}