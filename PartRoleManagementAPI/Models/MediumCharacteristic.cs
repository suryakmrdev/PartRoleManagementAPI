namespace PartyRoleManagementAPI.Models
{ 

    public partial class MediumCharacteristic 
    {
        public string Id { get; set; }

        public string ContactMediumId { get; set; }
        public string City { get; set; }

        public string Country { get; set; }


        public string EmailAddress { get; set; }


        public string FaxNumber { get; set; }

        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }

        public string StateOrProvince { get; set; }
        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string Type { get; set; }

    }
}
