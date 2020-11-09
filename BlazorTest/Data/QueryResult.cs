namespace BlazorTest.Data
{
    public class QueryResult<T>
    {
        public bool IsLoading { get; set; }
        public object[] Errors { get; set; }
        public T Data { get; set; }
    }
}