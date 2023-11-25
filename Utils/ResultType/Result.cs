using Utils.ResultType.Data;
using Utils.ResultType.Fail;
using Utils.ResultType.Status;

namespace Utils.ResultType
{
    public static class Result
    {
        public static ResultData<T> Ok<T>(T value)
        {
            return new ResultData<T>(
                status: ResultStatus.Ok,
                value: value
            );
        }

        public static ResultData<T> Fail<T>(ErrorCode errorCode)
        {
            return new ResultData<T>(
                status: ResultStatus.Fail,
                errorCode: errorCode,
                value: default(T)
            );
        }
    }
}