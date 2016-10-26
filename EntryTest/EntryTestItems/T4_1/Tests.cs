using NUnit.Framework;

namespace EntryTest.EntryTestItems.T4_1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void when_use_process_function_pass_value_directly_and_get_result_110()
        {
            var subject = new ContainerClass();
            Assert.AreEqual(110, subject.Process(1));
        }

        [Test]
        public void when_use_processor_get_function_first_and_then_pass_value()
        {
            var subject = new ContainerClass().Processor();
            //TODO: Make test below passed.
            Assert.AreEqual(110, subject(1));
        }
    }
}