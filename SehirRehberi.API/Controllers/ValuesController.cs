using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Data;

namespace SehirRehberi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet()]
        public ActionResult GetValues()
        {
            var val = _context.Values.ToList();
            return Ok(val);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetValue(int id)
        {
            var val = await _context.Values.FirstOrDefaultAsync(v => v.Id == id);
            return Ok(val);
        }
    }
}
