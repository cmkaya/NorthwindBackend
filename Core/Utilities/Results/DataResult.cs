namespace Core.Utilities.Results;

public abstract class DataResult<T> : Result, IDataResult<T>
{
    public T Data { get; }
    
    protected DataResult(bool success, T data) : base(success)
    {
        Data = data;
    }

    protected DataResult(bool success, string message, T data) : base(success, message)
    {
        Data = data;
    }
}