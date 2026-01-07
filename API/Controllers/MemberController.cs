using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
       private readonly AppDbContext _appDbContext;
        public MemberController(AppDbContext appDbContext)
        {
            _appDbContext=appDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
        {
            var membes=await _appDbContext.AppUsers.ToListAsync();
            return membes;
        }

[HttpGet("{Id}")]
        public ActionResult<AppUser> GetMember(string Id)
        {
            var member=_appDbContext.AppUsers.Find(Id);
if (member == null)
            {
                return NotFound();
            }
            return member;
        }

        // public ActionResult<AppUser> SaveMember()
        // {
            
        // }
    }
}
