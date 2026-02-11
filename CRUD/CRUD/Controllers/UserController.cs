using CRUD.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(AppDbContext context) : ControllerBase

    {
        private readonly AppDbContext _context = context;

        // api/user
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        // api/user/1
        [HttpGet("{id:guid}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound("Usuário não encontrado!");
            return Ok(user);
        }

        // api/user
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserRequestDTO user)
        {
            if (string.IsNullOrWhiteSpace(user.Name))
                return BadRequest("O nome do usuário é obrigatório.");
            var newUser = new User
            {
                Name = user.Name,
                Email = user.Email,
                PasswordHash = user.PasswordHash

            };
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return Created();
        }

        // api/user/delete
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound("Usuário não encontrado!");
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id:Guid}")]

        public async Task<IActionResult> Atualizar([FromRoute] Guid id, [FromBody] User userAtualizado)
        {
            var userExistente = await _context.Users.FindAsync(id);
            if (userExistente == null)
                return NotFound("Usuário não encontrado!");
            if (string.IsNullOrWhiteSpace(userAtualizado.Name))
                return BadRequest("O nome do usuário é obrigatório.");
            userExistente.Name = userAtualizado.Name;
            userExistente.Email = userAtualizado.Email;
            userExistente.PasswordHash = userAtualizado.PasswordHash;
            _context.Users.Update(userExistente);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
