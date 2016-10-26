using NUnit.Framework;
using Rhino.Mocks;

namespace EntryTest.EntryTestItems.T2_1
{
    //TODO: Try to make all tests passed
    [TestFixture]
    public class EnrollmentStateTests
    {
        [Test]
        public void When_create_an_enrollment_its_state_should_be_start_enrolling()
        {
            var subject = new Enrollment();
            Assert.AreEqual("Start", subject.State.Code);

        }

        [Test]
        public void When_start_enrolling_call_go_next_its_state_should_be_booked()
        {
            var subject = new Enrollment();
            subject.State = new StartEnrolling(subject);
            subject.go_next();

            Assert.AreEqual("Booked", subject.State.Code);
        }

        [Test]
        public void When_booked_call_go_next_its_state_should_Paying()
        {
            var subject = new Enrollment();
            subject.State = new BookedSubjects(subject);
            subject.go_next();

            Assert.AreEqual("Paying", subject.State.Code);
        }

        [Test]
        public void When_Paying_call_go_next_and_payment_service_suceed_its_state_should_PaySuccess()
        {
            var payment_service = MockRepository.GenerateMock<PaymentService>();
            //TODO: Stub payment service to return true 
            //TODO: inject payment service to enrollment or state class
            var subject = new Enrollment();
            subject.State = new Paying(subject);
            subject.go_next();

            Assert.AreEqual("PaySuccess", subject.State.Code);
        }

        [Test]
        public void When_Paying_call_go_next_and_payment_service_fail_its_state_should_PayFailure()
        {
            var payment_service = MockRepository.GenerateMock<PaymentService>();
            //TODO: Stub payment service to return false 
            //TODO: inject payment service to enrollment or state class
            var subject = new Enrollment();
            subject.State = new Paying(subject);
            subject.go_next();

            Assert.AreEqual("PayFailure", subject.State.Code);
        }
    }
}