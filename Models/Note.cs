namespace NotelyRestApi.Models
{
    public class Note
    {
        public long Id { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Details { get; set; } =string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }

    }
}
