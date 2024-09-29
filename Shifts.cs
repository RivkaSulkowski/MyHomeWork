namespace projectController
{
    public class Shifts
    {
        public int shiftId { get; set; }
        public DateTime shiftDate { get; set; }

        public DateOnly shiftHour { get; set; }
        public int workerId { get; set; }

        public int roomId { get; set; }
    }
}
