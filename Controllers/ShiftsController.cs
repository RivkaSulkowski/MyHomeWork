using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftsController : ControllerBase
    {
        private static new List<Shifts> shifts = new List<Shifts>
        {
            new Shifts{shiftId=1, shiftDate=new DateTime(2024,12,06),shiftHour=new DateOnly(10,20,00),workerId=1,roomId=1},
            
        };
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Shifts> Get()
        {
           return shifts;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public Shifts Get(int id)
        {

            Shifts ev = shifts.FirstOrDefault(e => e.shiftId == id);
            return ev;
        }


        // POST api/<ShiftsController>
        [HttpPost]
        public Shifts Post([FromBody] Shifts s)
        {
            shifts.Add(s);
            return s;
        }

        // PUT api/<ShiftsController>/5
        [HttpPut("{id}")]
        public Shifts Put(int id, [FromBody] Shifts s )
        {
            var index = shifts.FindIndex(u => u.shiftId == id);
            shifts[index].shiftId = s.shiftId;
            shifts[index].shiftDate = s.shiftDate;
            shifts[index].shiftHour = s.shiftHour;
            shifts[index].workerId = s.workerId;
            shifts[index].roomId = s.roomId;

            return shifts[index];
        }

        // DELETE api/<ShiftsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = shifts.FindIndex(e => e.roomId == id);
            shifts.RemoveAt(index);


        }
    }
}
