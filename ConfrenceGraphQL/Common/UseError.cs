namespace ConfrenceGraphQL.Common
{
    public class UseError
    {
        public UseError(string message, string code)
        {
            Message = message;
            Code = code;
        }

        public string Message { get; }
        public string Code { get; }
    }
}