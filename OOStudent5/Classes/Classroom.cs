namespace OOStudent5.Classes
{
    internal class Classroom
    {
        public int NumberOfChairs { get; set; }
        public string NameOfClassroom { get; set; }
        public int ClassroomSize { get; set; }
        public List<Lecture> Lectures { get; set; }

        private void GetLectures()
        {
            if (Lectures == null)
            {
                Lectures = new List<Lecture>();
            }
            Lecture lecture = new Lecture();
            lecture.StartTime = DateTime.Parse("2024-09-16 10:00");
            lecture.EndTime = DateTime.Parse("2024-09-16 11:00");
            Lectures.Add(lecture);
            lecture.StartTime = DateTime.Parse("2024-09-17 10:00");
            lecture.EndTime = DateTime.Parse("2024-09-17 11:00");
            Lectures.Add(lecture);
        }

        public bool IsClassRoomSizeEnough (int minSize)
        {
            if(minSize < ClassroomSize)
            return false;

            else
            return true;    
        }

        public bool IsClassroomFree(DateTime start, DateTime end)
        {
            GetLectures();

            foreach (Lecture lecture in Lectures)
            {
                if((start >= lecture.StartTime && end <= lecture.EndTime) ||
                   (end > lecture.StartTime && end <= lecture.EndTime))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
