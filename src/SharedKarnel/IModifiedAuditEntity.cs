namespace SharedKarnel;

internal interface IModifiedAuditEntity<TKey>
    where TKey : struct
{
    /// <summary>
    /// Modified by property gets or sets
    /// </summary>
    TKey? ModifiedBy { get; set; }

    /// <summary>
    /// Modified Date property gets or sets
    /// </summary>
    DateTimeOffset? ModifiedDate { get; set; }
}
