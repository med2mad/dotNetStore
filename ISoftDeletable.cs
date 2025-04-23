namespace dotNetStore
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }
}
