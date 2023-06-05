using Microsoft.AspNetCore.Mvc;
using PartRoleManagementAPI.Dto;
using PartRoleManagementAPI.Models;
using PartRoleManagementAPI.Services;

namespace PartRoleManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyRolesController : ControllerBase
    {
        private readonly IPartRoleManagmentService partRoleManagmentService;

        public PartyRolesController(IPartRoleManagmentService partRoleManagmentService)
        {
            this.partRoleManagmentService = partRoleManagmentService;
        }

        // GET: api/PartyRoles
        [HttpGet]
        public async Task<IActionResult> GetPartyRole()
        {
            var partyRoles = await partRoleManagmentService.GetAllPartyRolesAsync();
            return Ok(partyRoles);
        }

        // GET: api/PartyRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PartyRoleDto>> GetPartyRole(string id)
        {
            ServiceResponse<PartyRoleDto> response = await partRoleManagmentService.GetPartyRoleByIdAsync(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        // POST: api/PartyRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostPartyRole(PartyRoleDto partyRole)
        {
            ServiceResponse<List<PartyRoleDto>> response = await partRoleManagmentService.AddPartyRoleAsync(partyRole);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
