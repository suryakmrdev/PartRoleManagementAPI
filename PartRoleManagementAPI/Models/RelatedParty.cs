namespace PartyRoleManagementAPI.Models
{ 

    public partial class RelatedParty
    {
        public string Id { get; set; }
        public string Href { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string BaseType { get; set; } = string.Empty;
        public string SchemaLocation { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string ReferredType { get; set; } = string.Empty;
    }
}
