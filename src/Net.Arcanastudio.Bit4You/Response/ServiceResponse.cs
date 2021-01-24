namespace Bit4You.Net.Response
{
    internal class ServiceResponse<T>
    {
        public bool IsError { get; }
        public string ErrorMessage { get; }
        public T Data { get; }

        public ServiceResponse(T data)
        {
            Data = data;
        }

        public ServiceResponse(string errorMessage)
        {
            ErrorMessage = errorMessage;
            IsError = true;
        }
    }
}
