using FormBackend.Data;
using FormBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ApiContext _context;

        public ClientController(ApiContext context)
        {
            _context = context;
        }
        
        // Create

        [HttpPost]
        public IActionResult AddClient([FromBody] Client client)
        {
            _context.Clients?.Add(client);
            _context.SaveChanges();

            return Ok(client);
        }
        
        //Get
        [HttpGet]
        public JsonResult Get(string id)
        {
            var result = _context.Clients?.Find(id);
            return result == null ? new JsonResult(NotFound()) : new JsonResult(Ok(result));
        }
    }
}
