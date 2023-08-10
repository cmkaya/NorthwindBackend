using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core.Utilities.Results;

public interface IDataResult<T> : IResult 
{
    public T Data { get; }
}