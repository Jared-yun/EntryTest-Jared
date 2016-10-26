using NUnit.Framework;

namespace EntryTest.EntryTestItems
{
    public struct T1Range
    {
        private int start;
        private int end;

        public T1Range(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public bool is_empty()
        {
            return start > end;
        }

        public bool is_overlap(T1Range other)
        {
            if (is_empty() || other.is_empty())
                return false;
            if (end < other.start)
                return false;
            if (start > other.end)
                return false;
            return true;
        }

        public bool contains(int value)
        {
            return !(start > value) && !(end < value);
        }
    }


    [TestFixture]
    public class T1_1_Range_Statement_Converage_Tests
    {
        [Test]
        public void When_start_is_earlier_than_end_range_should_not_be_empty()
        {
            var subject = new T1Range(1, 4);
            Assert.IsFalse(subject.is_empty());
        }
        //TODO: Finish tests below to cover all code statement ....
    }

    [TestFixture]
    public class T1_2_Range_Path_Converage_Tests
    {
        [Test]
        public void When_start_is_earlier_than_end_range_should_not_be_empty()
        {
            var subject = new T1Range(1, 4);
            Assert.IsFalse(subject.is_empty());
        }
        //TODO:Finish tests below to cover all code paths ....
    }
}