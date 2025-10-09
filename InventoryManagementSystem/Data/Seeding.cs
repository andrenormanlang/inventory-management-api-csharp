using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data
{
    public static class Seeding
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            // Seed Categories
            var categories = new[]
            {
                new Category { CategoryId = 1, Name = "Smartphones" },
                new Category { CategoryId = 2, Name = "Laptops & Computers" },
                new Category { CategoryId = 3, Name = "Tablets" },
                new Category { CategoryId = 4, Name = "Audio & Headphones" },
                new Category { CategoryId = 5, Name = "Gaming" },
                new Category { CategoryId = 6, Name = "Smart Home" },
                new Category { CategoryId = 7, Name = "Wearables" },
                new Category { CategoryId = 8, Name = "Cameras" },
                new Category { CategoryId = 9, Name = "TVs & Displays" },
                new Category { CategoryId = 10, Name = "Accessories" },
                new Category { CategoryId = 11, Name = "Storage" },
                new Category { CategoryId = 12, Name = "Networking" }
            };

            // Seed Suppliers
            var suppliers = new[]
            {
                new Supplier { Id = 1, Name = "Apple Inc.", Address = "One Apple Park Way, Cupertino, CA 95014", Phone = "+1-408-996-1010" },
                new Supplier { Id = 2, Name = "Samsung Electronics", Address = "1321 Upland Dr, Houston, TX 77043", Phone = "+1-800-726-7864" },
                new Supplier { Id = 3, Name = "Dell Technologies", Address = "One Dell Way, Round Rock, TX 78682", Phone = "+1-800-915-3355" },
                new Supplier { Id = 4, Name = "HP Inc.", Address = "1501 Page Mill Rd, Palo Alto, CA 94304", Phone = "+1-650-857-1501" },
                new Supplier { Id = 5, Name = "Sony Electronics", Address = "16535 Via Esprillo, San Diego, CA 92127", Phone = "+1-800-222-7669" },
                new Supplier { Id = 6, Name = "LG Electronics USA", Address = "1000 Sylvan Ave, Englewood Cliffs, NJ 07632", Phone = "+1-800-243-0000" },
                new Supplier { Id = 7, Name = "Microsoft Corporation", Address = "One Microsoft Way, Redmond, WA 98052", Phone = "+1-425-882-8080" },
                new Supplier { Id = 8, Name = "Google LLC", Address = "1600 Amphitheatre Pkwy, Mountain View, CA 94043", Phone = "+1-650-253-0000" },
                new Supplier { Id = 9, Name = "Lenovo Group", Address = "8001 Development Dr, Morrisville, NC 27560", Phone = "+1-855-253-6686" },
                new Supplier { Id = 10, Name = "ASUS Computer", Address = "800 Corporate Way, Fremont, CA 94539", Phone = "+1-510-739-3777" },
                new Supplier { Id = 11, Name = "AMD Inc.", Address = "2485 Augustine Dr, Santa Clara, CA 95054", Phone = "+1-877-284-1566" },
                new Supplier { Id = 12, Name = "NVIDIA Corporation", Address = "2788 San Tomas Expressway, Santa Clara, CA 95051", Phone = "+1-408-486-2000" },
                new Supplier { Id = 13, Name = "Logitech International", Address = "7700 Gateway Blvd, Newark, CA 94560", Phone = "+1-646-454-3200" },
                new Supplier { Id = 14, Name = "Razer Inc.", Address = "1 Fusionopolis View, Singapore 138577", Phone = "+65-6532-4250" },
                new Supplier { Id = 15, Name = "JBL/Harman International", Address = "8500 Balboa Blvd, Northridge, CA 91329", Phone = "+1-818-893-8411" }
            };

            // Seed Products
            var products = new[]
            {
                // Smartphones
                new Product { ProductId = 1, Name = "iPhone 15 Pro Max", Price = 1199.99, Quantity = 25, Description = "Latest Apple flagship with titanium design, A17 Pro chip, and advanced camera system", CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 2, Name = "iPhone 15", Price = 799.99, Quantity = 45, Description = "New iPhone with USB-C, Dynamic Island, and improved cameras", CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 3, Name = "Samsung Galaxy S24 Ultra", Price = 1299.99, Quantity = 30, Description = "Premium Android flagship with S Pen, 200MP camera, and AI features", CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 4, Name = "Samsung Galaxy S24", Price = 799.99, Quantity = 40, Description = "High-end Android phone with Galaxy AI and improved performance", CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 5, Name = "Google Pixel 8 Pro", Price = 999.99, Quantity = 20, Description = "Google's flagship with advanced computational photography and AI", CategoryId = 1, SupplierId = 8 },

                // Laptops & Computers
                new Product { ProductId = 6, Name = "MacBook Pro 16-inch M3 Max", Price = 3999.99, Quantity = 15, Description = "Professional laptop with M3 Max chip for demanding workloads", CategoryId = 2, SupplierId = 1 },
                new Product { ProductId = 7, Name = "MacBook Air 15-inch M3", Price = 1299.99, Quantity = 35, Description = "Thin and light laptop with M3 chip and 15-inch display", CategoryId = 2, SupplierId = 1 },
                new Product { ProductId = 8, Name = "Dell XPS 13 Plus", Price = 1199.99, Quantity = 25, Description = "Premium Windows ultrabook with 12th Gen Intel processors", CategoryId = 2, SupplierId = 3 },
                new Product { ProductId = 9, Name = "HP Spectre x360 14", Price = 1149.99, Quantity = 20, Description = "Convertible laptop with OLED display and premium build quality", CategoryId = 2, SupplierId = 4 },
                new Product { ProductId = 10, Name = "Lenovo ThinkPad X1 Carbon Gen 11", Price = 1599.99, Quantity = 18, Description = "Business laptop with legendary keyboard and durability", CategoryId = 2, SupplierId = 9 },
                new Product { ProductId = 11, Name = "ASUS ROG Zephyrus G16", Price = 2499.99, Quantity = 12, Description = "Gaming laptop with RTX 4070 and high refresh OLED display", CategoryId = 2, SupplierId = 10 },

                // Tablets
                new Product { ProductId = 12, Name = "iPad Pro 12.9-inch M2", Price = 1099.99, Quantity = 22, Description = "Professional tablet with M2 chip and Liquid Retina XDR display", CategoryId = 3, SupplierId = 1 },
                new Product { ProductId = 13, Name = "iPad Air 5th Gen", Price = 599.99, Quantity = 35, Description = "Versatile tablet with M1 chip and 10.9-inch display", CategoryId = 3, SupplierId = 1 },
                new Product { ProductId = 14, Name = "Samsung Galaxy Tab S9 Ultra", Price = 1199.99, Quantity = 15, Description = "Large Android tablet with S Pen and desktop-like experience", CategoryId = 3, SupplierId = 2 },
                new Product { ProductId = 15, Name = "Microsoft Surface Pro 9", Price = 999.99, Quantity = 20, Description = "2-in-1 tablet with full Windows experience", CategoryId = 3, SupplierId = 7 },

                // Audio & Headphones
                new Product { ProductId = 16, Name = "AirPods Pro 2nd Gen", Price = 249.99, Quantity = 60, Description = "Premium wireless earbuds with active noise cancellation", CategoryId = 4, SupplierId = 1 },
                new Product { ProductId = 17, Name = "Sony WH-1000XM5", Price = 399.99, Quantity = 25, Description = "Industry-leading noise canceling wireless headphones", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 18, Name = "JBL Charge 5", Price = 179.99, Quantity = 40, Description = "Portable Bluetooth speaker with powerbank feature", CategoryId = 4, SupplierId = 15 },
                new Product { ProductId = 19, Name = "Samsung Galaxy Buds2 Pro", Price = 229.99, Quantity = 35, Description = "Premium wireless earbuds with 360 Audio", CategoryId = 4, SupplierId = 2 },

                // Gaming
                new Product { ProductId = 20, Name = "PlayStation 5", Price = 499.99, Quantity = 8, Description = "Next-gen gaming console with ultra-fast SSD", CategoryId = 5, SupplierId = 5 },
                new Product { ProductId = 21, Name = "Xbox Series X", Price = 499.99, Quantity = 10, Description = "Most powerful Xbox console with 4K gaming", CategoryId = 5, SupplierId = 7 },
                new Product { ProductId = 22, Name = "Nintendo Switch OLED", Price = 349.99, Quantity = 25, Description = "Hybrid console with vibrant OLED screen", CategoryId = 5, SupplierId = 8 },
                new Product { ProductId = 23, Name = "Razer DeathAdder V3 Pro", Price = 149.99, Quantity = 30, Description = "Wireless gaming mouse with Focus Pro sensor", CategoryId = 5, SupplierId = 14 },
                new Product { ProductId = 24, Name = "Logitech G Pro X Superlight 2", Price = 159.99, Quantity = 28, Description = "Ultra-lightweight wireless gaming mouse", CategoryId = 5, SupplierId = 13 },

                // Smart Home
                new Product { ProductId = 25, Name = "Google Nest Hub Max", Price = 229.99, Quantity = 20, Description = "Smart display with Google Assistant and video calls", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 26, Name = "Amazon Echo Studio", Price = 199.99, Quantity = 18, Description = "High-fidelity smart speaker with 3D audio", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 27, Name = "Apple HomePod mini", Price = 99.99, Quantity = 35, Description = "Compact smart speaker with Siri", CategoryId = 6, SupplierId = 1 },

                // Wearables
                new Product { ProductId = 28, Name = "Apple Watch Series 9", Price = 399.99, Quantity = 40, Description = "Advanced smartwatch with health monitoring", CategoryId = 7, SupplierId = 1 },
                new Product { ProductId = 29, Name = "Samsung Galaxy Watch6", Price = 329.99, Quantity = 25, Description = "Android smartwatch with comprehensive health tracking", CategoryId = 7, SupplierId = 2 },
                new Product { ProductId = 30, Name = "Google Pixel Watch 2", Price = 349.99, Quantity = 20, Description = "Wear OS smartwatch with Fitbit integration", CategoryId = 7, SupplierId = 8 },

                // Cameras
                new Product { ProductId = 31, Name = "Sony α7R V", Price = 3899.99, Quantity = 5, Description = "High-resolution mirrorless camera for professionals", CategoryId = 8, SupplierId = 5 },
                new Product { ProductId = 32, Name = "Sony α7 IV", Price = 2499.99, Quantity = 8, Description = "Versatile full-frame mirrorless camera", CategoryId = 8, SupplierId = 5 },
                new Product { ProductId = 33, Name = "GoPro Hero 12 Black", Price = 399.99, Quantity = 15, Description = "Action camera with 5.3K video recording", CategoryId = 8, SupplierId = 8 },

                // TVs & Displays
                new Product { ProductId = 34, Name = "Samsung QN90C Neo QLED 65\"", Price = 2299.99, Quantity = 8, Description = "Premium 4K QLED TV with Mini LED backlight", CategoryId = 9, SupplierId = 2 },
                new Product { ProductId = 35, Name = "LG C3 OLED 55\"", Price = 1499.99, Quantity = 12, Description = "OLED TV with perfect blacks and gaming features", CategoryId = 9, SupplierId = 6 },
                new Product { ProductId = 36, Name = "Sony X90L 65\"", Price = 1199.99, Quantity = 10, Description = "LED TV with full-array local dimming", CategoryId = 9, SupplierId = 5 },

                // Accessories
                new Product { ProductId = 37, Name = "MagSafe Charger", Price = 39.99, Quantity = 80, Description = "Wireless charging pad for iPhone with MagSafe", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 38, Name = "Anker PowerCore 10000", Price = 29.99, Quantity = 100, Description = "Compact portable battery pack", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 39, Name = "Apple Magic Keyboard", Price = 179.99, Quantity = 25, Description = "Wireless keyboard for Mac with Touch ID", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 40, Name = "Logitech MX Master 3S", Price = 99.99, Quantity = 35, Description = "Advanced wireless mouse for productivity", CategoryId = 10, SupplierId = 13 },

                // Storage
                new Product { ProductId = 41, Name = "Samsung T7 Shield 2TB", Price = 199.99, Quantity = 30, Description = "Rugged portable SSD with fast transfer speeds", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 42, Name = "WD Black SN850X 1TB", Price = 99.99, Quantity = 25, Description = "High-performance NVMe SSD for gaming", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 43, Name = "Seagate Backup Plus 5TB", Price = 129.99, Quantity = 20, Description = "External hard drive for backup and storage", CategoryId = 11, SupplierId = 2 },

                // Networking
                new Product { ProductId = 44, Name = "ASUS AX6000 WiFi 6 Router", Price = 349.99, Quantity = 15, Description = "High-performance WiFi 6 router for large homes", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 45, Name = "TP-Link Deco X75 Mesh", Price = 299.99, Quantity = 12, Description = "Whole-home mesh WiFi 6 system", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 46, Name = "Netgear Nighthawk AX12", Price = 399.99, Quantity = 10, Description = "12-stream WiFi 6 router with multi-gig speeds", CategoryId = 12, SupplierId = 10 }
            };

            // Configure the entities
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Supplier>().HasData(suppliers);
            modelBuilder.Entity<Product>().HasData(products);
        }

        /// <summary>
        /// Alternative method to seed data at runtime (use this in Program.cs if preferred)
        /// </summary>
        public static async Task SeedDataAsync(AppDbContext context)
        {
            // Check if data already exists
            if (await context.Categories.AnyAsync()) return;

            // Add Categories
            var categories = new List<Category>
            {
                new Category { Name = "Smartphones" },
                new Category { Name = "Laptops & Computers" },
                new Category { Name = "Tablets" },
                new Category { Name = "Audio & Headphones" },
                new Category { Name = "Gaming" },
                new Category { Name = "Smart Home" },
                new Category { Name = "Wearables" },
                new Category { Name = "Cameras" },
                new Category { Name = "TVs & Displays" },
                new Category { Name = "Accessories" },
                new Category { Name = "Storage" },
                new Category { Name = "Networking" }
            };

            await context.Categories.AddRangeAsync(categories);
            await context.SaveChangesAsync();

            // Add Suppliers
            var suppliers = new List<Supplier>
            {
                new Supplier("Apple Inc.", "One Apple Park Way, Cupertino, CA 95014", "+1-408-996-1010"),
                new Supplier("Samsung Electronics", "1321 Upland Dr, Houston, TX 77043", "+1-800-726-7864"),
                new Supplier("Dell Technologies", "One Dell Way, Round Rock, TX 78682", "+1-800-915-3355"),
                new Supplier("HP Inc.", "1501 Page Mill Rd, Palo Alto, CA 94304", "+1-650-857-1501"),
                new Supplier("Sony Electronics", "16535 Via Esprillo, San Diego, CA 92127", "+1-800-222-7669"),
                new Supplier("LG Electronics USA", "1000 Sylvan Ave, Englewood Cliffs, NJ 07632", "+1-800-243-0000"),
                new Supplier("Microsoft Corporation", "One Microsoft Way, Redmond, WA 98052", "+1-425-882-8080"),
                new Supplier("Google LLC", "1600 Amphitheatre Pkwy, Mountain View, CA 94043", "+1-650-253-0000"),
                new Supplier("Lenovo Group", "8001 Development Dr, Morrisville, NC 27560", "+1-855-253-6686"),
                new Supplier("ASUS Computer", "800 Corporate Way, Fremont, CA 94539", "+1-510-739-3777"),
                new Supplier("AMD Inc.", "2485 Augustine Dr, Santa Clara, CA 95054", "+1-877-284-1566"),
                new Supplier("NVIDIA Corporation", "2788 San Tomas Expressway, Santa Clara, CA 95051", "+1-408-486-2000"),
                new Supplier("Logitech International", "7700 Gateway Blvd, Newark, CA 94560", "+1-646-454-3200"),
                new Supplier("Razer Inc.", "1 Fusionopolis View, Singapore 138577", "+65-6532-4250"),
                new Supplier("JBL/Harman International", "8500 Balboa Blvd, Northridge, CA 91329", "+1-818-893-8411")
            };

            await context.Suppliers.AddRangeAsync(suppliers);
            await context.SaveChangesAsync();

            // Refresh categories and suppliers with their IDs
            var categoryList = await context.Categories.ToListAsync();
            var supplierList = await context.Suppliers.ToListAsync();

            // Add a sample of products with proper foreign keys
            var products = new List<Product>
            {
                // Smartphones
                new Product { Name = "iPhone 15 Pro Max", Price = 1199.99, Quantity = 25, Description = "Latest Apple flagship with titanium design, A17 Pro chip, and advanced camera system", CategoryId = categoryList.First(c => c.Name == "Smartphones").CategoryId, SupplierId = supplierList.First(s => s.Name == "Apple Inc.").Id },
                new Product { Name = "Samsung Galaxy S24 Ultra", Price = 1299.99, Quantity = 30, Description = "Premium Android flagship with S Pen, 200MP camera, and AI features", CategoryId = categoryList.First(c => c.Name == "Smartphones").CategoryId, SupplierId = supplierList.First(s => s.Name == "Samsung Electronics").Id },
                
                // Laptops
                new Product { Name = "MacBook Pro 16-inch M3 Max", Price = 3999.99, Quantity = 15, Description = "Professional laptop with M3 Max chip for demanding workloads", CategoryId = categoryList.First(c => c.Name == "Laptops & Computers").CategoryId, SupplierId = supplierList.First(s => s.Name == "Apple Inc.").Id },
                new Product { Name = "Dell XPS 13 Plus", Price = 1199.99, Quantity = 25, Description = "Premium Windows ultrabook with 12th Gen Intel processors", CategoryId = categoryList.First(c => c.Name == "Laptops & Computers").CategoryId, SupplierId = supplierList.First(s => s.Name == "Dell Technologies").Id },
                
                // Gaming
                new Product { Name = "PlayStation 5", Price = 499.99, Quantity = 8, Description = "Next-gen gaming console with ultra-fast SSD", CategoryId = categoryList.First(c => c.Name == "Gaming").CategoryId, SupplierId = supplierList.First(s => s.Name == "Sony Electronics").Id },
                new Product { Name = "Xbox Series X", Price = 499.99, Quantity = 10, Description = "Most powerful Xbox console with 4K gaming", CategoryId = categoryList.First(c => c.Name == "Gaming").CategoryId, SupplierId = supplierList.First(s => s.Name == "Microsoft Corporation").Id }
            };

            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }
    }
}
