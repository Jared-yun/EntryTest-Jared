namespace EntryTest.EntryTestItems.T2_1
{
    public class Enrollment
    {
        public EnrollmentState State { get; set; }
        public decimal price;

        public Enrollment()
        {
            State = new StartEnrolling(this);
        }

        public void set_price(decimal price)
        {
            this.price = price;
        }

        public void go_next()
        {
            State.go_next();
        }
    }
}