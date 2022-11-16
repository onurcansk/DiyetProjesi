namespace Base.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T result) : base(result, false)
        {
        }

        public ErrorDataResult(T result, string message) : base(result, false, message)
        {

        }
        public ErrorDataResult(string message) : base(default(T), false, message)
        {

        }
        public ErrorDataResult() : base(default(T), false)
        {

        }
    }
}
