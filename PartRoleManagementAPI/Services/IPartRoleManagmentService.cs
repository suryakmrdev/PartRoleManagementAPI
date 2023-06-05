using PartRoleManagementAPI.Dto;
using PartRoleManagementAPI.Models;

namespace PartRoleManagementAPI.Services
{
    public interface IPartRoleManagmentService
    {

        Task<ServiceResponse<List<PartyRoleDto>>> GetAllPartyRolesAsync();

        Task<ServiceResponse<PartyRoleDto>> GetPartyRoleByIdAsync(string id);

        Task<ServiceResponse<PartyRoleDto>> UpdatePartyRoleByIdAsync(string id, PartyRoleDto partyRoleDto);
        Task<ServiceResponse<List<PartyRoleDto>>> AddPartyRoleAsync(PartyRoleDto partyRoleDto);
    }
}
