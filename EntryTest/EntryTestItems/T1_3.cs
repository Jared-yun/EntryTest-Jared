using NUnit.Framework;
using Rhino.Mocks;

namespace EntryTest.EntryTestItems
{
    public interface Service
    {
        bool Pay(decimal money);
    }
    public class T1_3_Enrollment
    {
        private Service service;

        public T1_3_Enrollment(Service service)
        {
            this.service = service;
        }

        public decimal PaidAmount { get; private set; }

        public void Process(int count_of_subject, decimal price_per_subject)
        {
            var amount = price_per_subject * count_of_subject;
            var to_pay = amount - PaidAmount;
            if (to_pay <= 0) return;
            if (service.Pay(to_pay))
                PaidAmount += to_pay;
        }
    }

    //TODO: Please finish tests below according to test description
    [TestFixture]
    public class T1_3_Using_Rhnio_Mock_Test
    {
        private Service service;
        private T1_3_Enrollment subject;

        [SetUp]
        public void SetUp()
        {
            service = MockRepository.GenerateMock<Service>();
            subject = new T1_3_Enrollment(service);
        }
		
        [Test]
        public void When_pay_successit_should_add_up_to_paid_amount()
        {
            //TODO: ...
            subject.Process(4, 25M);
            Assert.AreEqual(100M, subject.PaidAmount);
        }

        [Test]
        public void When_pay_failed_it_should_not_add_up_to_paid_amount()
        {
            //TODO: ...
            subject.Process(4, 25M);
            Assert.AreEqual(0M, subject.PaidAmount);
        }
    }
}