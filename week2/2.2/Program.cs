using System;

namespace CounterTask
{
    public class Counter
    {
        private int _count;
        private string _name;

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public void Increment()
        {
            _count++;
        }

        public void Reset()
        {
            _count = 0;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Ticks
        {
            get
            {
                return _count;
            }
        }
    }
    public class MainClass
    {
        private static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
            {
                Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
            }
        }

        public static void Main(string[] args)
        {
            Counter[] myCounter = new Counter[3];
            int i = 0;

            myCounter[0] = new Counter("Counter 1");
            myCounter[1] = new Counter("Counter 2");
            myCounter[2] = myCounter[0];

            for (i = 0; i <= 9; i++)
            {
                myCounter[0].Increment();
            }

            for (i = 0; i <= 14; i++)
            {
                myCounter[1].Increment();
            }

            PrintCounters(myCounter);
            Console.ReadLine();

            myCounter[2].Reset();

            PrintCounters(myCounter);
            Console.ReadLine();
        }
    }
}