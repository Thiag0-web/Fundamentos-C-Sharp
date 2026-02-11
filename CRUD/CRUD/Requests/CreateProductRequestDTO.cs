namespace CRUD.Requests
{
    public class CreateProductRequestDTO
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
