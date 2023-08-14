using FormBackend.Data;
using FormBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ApiContext _context;

        public CompanyController(ApiContext context)
        {
            _context = context;
        }

        // Create

        [HttpPost]
        public JsonResult CreateCompany(Company company)
        {
            // var company = _context.Companies.Include(c => c.Industry).FirstOrDefault();
            if (company.Id == 0)
            {
                if (_context.Industries != null)
                {
                    var isIndustry = _context.Industries.Find(company.IndustryId);

                    if (isIndustry == null)
                    {
                        _context.SaveChanges();
                        return new JsonResult(NotFound());
                    }
                }

                _context.Companies?.Add(company);
                _context.SaveChanges();
                return new JsonResult(Ok(company));
            }

            _context.SaveChanges();
            return new JsonResult(NotFound());
        }

        // Get

        [HttpGet]
        public JsonResult GetCompany(int id)
        {
            var result = _context.Companies?.Find(id);
            return result == null ? new JsonResult(NotFound()) : new JsonResult(Ok(result));
        }
    }
}