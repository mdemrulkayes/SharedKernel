namespace SharedKernel;

internal interface ICreatedAuditEntity<TKey>
    where TKey : struct
{
    /// <summary>
    /// Created By property get or set
    /// </summary>
    TKey CreatedBy { get; set; }

    /// <summary>
    /// Created Date property get or set
    /// </summary>
    DateTimeOffset CreatedDate { get; set; }
}
