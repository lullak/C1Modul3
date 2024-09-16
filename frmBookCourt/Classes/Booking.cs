namespace frmBookCourt.Classes
{
    public class Booking
    {
        public Customer Customer { get; set; }
        public Court Court { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Booking(Customer customer, Court court, DateTime date, DateTime startTime, DateTime endTime)
        {
            Customer = customer;
            Court = court;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
