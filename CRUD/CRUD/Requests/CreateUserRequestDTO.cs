namespace CRUD.Requests
{
    public class CreateUserRequestDTO
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } 


    }
}
