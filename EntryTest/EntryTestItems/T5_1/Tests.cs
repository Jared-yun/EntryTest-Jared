using NUnit.Framework;
using Rhino.Mocks;

namespace EntryTest.EntryTestItems.T5_1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void When()
        {
            var range = MockRepository.GenerateMock<Range<int>>();
            range.Stub(x => x.Start).Return(1);
            range.Stub(x => x.End).Return(3);
            Assert.IsTrue(range.contain(1));
            Assert.IsTrue(range.contain(2));
            Assert.IsTrue(range.contain(3));
            Assert.IsFalse(range.contain(4));

        }

    }

    public static class ExtensionClass
    {
        public static bool contain(this Range<int> x, int a)
        {
            return a >= x.Start && a <= x.End;
        }
    }
}