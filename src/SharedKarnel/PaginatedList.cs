using Microsoft.EntityFrameworkCore;

namespace SharedKarnel;
public sealed class PaginatedList<T>
{
    public IReadOnlyCollection<T> Items { get; }
    public int TotalPages { get; }
    public int PageNumber { get; }
    public int TotalCount { get; }

    public bool HasPreviousPage => PageNumber > 1;
    public bool HasNextPage => PageNumber < TotalPages;

    private PaginatedList(IReadOnlyCollection<T> items, int count, int pageNumber, int pageSize)
    {
        Items = items;
        PageNumber = pageNumber;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        TotalCount = count;
    }

    public static async Task<PaginatedList<T>> CreatePaginatedListAsync(IQueryable<T> source, int pageNumber, int pageSize, CancellationToken cancellationToken = default)
    {
        var count = await source.CountAsync(cancellationToken);
        var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken);

        return new PaginatedList<T>(items, count, pageNumber, pageSize);
    }

}
