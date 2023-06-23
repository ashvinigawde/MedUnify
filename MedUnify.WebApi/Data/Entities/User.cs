namespace MedUnify.WebApi.Data.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string ClientId { get; set; } = "";
    }
}
