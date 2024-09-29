using System;

namespace projectController
{
	public class Rooms
	{

		public int roomId { get; set; }
	public int floor { get; set; }
	public DateOnly nextOrder { get; set; }
	public DateTime checkIn { get; set; }
	public DateTime checkOut { get; set; }
	public bool isAvailable { get; set; }
  }
}
