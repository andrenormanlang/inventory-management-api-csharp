namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;  // Ensures that Name is required
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Foreign key to Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }  // Required Category
        public string CategoryName { get; set; }  // Add CategoryName


        // Foreign key to Supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }  // Required Supplier
        public string SupplierName { get; set; }  // Add SupplierName

    }
}


