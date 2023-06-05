using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PartRoleManagementAPI.Data;
using PartRoleManagementAPI.Dto;
using PartRoleManagementAPI.Models;
using PartyRoleManagementAPI.Models;
using System.Collections.Generic;

namespace PartRoleManagementAPI.Services
{
    public class PartRoleManagmentService : IPartRoleManagmentService
    {
        private readonly DatabaseContext databaseContext;
        private readonly IMapper mapper;
        public PartRoleManagmentService(DatabaseContext databaseContext, IMapper mapper)
        {
            this.databaseContext = databaseContext;
            this.mapper = mapper;
        }
        public async Task<ServiceResponse<List<PartyRoleDto>>> GetAllPartyRolesAsync()
        {
            ServiceResponse<List<PartyRoleDto>> response = new ServiceResponse<List<PartyRoleDto>>();
            var partyRoles = await this.databaseContext.PartyRole.ToListAsync();
            response.Data = partyRoles.Select(s => mapper.Map<PartyRoleDto>(s)).ToList();
            return response;
        }

        public async Task<ServiceResponse<PartyRoleDto>> GetPartyRoleByIdAsync(string id)
        {
            ServiceResponse<PartyRoleDto> response = new ServiceResponse<PartyRoleDto>();
            try
            {
                var partyRole = await this.databaseContext.PartyRole.FirstOrDefaultAsync(s => s.Id == id);
                if (partyRole == null)
                {
                    response.Success = false;
                    response.Message = $"Skill with id {id} not found";
                    return response;
                }
                response.Data = mapper.Map<PartyRoleDto>(partyRole);

            }
            catch (System.Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<PartyRoleDto>> UpdatePartyRoleByIdAsync(string id, PartyRoleDto partyRoleDto)
        {
            ServiceResponse<PartyRoleDto> response = new ServiceResponse<PartyRoleDto>();
            try
            {
                var partyRoleItem = await this.databaseContext.PartyRole.FirstOrDefaultAsync(s => s.Id == id);
                if (partyRoleItem == null)
                {
                    response.Success = false;
                    response.Message = $"PartyRole with id {id} not found";
                    return response;
                }
                var partyRole = mapper.Map<PartyRole>(partyRoleDto);
                this.databaseContext.Entry(partyRole).State = EntityState.Modified;
                await this.databaseContext.SaveChangesAsync();
                response.Data = mapper.Map<PartyRoleDto>(partyRole);

            }
            catch (System.Exception ex)
            {

                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ServiceResponse<List<PartyRoleDto>>> AddPartyRoleAsync(PartyRoleDto partyRoleDto)
        {
            ServiceResponse<List<PartyRoleDto>> response = new ServiceResponse<List<PartyRoleDto>>();
            try
            {
                var partyRole = mapper.Map<PartyRole>(partyRoleDto);
                await this.databaseContext.PartyRole.AddAsync(partyRole);
                await this.databaseContext.SaveChangesAsync();
                var partyRoleList = await this.databaseContext.PartyRole.ToListAsync();
                response.Data = partyRoleList.Select(s => mapper.Map<PartyRoleDto>(s)).ToList();

            }
            catch (System.Exception ex)
            {

                response.Success = false;
                response.Message = $"Adding PartyRole failed";
            }

            return response;
        }
    }
}
