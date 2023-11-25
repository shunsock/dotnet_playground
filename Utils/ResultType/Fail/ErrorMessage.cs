namespace Utils.ResultType.Fail
{
    public static class ErrorMessage
    {
        public static string Show(ErrorCode code)
        {
            return code switch
            {
                ErrorCode.BadRequest => "Failed!: Bad Request",
                ErrorCode.Unauthorized => "Failed!: Unauthorized",
                ErrorCode.Forbidden => "Failed!: Forbidden",
                ErrorCode.NotFound => "Failed!: Not Found",
                ErrorCode.None => throw new InvalidOperationException(message: "ErrorCode is None"),
                _ => throw new ArgumentException(message: "Unknown ErrorCode")
            };
        }
    }
}
