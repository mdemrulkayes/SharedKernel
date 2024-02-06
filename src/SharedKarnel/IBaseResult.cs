namespace SharedKarnel;
public interface IBaseResult
{
    public bool IsSuccess { get; }
    public Error Error { get; }
    public List<Error>? Errors { get; }
}
