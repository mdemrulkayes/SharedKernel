namespace SharedKarnel;
public class BaseAuditableEntity<TKey> :
    BaseEntity,
    ICreatedAuditEntity<TKey>,
    IModifiedAuditEntity<TKey>
    where TKey : struct
{
    public TKey CreatedBy { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public TKey? UpdatedBy { get; set; }
    public DateTimeOffset? UpdatedDate { get; set; }
}
