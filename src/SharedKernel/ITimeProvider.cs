namespace SharedKernel;
public interface ITimeProvider
{
    DateTimeOffset TimeNow { get; }
}
