namespace Application.Wrappers;

public record class Result<T>
{
    internal Result(T data, bool result, string message)
    {
        Succeeded = result;
        Data = data;
        Message = message;
    }

    internal Result(string message)
    {
        Succeeded = false;
        Message = message;
    }

    public static Result<T> Failure(string message)
    {
        return new Result<T>(message);
    }

    public static Result<T> Failure(T errors)
    {
        return new Result<T>(errors, false, "Failure");
    }

    public static Result<T> Success(T data, string message = default)
    {
        return new Result<T>(data, true, message);
    }

    public bool Succeeded { get; init; }
    public string? Message { get; init; }
    public T? Data { get; init; }
}
