using System;

namespace StopWatch
{
    class StopWatch
    {
        private bool IsStarted { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }

        public StopWatch()
        {
            IsStarted = false;
        }

        public void Start()
        {
            if (!IsStarted)
            {
                Console.WriteLine("Stop watch started");
                IsStarted = true;
                StartTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Stop watch is already started");
            }
        }

        public void Stop()
        {
            if (IsStarted)
            {
                Console.WriteLine("Stop watch stopped");
                IsStarted = false;
                EndTime = DateTime.Now;
                var timeSpan = EndTime - StartTime;
                Console.WriteLine($"Duration is {timeSpan.Seconds} sec");
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is not started yet");
            }
        }
    }
}