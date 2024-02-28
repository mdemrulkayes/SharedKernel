namespace SharedKernel;
public class BaseAuditableEntity:
    BaseEntity
{
    public Guid CreatedBy { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public Guid? UpdatedBy { get; set; }
    public DateTimeOffset? UpdatedDate { get; set; }
}
