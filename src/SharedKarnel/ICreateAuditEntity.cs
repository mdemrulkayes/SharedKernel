namespace SharedKarnel;

internal interface ICreateAuditEntity<TKey>
    where TKey : struct
{
    /// <summary>
    /// Created By property get or set
    /// </summary>
    TKey CreateBy { get; set; }

    /// <summary>
    /// Created Date property get or set
    /// </summary>
    DateTimeOffset CreateDate { get; set; }
}
