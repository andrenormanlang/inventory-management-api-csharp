namespace InventoryManagementSystem.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        // Navigation property to list products
        public List<Product> Products { get; set; } = new List<Product>();

        public Supplier() { }

        public Supplier(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
