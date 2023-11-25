using Utils.ResultType;
using Utils.ResultType.Status;
using Utils.ResultType.Data;
using Utils.ResultType.Fail;

namespace Utils
{
    static class Program
    {
        static void Main(string[] args)
        {
            var successfulPatternResult = Divide(1, 1);
            if (successfulPatternResult.Status == ResultStatus.Fail) return;
            Console.WriteLine(successfulPatternResult.GetValue());
            
            var failedPatternResult = Divide(1, 0);
            if (failedPatternResult.Status == ResultStatus.Ok) return;
            Console.WriteLine(ErrorMessage.Show(failedPatternResult.ErrorCode));
        }
        
        static ResultData<decimal> Divide(int a, int b)
        {
            if (b == 0)
            {
                return Result.Fail<decimal>(ErrorCode.BadRequest);
            }

            return Result.Ok<decimal>((decimal) a / b);
        }
    }
}