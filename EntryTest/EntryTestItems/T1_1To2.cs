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

        [Test]
        public void When_this_is_empty_range_should_not_overlap_other()
        {
            var subject = new T1Range(2, 1);
            var other = new T1Range(1, 4);
            Assert.IsTrue(subject.is_empty());
            Assert.IsFalse(subject.is_overlap(other));
        }

        /*[Test]
        public void When_other_is_empty_range_should_not_overlap_other(){
            var subject = new T1Range(1,4);
            var other = new T1Range(2,1);
            Assert.IsTrue(other.is_empty());
            Assert.IsFalse(subject.is_overlap(other));
        }*/

        [Test]
        public void When_end_is_earlier_than_others_start_range_should_not_overlap_other()
        {
            var subject = new T1Range(1, 3);
            var other = new T1Range(4, 6);
            Assert.IsFalse(subject.is_overlap(other));
        }

        [Test]
        public void When_start_is_later_than_others_end_range_should_not_overlap_other()
        {
            var subject = new T1Range(4, 6);
            var other = new T1Range(1, 3);
            Assert.IsFalse(subject.is_overlap(other));
        }

        [Test]
        public void When_start_is_earlier_than_others_end_and_start_is_later_than_others_start_range_should_overlap_other()
        {
            var subject = new T1Range(2, 6);
            var other = new T1Range(1, 3);
            Assert.IsTrue(subject.is_overlap(other));
        }

        [Test]
        public void When_value_is_not_earlier_than_start_and_is_not_later_than_end_range_should_contain_value()
        {
            var subject = new T1Range(1, 4);
            int value = 3;
            Assert.IsTrue(subject.contains(value));
        }
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

        /*[Test]
		public void When_start_equals_end_range_should_not_be_empty(){
			var subject = new T1Range(1, 1);
            Assert.IsFalse(subject.is_empty());
		}*/

        [Test]
        public void When_start_is_later_than_end_range_should_be_empty()
        {
            var subject = new T1Range(2, 1);
            Assert.IsTrue(subject.is_empty());
        }

        [Test]
        public void When_this_is_empty_range_should_not_overlap_other()
        {
            var subject = new T1Range(2, 1);
            var other = new T1Range(1, 4);
            Assert.IsTrue(subject.is_empty());
            Assert.IsFalse(subject.is_overlap(other));
        }

        [Test]
        public void When_end_is_earlier_than_others_start_range_should_not_overlap_other()
        {
            var subject = new T1Range(1, 3);
            var other = new T1Range(4, 6);
            Assert.IsFalse(subject.is_empty());
            Assert.IsFalse(other.is_empty());
            Assert.IsFalse(subject.is_overlap(other));
        }

        [Test]
        public void When_start_is_later_than_others_end_range_should_not_overlap_other()
        {
            var subject = new T1Range(4, 6);
            var other = new T1Range(1, 3);
            Assert.IsFalse(subject.is_empty());
            Assert.IsFalse(other.is_empty());
            Assert.IsFalse(subject.is_overlap(other));
        }

        [Test]
        public void When_start_is_earlier_than_others_end_and_start_is_later_than_others_start_range_should_overlap_other()
        {
            var subject = new T1Range(2, 6);
            var other = new T1Range(1, 3);
            Assert.IsFalse(subject.is_empty());
            Assert.IsFalse(other.is_empty());
            Assert.IsTrue(subject.is_overlap(other));
        }

        [Test]
        public void When_value_is_not_earlier_than_start_and_is_not_later_than_end_range_should_contain_value()
        {
            var subject = new T1Range(1, 4);
            int value = 3;
            Assert.IsTrue(subject.contains(value));
        }

        [Test]
        public void When_value_is_earlier_than_start_range_should_not_contain_value()
        {
            var subject = new T1Range(2, 4);
            int value = 1;
            Assert.IsFalse(subject.contains(value));
        }
    }
}