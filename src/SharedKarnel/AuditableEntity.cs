namespace SharedKarnel;
public class AuditableEntity<TKey> :
    BaseEntity,
    ICreateAuditEntity<TKey>,
    IModifiedAuditEntity<TKey>
    where TKey : struct
{
    public TKey CreateBy { get; set; }
    public DateTimeOffset CreateDate { get; set; }
    public TKey? ModifiedBy { get; set; }
    public DateTimeOffset? ModifiedDate { get; set; }
}
