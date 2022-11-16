namespace Base.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult
    {
        T Result { get; }
    }
}
