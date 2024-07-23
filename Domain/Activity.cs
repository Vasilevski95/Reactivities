namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}

/*
They all need to be public, so that entity framework can see them
They need get and set to get the value and set the value of each of this properties inside this class
Earlier we had to write queries to database, but with ORM - Object relational mappers, we dont need that
*/