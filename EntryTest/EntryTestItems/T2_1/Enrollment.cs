namespace EntryTest.EntryTestItems.T2_1
{
    public class Enrollment
    {
        public EnrollmentState State { get; set; }

        public Enrollment()
        {
            State = new StartEnrolling(this);
        }

        public void go_next()
        {
            State.go_next();
        }
    }
}