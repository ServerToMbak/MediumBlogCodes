namespace UOWAndGenericRepoısitory.Entities
{
    public class Product : BaseEntity
    {
        public required string Name { get; set; }
        public double Price { get; set; }
    }
}
