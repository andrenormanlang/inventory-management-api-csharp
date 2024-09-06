namespace InventoryManagementSystem.Models
{
    public class Supplier
    {
        // Declare properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        // Parameterless constructor for Entity Framework
        public Supplier() { }

        // Constructor to initialize properties
        public Supplier(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
