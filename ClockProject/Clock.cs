using System;

namespace ClockProject
{
    public class Clock
    {
        private Counter _sec;
        private int _min;
        private int _hour;

        public string CurrentTime
        {
            get
            {
                string output = String
                    .Concat(_hour.ToString(), ":", _min.ToString(), ":", _sec.Value.ToString());

                return output;
            }
        }

        public Clock()
        {
            _sec = new Counter("min");
            _min = 0;
            _hour = 0;
        }

        public void Tick()
        {
            _sec.Increment();
            if (_sec.Value == 60)
            {
                _sec.Reset();
                _min++;

                if (_min == 60)
                {
                    _min = 0;
                    _hour++;
                }
            }
        }

        public void Reset()
        {
            _sec.Reset();
            _min = 0;
            _hour = 0;
        }
    }
}
