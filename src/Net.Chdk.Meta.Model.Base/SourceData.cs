namespace Net.Chdk.Meta.Model
{
    public abstract class SourceData<TSource>
        where TSource : SourceData<TSource>
    {
        public string Platform { get; set; }
        public string Revision { get; set; }
    }
}
