using Utils.ResultType.Fail;
using Utils.ResultType.Status;

namespace Utils.ResultType.Data
{
    public class ResultData<T>
    {
        public readonly ResultStatus Status;
        public readonly ErrorCode ErrorCode;
        private readonly T? _value;

        public ResultData(ResultStatus status, ErrorCode? errorCode = null, T? value = default)
        {
            Status = status;
            ErrorCode = errorCode == null ? ErrorCode.None : errorCode.Value; 
            _value = value;
        }

        public T GetValue()
        {
            if (Status == ResultStatus.Fail)
            {
                throw new InvalidOperationException("No Data with Status == Fail");
            }

            if (_value == null)
            {
                throw new InvalidOperationException(message: "Data is Null");
            }

            return _value!;
        }
    }
}