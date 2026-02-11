namespace CRUD
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public Guid UserId { get; set; } // Foreign key to User

        // Navigation property to related User
        public virtual User User { get; set; } = null!;
    }
}
