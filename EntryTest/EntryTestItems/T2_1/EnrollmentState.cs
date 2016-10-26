namespace EntryTest.EntryTestItems.T2_1
{
    public abstract class EnrollmentState
    {
        protected Enrollment enrollment;

        protected EnrollmentState(Enrollment enrollment)
        {
            this.enrollment = enrollment;
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
    }

    public class BookedSubjects : EnrollmentState
    {
        public BookedSubjects(Enrollment enrollment)
            : base(enrollment)
        {
        }

        public override string Code
        {
            get { throw new System.NotImplementedException(); }
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
            get { throw new System.NotImplementedException(); }
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
            get { throw new System.NotImplementedException(); }
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
            get { throw new System.NotImplementedException(); }
        }
    }
}