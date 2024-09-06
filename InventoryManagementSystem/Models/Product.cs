namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty; // Default empty string
        public double Price { get; set; } = 0.0; // Default price
        public int Quantity { get; set; } = 0; // Default quantity
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category(); // Assuming default needed
    }


}
