namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; } = string.Empty;  // Add description property

        // Foreign key to Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string CategoryName { get; set; }

        // Foreign key to Supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public string SupplierName { get; set; }
    }
}



