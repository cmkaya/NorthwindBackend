namespace Core.Utilities.Results;

public abstract class Result : IResult
{
    public bool Success { get; }
    public string Message { get; }
    
    protected Result(bool success)
    {
        Success = success;
    }

    protected Result(bool success, string message) : this(success)
    {
        Message = message;
    }
}