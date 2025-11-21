namespace MusicStoreApp.Models
{
    public class Album
    {
        public virtual int AlbumId { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Artist { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
    }
}
