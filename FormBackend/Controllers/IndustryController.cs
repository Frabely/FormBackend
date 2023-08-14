using FormBackend.Data;
using FormBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndustryController : ControllerBase
    {
        private readonly ApiContext _context;

        public IndustryController(ApiContext context)
        {
            _context = context;
        }
        
        //create
        [HttpPost]
        public JsonResult CreateIndustry(Industry industry)
        {
            // var company = _context.Companies.Include(c => c.Industry).FirstOrDefault();
            if (industry.IndustryId == 0)
            {
                _context.Industries?.Add(industry);
                _context.SaveChanges();
                return new JsonResult(Ok(industry));
            }
            _context.SaveChanges();
            return new JsonResult(NotFound());
        }
        
        //get all
        [HttpGet]
        public JsonResult GetIndustries()
        {
            if (_context.Industries == null) 
                return new JsonResult(NotFound());
            var industries = _context.Industries.ToList();
            return new JsonResult(Ok(industries));
        }
    }
}