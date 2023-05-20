using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using mvc_in_memory_data_store.Data;
using mvc_in_memory_data_store.Models;
using System;

namespace mvc_in_memory_data_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BagelsController : ControllerBase
    {
        IBagelRepository _bagelRepository;
        public BagelsController(IBagelRepository bagelRepository)
        {
            _bagelRepository = bagelRepository;
        }
        [HttpGet]
        public async Task<IResult> Get()
        {
            try
            {                
                return Results.Ok(_bagelRepository.findAll());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IResult> Put(Bagel bagel)
        {
            try
            {
                if (_bagelRepository.Add(bagel)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
