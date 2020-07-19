namespace MediaLibrary.Models
{
    public interface IMedia : IEntity
    {
        string Title { get; set; }
    }
}