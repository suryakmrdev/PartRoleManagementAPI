
namespace PartyRoleManagementAPI.Models
{
    public partial class Characteristic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }

        public string Value { get; set; }

        public string ValueType { get; set; }

    }
}
