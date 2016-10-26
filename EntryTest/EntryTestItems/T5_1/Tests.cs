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

            //TODO: uncomment out asserts below and make them passed.
            //Assert.IsTrue(range.contain(1));
            //Assert.IsTrue(range.contain(2));
            //Assert.IsTrue(range.contain(3));
            //Assert.IsFalse(range.contain(4));

        }
    }
}