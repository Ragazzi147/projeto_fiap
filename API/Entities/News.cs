namespace API.Entities
{
    public class News : BaseEntity
    {

        public News(string title, string hat, string description, string createdBy, string tags)
        {
            Id = Guid.NewGuid().ToString();
            PublishDate = DateTime.Now;

            Title = title;
            Hat = hat;
            Description = description;
            CreatedBy = createdBy;
            Tags = tags;
        }

        #region [Propriedades]
        public string Title { get; private set; }
        public string Hat { get; private set; }
        public string Description { get; private set; }
        #endregion

        #region [Methods]
        public void Delete() => Deleted = 1;
        #endregion

    }
}
