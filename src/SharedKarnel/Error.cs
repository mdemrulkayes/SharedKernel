namespace SharedKarnel;
public sealed record Error (string ErrorCode, string Message, ErrorType ErrorType)
{
    public static readonly Error None = new(string.Empty, string.Empty, ErrorType.None);

    public static Error Failure(
        string code = "Core.Failure",
        string description = "A failure has occurred.") =>
        new(code, description, ErrorType.Failure);

    public static Error Unexpected(
        string code = "Core.Unexpected",
        string description = "An unexpected error has occurred.") =>
        new(code, description, ErrorType.Unexpected);

    public static Error Validation(
        string code = "Core.Validation",
        string description = "A validation error has occurred.") =>
        new(code, description, ErrorType.Validation);

    public static Error Conflict(
        string code = "Core.Conflict",
        string description = "A conflict error has occurred.") =>
        new(code, description , ErrorType.Conflict);

    public static Error NotFound(
        string code = "Core.NotFound",
        string description = "A 'Not Found' error has occurred.") =>
        new(code, description, ErrorType.NotFound);

    public static Error Unauthorized(
        string code = "Core.Unauthorized",
        string description = "An 'Unauthorized' error has occurred.") =>
        new(code, description, ErrorType.Unauthorized);

    public static Error Custom(
        string code = "Core.Custom",
        string description = "A custom error has occurred.") =>
        new(code, description, ErrorType.Custom);
}
