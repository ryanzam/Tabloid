using WebJournal.Model;

namespace WebJournal.DTOs
{
    public class PostupdateDTO : BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
