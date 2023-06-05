using PartRoleManagementAPI.Dto;
using PartyRoleManagementAPI.Models;

namespace PartyRoleManagementAPI.Models
{ 

    public partial class PartyRole
    {
        public string Type { get; set; }

        public string Href { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string StatusReason { get; set; }

        public TimePeriod ValidFor { get; set; }

        public RelatedParty EngagedParty { get; set; }

        public List<AccountRef> Account { get; set; }

        public List<PaymentMethodRef> PaymentMethod { get; set; }

        public List<Characteristic> Characteristic { get; set; }

        public List<ContactMedium> ContactMedium { get; set; }

        public List<CreditProfile> CreditProfile { get; set; }

        public List<AgreementRef> Agreement { get; set; }

        public List<RelatedParty> RelatedParty { get; set; }
    }
}
