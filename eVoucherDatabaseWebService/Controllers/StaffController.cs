using eVoucher_BUS.Requests.GameRequests;
using eVoucher_BUS.Requests.StaffRequests;
using eVoucher_BUS.Services;
using eVoucher_DTO.Models;
using Microsoft.AspNetCore.Mvc;

namespace eVoucherDatabaseWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : Controller
    {
        private StaffService _staffService;
        public StaffController(StaffService staffService)
        {
            _staffService = staffService;
        }
        // POST api/<StaffController>
        [HttpPost]
        public async Task<ActionResult<Game>> Post([FromBody] StaffRegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _staffService.RegisterStaff(request);
            return Ok(result);
        }

    }
}
