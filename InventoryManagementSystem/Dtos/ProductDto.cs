namespace InventoryManagementSystem.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }  // Only CategoryId is needed
        public int SupplierId { get; set; }  // Only SupplierId is needed

    }
}
