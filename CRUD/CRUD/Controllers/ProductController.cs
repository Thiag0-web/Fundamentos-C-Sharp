using CRUD.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // api/product
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        // api/product/1
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound("Produto não encontrado!");

            return Ok(product);

        }

        // api/product
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequestDTO product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
                return BadRequest("O nome do produto é obrigatório.");

            var userExists = await _context.Users.AnyAsync(p => p.Id == product.UserId);

            if (!userExists)
                return NotFound("Usuário não encontrado!");

            var newProduct = new Product
            {       
                UserId = product.UserId,
                Name = product.Name,
                Price = product.Price
            };

            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();

            return Created();
        }

        [HttpDelete("{id:int}")] 

        public async Task<IActionResult> Deletar(int id) 
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound("Produto não encontrado!");

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id:Guid}")] // Rota: api/product/1
        public async Task<IActionResult> Atualizar([FromRoute] Guid id, [FromBody] Product produtoAtualizado)
        {
            // Validação de segurança: o ID da URL deve ser o mesmo do JSON
            if (id != produtoAtualizado.Id)
                return BadRequest("O ID da URL não coincide com o ID do corpo da requisição.");

            var produtoExistente = await _context.Products.AnyAsync(p => p.Id == id);

            if (!produtoExistente)
                return NotFound("Produto não encontrado!");

            // Atualiza as propriedades
            _context.Entry(produtoAtualizado).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
