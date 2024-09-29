using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static new List<Users> users = new List<Users>
        {
            new Users{userId=1, username="Chani Surkis",userMail="ch533196252@gmail.com",vocationDay=7,startHour=new TimeSpan(07,30,00),endHour=new TimeSpan(14,30,00)},
            new Users{userId=2, username="Rivka Sulkovsky",userMail="rsrsrs@gmail.com",vocationDay=7,startHour=new TimeSpan(15,00,00),endHour=new TimeSpan(23,00,00)},
             new Users{userId=3, username="Tamar Levin",userMail="tlevin@gmail.com",vocationDay=4,startHour=new TimeSpan(00,00,00),endHour=new TimeSpan(08,00,00)},
        };
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Users> Get()
        {
           return users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public Users Get(int id)
        {

            Users ev = users.FirstOrDefault(e => e.userId == id);
            return ev;
        }


        // POST api/<UsersController>
        [HttpPost]
        public Users Post([FromBody] Users u)
        {
            users.Add(u);
            return u;
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public Users Put(int id, [FromBody] Users u )
        {
            var index = users.FindIndex(u => u.userId == id);
            users[index].userId = e.userId;
            users[index]. username = e. username;
            users[index].userMail = e.userMail;
             users[index].vocationDay = e.vocationDay;
            
             users[index].startHour = e.startHour;
            
             users[index].endHour = e.endHour;
            
            

            return users[index];
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             var index=users.FindIndex(e => e.Id == id);
            users.RemoveAt(index);
        }
    }
}
