using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_in_memory_data_store.Models;

namespace mvc_in_memory_data_store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BagelController : ControllerBase
    {
        BagelRepository repository;
        public BagelController(BagelRepository repo)
        {
            this.repository = repo;
        }

        [HttpGet("/bagels", Name = "Get")]
        public ActionResult<List<Bagel>> GetAll()
        {
            return this.repository.findAll();
        }
    }
}
