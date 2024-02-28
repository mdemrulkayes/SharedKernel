
namespace SharedKernel.Infrastructure;
internal sealed class TimeProvider : ITimeProvider
{
    public DateTimeOffset TimeNow => DateTimeOffset.UtcNow;
}
