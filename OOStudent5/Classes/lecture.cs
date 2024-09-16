namespace OOStudent5.Classes
{
    internal class Lecture
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool IsBooked(string classroomName)
        {
            if(StartTime == null || EndTime == null)
            return false;
            else 
            return true;
        }

        public bool LectureRemove(string classroomName)
        {
            if (StartTime == null || EndTime == null)
                return false;
            else
                return true;
        }
    }
}
