namespace InventoryManagementSystem.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }  // Add description property
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
    }
}
