namespace PartyRoleManagementAPI.Models
{

    public partial class ContactMedium
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string BaseType { get; set; }

        public string SchemaLocation { get; set; }

        public string Type { get; set; }

        public bool? Preferred { get; set; }

        public TimePeriod ValidFor { get; set; }


        public MediumCharacteristic Characteristic { get; set; }

    }
}
