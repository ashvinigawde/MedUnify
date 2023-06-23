namespace MedUnify.WebApi.Data.Entities
{
    public class Patient : BaseEntity
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string State { get; set; } = default!;
        public string City { get; set; } = default!;
        public long? OrganizationId { get; set; }

        public Organization? Organization { get; set; }
    }
}
