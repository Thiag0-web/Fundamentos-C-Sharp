namespace CRUD
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;

        // Navigation property for related products
        public ICollection<Product> Products { get; set; } = [];
    }
}
