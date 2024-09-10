using Microsoft.AspNetCore.Mvc;
using InventoryManagementSystem.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.Dtos;

namespace InventoryManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/products - Retrieve all products with category and supplier names
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .Select(p => new Product
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    CategoryId = p.CategoryId,
                    SupplierId = p.SupplierId,
                    CategoryName = p.Category.Name,
                    SupplierName = p.Supplier.Name
                })
                .ToListAsync();

            return Ok(products);
        }

        // GET: api/products/{id} - Retrieve a single product by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .Select(p => new Product
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    CategoryId = p.CategoryId,
                    SupplierId = p.SupplierId,
                    CategoryName = p.Category.Name,
                    SupplierName = p.Supplier.Name
                })
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            return Ok(product);
        }

        // POST: api/products - Create a new product
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(ProductDto productDto)
        {
            var category = await _context.Categories.FindAsync(productDto.CategoryId);
            var supplier = await _context.Suppliers.FindAsync(productDto.SupplierId);

            if (category == null)
            {
                return BadRequest(new { message = $"Invalid Category ID: {productDto.CategoryId}. Category does not exist." });
            }

            if (supplier == null)
            {
                return BadRequest(new { message = $"Invalid Supplier ID: {productDto.SupplierId}. Supplier does not exist." });
            }

            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
                Quantity = productDto.Quantity,
                CategoryId = productDto.CategoryId,
                SupplierId = productDto.SupplierId
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }

        // POST: api/products/bulk - Create products in bulk
        [HttpPost("bulk")]
        public async Task<ActionResult<IEnumerable<Product>>> PostProductsInBulk(IEnumerable<ProductDto> productDtos)
        {
            var products = new List<Product>();

            foreach (var productDto in productDtos)
            {
                var category = await _context.Categories.FindAsync(productDto.CategoryId);
                var supplier = await _context.Suppliers.FindAsync(productDto.SupplierId);

                if (category == null)
                {
                    return BadRequest(new { message = $"Invalid Category ID: {productDto.CategoryId} for product: {productDto.Name}. Category does not exist." });
                }

                if (supplier == null)
                {
                    return BadRequest(new { message = $"Invalid Supplier ID: {productDto.SupplierId} for product: {productDto.Name}. Supplier does not exist." });
                }

                var product = new Product
                {
                    Name = productDto.Name,
                    Description = productDto.Description,
                    Price = productDto.Price,
                    Quantity = productDto.Quantity,
                    CategoryId = productDto.CategoryId,
                    SupplierId = productDto.SupplierId
                };

                products.Add(product);
            }

            _context.Products.AddRange(products);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducts), products);
        }

        // PUT: api/products/{id} - Update a single product
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductDto productDto)
        {
            if (id != productDto.ProductId)
            {
                return BadRequest(new { message = "Product ID mismatch." });
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            var category = await _context.Categories.FindAsync(productDto.CategoryId);
            var supplier = await _context.Suppliers.FindAsync(productDto.SupplierId);

            if (category == null)
            {
                return BadRequest(new { message = $"Invalid Category ID: {productDto.CategoryId}. Category does not exist." });
            }

            if (supplier == null)
            {
                return BadRequest(new { message = $"Invalid Supplier ID: {productDto.SupplierId}. Supplier does not exist." });
            }

            product.Name = productDto.Name;
            product.Description = productDto.Description;
            product.Price = productDto.Price;
            product.Quantity = productDto.Quantity;
            product.CategoryId = productDto.CategoryId;
            product.SupplierId = productDto.SupplierId;

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/products/{id} - Delete a product
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
