namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string messaage = null, string details = null) : base(statusCode, messaage)
        {
            Details = details;
        }

        public string Details { get; set; }
    }
}