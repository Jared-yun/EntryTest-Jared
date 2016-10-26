using System;

namespace EntryTest.EntryTestItems.T4_1
{
    public class ContainerClass
    {
        public int Process(int value)
        {
            return Expand(Increase(value));

        }

        public Func<int, int> Processor()
        {
            Func<int, int> func = x => Expand(Increase(x));
            return func;
        }

        private int Expand(int value)
        {
            return value * 10;
        }

        public int Increase(int value)
        {
            return value + 10;
        }
    }
}