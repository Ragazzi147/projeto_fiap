
using API.Entities.Emuns;

namespace API.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public int Deleted { get; protected set; }
        public string CreatedBy { get; set; }
        public string Tags { get; set; }
        public DateTime PublishDate { get; set; }
        public Status Status { get; set; }
    }
}
