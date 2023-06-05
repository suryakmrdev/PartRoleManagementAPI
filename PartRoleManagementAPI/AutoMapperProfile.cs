using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PartRoleManagementAPI.Dto;
using PartyRoleManagementAPI.Models;

namespace PartRoleManagementAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TimePeriod, TimePeriodDto>();
            CreateMap<TimePeriod, TimePeriodDto>().ReverseMap();

            CreateMap<PartyRef, RelatedPartyDto>();
            CreateMap<PartyRef, RelatedPartyDto>().ReverseMap();

            CreateMap<AccountRef, AccountRefDto>();
            CreateMap<AccountRef, AccountRefDto>().ReverseMap();

            CreateMap<RelatedParty, RelatedPartyDto>();
            CreateMap<RelatedParty, RelatedPartyDto>().ReverseMap();

            CreateMap<PaymentMethodRef, PaymentMethodRefDto>();
            CreateMap<PaymentMethodRef, PaymentMethodRefDto>().ReverseMap();

            CreateMap<Characteristic, CharacteristicDto>();
            CreateMap<Characteristic, CharacteristicDto>().ReverseMap();

            CreateMap<CreditProfileDto, CreditProfile>();

            CreateMap<CreditProfileDto, CreditProfile>().ReverseMap();

            CreateMap<AgreementRef, AgreementRefDto>();
            CreateMap<AgreementRef, AgreementRefDto>().ReverseMap();


            CreateMap<MediumCharacteristic, MediumCharacteristicDto>();
            CreateMap<MediumCharacteristic, MediumCharacteristicDto>().ReverseMap();
            CreateMap<ContactMediumDto, ContactMedium>().ForMember(dest => dest.Characteristic, act => act.MapFrom(src => src.Characteristic));
            CreateMap<ContactMediumDto, ContactMedium>().ForMember(dest => dest.Characteristic, act => act.MapFrom(src => src.Characteristic)).ReverseMap();


            CreateMap<PartyRoleDto, PartyRole>()
                 .ForMember(dest => dest.ValidFor, act => act.MapFrom(src => src.ValidFor))
                .ForMember(dest => dest.EngagedParty, act => act.MapFrom(src => src.EngagedParty))
                .ForMember(dest => dest.Account, act => act.MapFrom(src => src.Account))
                .ForMember(dest => dest.PaymentMethod, act => act.MapFrom(src => src.PaymentMethod))
                .ForMember(dest => dest.Characteristic, act => act.MapFrom(src => src.Characteristic))
                .ForMember(dest => dest.CreditProfile, act => act.MapFrom(src => src.CreditProfile))
                .ForMember(dest => dest.Agreement, act => act.MapFrom(src => src.Agreement))
                .ForMember(dest => dest.RelatedParty, act => act.MapFrom(src => src.RelatedParty))
                .ForMember(dest => dest.EngagedParty, act => act.MapFrom(src => src.EngagedParty));

            CreateMap<PartyRoleDto, PartyRole>()
                .ForMember(dest => dest.ValidFor, act => act.MapFrom(src => src.ValidFor))
               .ForMember(dest => dest.EngagedParty, act => act.MapFrom(src => src.EngagedParty))
               .ForMember(dest => dest.Account, act => act.MapFrom(src => src.Account))
               .ForMember(dest => dest.PaymentMethod, act => act.MapFrom(src => src.PaymentMethod))
               .ForMember(dest => dest.Characteristic, act => act.MapFrom(src => src.Characteristic))
               .ForMember(dest => dest.CreditProfile, act => act.MapFrom(src => src.CreditProfile))
               .ForMember(dest => dest.Agreement, act => act.MapFrom(src => src.Agreement))
               .ForMember(dest => dest.RelatedParty, act => act.MapFrom(src => src.RelatedParty)).ReverseMap();





        }
    }
}
