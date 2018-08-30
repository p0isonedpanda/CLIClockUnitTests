using System;

namespace ClockProject
{
    public class Clock
    {
        private Counter _sec;
        private Counter _min;
        private Counter _hour;

        public string CurrentTime
        {
            get
            {
                string output = String
                    .Concat(_hour.Value.ToString(), ":", _min.Value.ToString(), ":", _sec.Value.ToString());

                return output;
            }
        }

        public Clock()
        {
            _sec = new Counter("sec");
            _min = new Counter("min");
            _hour = new Counter("hour");
        }

        public void Tick()
        {
            _sec.Increment();
            if (_sec.Value == 60)
            {
                _sec.Reset();
                _min.Increment();

                if (_min.Value == 60)
                {
                    _min.Reset();
                    _hour.Increment();
                }
            }
        }

        public void Reset()
        {
            _sec.Reset();
            _min.Reset();
            _hour.Reset();
        }
    }
}

