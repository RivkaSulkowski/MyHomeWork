using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private static new List<Rooms> rooms = new List<Rooms>
        {
            new Rooms{roomId=1, floor=4,nextOrder=new DateOnly(12,12,2024),checkIn=new DateTime(2024,11,28,11,30,00),checkOut=new DateTime(2024,12,04,10,00,00),isAvailable=true},
            new Rooms{roomId=3, floor=0,nextOrder=new DateOnly(12,12,2024),checkIn=new DateTime(2024,11,28,11,30,00),checkOut=new DateTime(2024,12,04,10,00,00),isAvailable=false},

        };
        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<Rooms> Get()
        {
           return rooms;
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public Rooms Get(int id)
        {

            Rooms ev = rooms.FirstOrDefault(e => e.roomId == id);
            return ev;
        }


        // POST api/<RoomsController>
        [HttpPost]
        public Rooms Post([FromBody] Rooms u)
        {
            rooms.Add(u);
            return u;
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public Rooms Put(int id, [FromBody] Rooms u )
        {
            var index = rooms.FindIndex(u => u.roomId == id);
            rooms[index].roomId = u.roomId;
            rooms[index].floor = u.floor;
            rooms[index].nextOrder = u.nextOrder;
            rooms[index].checkIn = u.checkIn;
            rooms[index].checkOut = u.checkOut;
            rooms[index].isAvailable = u.isAvailable;
            return rooms[index];
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = rooms.FindIndex(e => e.roomId == id);
            rooms.RemoveAt(index);

        }
    }
}
