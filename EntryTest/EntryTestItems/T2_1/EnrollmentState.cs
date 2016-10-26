namespace EntryTest.EntryTestItems.T2_1
{
    public abstract class EnrollmentState
    {
        protected Enrollment enrollment;
        protected PaymentService service;

        protected EnrollmentState(Enrollment enrollment)
        {
            this.enrollment = enrollment;
        }

        public void set_service(PaymentService service)
        {
            this.service = service;
        }

        public abstract string Code { get; }
        public virtual void go_next()
        {
            throw new InvalidOperationOnState(Code);
        }
    }

    public class StartEnrolling : EnrollmentState
    {
        public StartEnrolling(Enrollment enrollment)
            : base(enrollment)
        {
        }

        public override string Code
        {
            get { return "Start"; }
        }

        public override void go_next()
        {
            enrollment.State = new BookedSubjects(enrollment);
        }
    }

    public class BookedSubjects : EnrollmentState
    {
        public BookedSubjects(Enrollment enrollment)
            : base(enrollment)
        {
        }

        public override string Code
        {
            get { return "Booked"; }
        }

        public override void go_next()
        {
            enrollment.State = new Paying(enrollment);
        }
    }

    public class Paying : EnrollmentState
    {

        public Paying(Enrollment enrollment)
            : base(enrollment)
        {
        }

        public override string Code
        {
            get { return "Paying"; }
        }

        public override void go_next()
        {
            if (service.pay(enrollment.price))
            {
                enrollment.State = new PaidSuccess(enrollment);
            }
            else
            {
                enrollment.State = new PaidFailure(enrollment);
            }
        }
    }

    public class PaidSuccess : EnrollmentState
    {
        public PaidSuccess(Enrollment enrollment)
            : base(enrollment)
        {
        }

        public override string Code
        {
            get { return "PaySuccess"; }
        }
    }

    public class PaidFailure : EnrollmentState
    {
        public PaidFailure(Enrollment enrollment)
            : base(enrollment)
        {
        }

        public override string Code
        {
            get { return "PayFailure"; }
        }
    }
}