namespace Services.ResponseService
{
    public class ResponseService<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
        public bool Status { get; set; }
    }
}