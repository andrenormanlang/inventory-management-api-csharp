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

        // GET: api/products
        [HttpGet]
public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
{
    // Include both Category and Supplier relationships and map to ProductDto
    var products = await _context.Products
        .Include(p => p.Category)
        .Include(p => p.Supplier)
        .Select(p => new Product
        {
            ProductId = p.ProductId,
            Name = p.Name,
            Price = p.Price,
            Quantity = p.Quantity,
            CategoryId = p.CategoryId,
            SupplierId = p.SupplierId,
            // You can extend DTOs with extra details, such as category or supplier names if needed.
            CategoryName = p.Category.Name,
            SupplierName = p.Supplier.Name
        })
        .ToListAsync();

    return Ok(products);
}

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            // Include both Category and Supplier relationships and map to ProductDto
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .Select(p => new Product
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
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
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(ProductDto productDto)
        {
            // Fetch the Category and Supplier based on the provided IDs
            var category = await _context.Categories.FindAsync(productDto.CategoryId);
            var supplier = await _context.Suppliers.FindAsync(productDto.SupplierId);

            if (category == null)
            {
                return BadRequest("Invalid Category ID");
            }

            if (supplier == null)
            {
                return BadRequest("Invalid Supplier ID");
            }

            // Map DTO to Product entity
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Quantity = productDto.Quantity,
                CategoryId = productDto.CategoryId,
                SupplierId = productDto.SupplierId,
                Category = category,
                Supplier = supplier
            };

            // Add the product and save changes
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }

        // POST: api/products/bulk
        [HttpPost("bulk")]
        public async Task<ActionResult<IEnumerable<Product>>> PostProductsInBulk(IEnumerable<ProductDto> productDtos)
        {
            var products = new List<Product>();

            foreach (var productDto in productDtos)
            {
                // Fetch the Category and Supplier based on the provided IDs
                var category = await _context.Categories.FindAsync(productDto.CategoryId);
                var supplier = await _context.Suppliers.FindAsync(productDto.SupplierId);

                if (category == null)
                {
                    return BadRequest($"Invalid Category ID: {productDto.CategoryId}");
                }

                if (supplier == null)
                {
                    return BadRequest($"Invalid Supplier ID: {productDto.SupplierId}");
                }

                // Map DTO to Product entity
                var product = new Product
                {
                    Name = productDto.Name,
                    Price = productDto.Price,
                    Quantity = productDto.Quantity,
                    CategoryId = productDto.CategoryId,
                    SupplierId = productDto.SupplierId,
                    Category = category,
                    Supplier = supplier
                };

                products.Add(product);
            }

            // Add the products and save changes in one transaction
            _context.Products.AddRange(products);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducts), products);
        }



        // PUT: api/products/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductDto productDto)
        {
            if (id != productDto.ProductId)
            {
                return BadRequest();
            }

            // Fetch the Category and Supplier based on the provided IDs
            var category = await _context.Categories.FindAsync(productDto.CategoryId);
            var supplier = await _context.Suppliers.FindAsync(productDto.SupplierId);

            if (category == null)
            {
                return BadRequest("Invalid Category ID");
            }

            if (supplier == null)
            {
                return BadRequest("Invalid Supplier ID");
            }

            // Find the existing product
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            // Update product fields
            product.Name = productDto.Name;
            product.Price = productDto.Price;
            product.Quantity = productDto.Quantity;
            product.CategoryId = productDto.CategoryId;
            product.SupplierId = productDto.SupplierId;

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(p => p.ProductId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
