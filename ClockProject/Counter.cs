using System;

namespace ClockProject
{
    public class Counter
    {
        private int count;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Value
        {
            get
            {
                return count;
            }
        }

        public Counter(string _name)
        {
            name = _name;
            count = 0;
        }

        public void Increment()
        {
            count++;
        }

        public void Reset()
        {
            count = 0;
        }
    }
}
