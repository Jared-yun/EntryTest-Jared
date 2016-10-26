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
            //TODO:Using lambda expression to combine Increase and Expand function  below;
            Func<int, int> func = Increase; // This is not enough, only increase function include.
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