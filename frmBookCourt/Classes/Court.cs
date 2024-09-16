namespace frmBookCourt.Classes
{
    public class Court
    {
        public int CourtNumber { get; set; }
        public string CourtType { get; set; }
        public List<Booking> Bookings { get; set; }

        public Court(int courtNumber, string courtType)
        {
            CourtNumber = courtNumber;
            CourtType = courtType;
            Bookings = new List<Booking>();
        }

        public bool IsBooked(DateTime startTime, DateTime endTime)
        {
            foreach (Booking booking in Bookings)
            {
                if(startTime < booking.EndTime && endTime > booking.StartTime)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
