namespace MedUnify.WebApp.Models;

public class EntityModel
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public long? CreatedById { get; set; }
    public long? UpdatedById { get; set; }
    public long? DeletedById { get; set; }

}
