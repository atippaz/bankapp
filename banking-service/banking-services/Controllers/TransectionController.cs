using banking_service.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace banking_service.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TransectionController : ControllerBase
    {
        TransectionRepository tr;
        public TransectionController(TransectionRepository tr)
        {
            this.tr = tr;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                return Ok(await tr.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}