using InventoryManagementSystem.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Foreign key to Category
    public int CategoryId { get; set; }
    public Category? Category { get; set; }  // Optional Category

    // Foreign key to Supplier
    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }  // Optional Supplier
}


