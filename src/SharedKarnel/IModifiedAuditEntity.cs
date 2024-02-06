namespace SharedKarnel;

internal interface IModifiedAuditEntity<TKey>
    where TKey : struct
{
    /// <summary>
    /// Modified by property gets or sets
    /// </summary>
    TKey? UpdatedBy { get; set; }

    /// <summary>
    /// Modified Date property gets or sets
    /// </summary>
    DateTimeOffset? UpdatedDate { get; set; }
}
