using API.Entities.Emuns;

namespace API.Entities.ViewModels
{
    public class NewsViewModel
    {
        public string Title { get; set; }
        public string Hat { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string Tags { get; set; }
        public Status Status { get; set; }

    }
}