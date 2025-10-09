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
                new Category { CategoryId = 12, Name = "Networking" },
                new Category { CategoryId = 13, Name = "Kitchen Appliances" },
                new Category { CategoryId = 14, Name = "Office Equipment" },
                new Category { CategoryId = 15, Name = "Monitors" },
                new Category { CategoryId = 16, Name = "Components & Parts" },
                new Category { CategoryId = 17, Name = "Smart Devices" },
                new Category { CategoryId = 18, Name = "Home Entertainment" }
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
                new Supplier { Id = 15, Name = "JBL/Harman International", Address = "8500 Balboa Blvd, Northridge, CA 91329", Phone = "+1-818-893-8411" },
                new Supplier { Id = 16, Name = "Xiaomi Corporation", Address = "Xiaomi Campus, Beijing 100085, China", Phone = "+86-10-6066-6666" },
                new Supplier { Id = 17, Name = "OnePlus Technology", Address = "Shenzhen, Guangdong, China", Phone = "+86-755-2955-0000" },
                new Supplier { Id = 18, Name = "Huawei Technologies", Address = "Bantian, Longgang District, Shenzhen, China", Phone = "+86-755-2878-0808" },
                new Supplier { Id = 19, Name = "Acer Inc.", Address = "88 Xianzheng Rd, Taipei 221, Taiwan", Phone = "+886-2-2696-1234" },
                new Supplier { Id = 20, Name = "Canon Inc.", Address = "30-2, Shimomaruko 3-chome, Tokyo, Japan", Phone = "+81-3-3758-2111" },
                new Supplier { Id = 21, Name = "Nikon Corporation", Address = "Shinagawa, Tokyo, Japan", Phone = "+81-3-6433-3600" },
                new Supplier { Id = 22, Name = "Philips Electronics", Address = "Amstelplein 2, Amsterdam, Netherlands", Phone = "+31-20-597-7777" },
                new Supplier { Id = 23, Name = "Electrolux AB", Address = "Sankt Göransgatan 143, Stockholm, Sweden", Phone = "+46-8-738-6000" },
                new Supplier { Id = 24, Name = "Bosch Home Appliances", Address = "Robert-Bosch-Platz 1, Stuttgart, Germany", Phone = "+49-711-400-40990" },
                new Supplier { Id = 25, Name = "Corsair Gaming", Address = "47100 Bayside Parkway, Fremont, CA 94538", Phone = "+1-888-222-4346" },
                new Supplier { Id = 26, Name = "Western Digital", Address = "5601 Great Oaks Parkway, San Jose, CA 95119", Phone = "+1-800-275-4932" },
                new Supplier { Id = 27, Name = "Seagate Technology", Address = "47488 Kato Road, Fremont, CA 94538", Phone = "+1-800-732-4283" },
                new Supplier { Id = 28, Name = "Kingston Technology", Address = "17600 Newhope St, Fountain Valley, CA 92708", Phone = "+1-800-435-0640" },
                new Supplier { Id = 29, Name = "Intel Corporation", Address = "2200 Mission College Blvd, Santa Clara, CA 95054", Phone = "+1-408-765-8080" },
                new Supplier { Id = 30, Name = "TP-Link Technologies", Address = "145 South State College Blvd, Brea, CA 92821", Phone = "+1-626-333-0234" }
            };

            // Seed Products
            var products = new[]
            {
                // Smartphones (IDs 1-35)
                new Product { ProductId = 1, Name = "iPhone 15 Pro Max 256GB", Price = 13995.00, Quantity = 45, Description = "Latest Apple flagship with titanium design, A17 Pro chip, and advanced camera system", CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 2, Name = "iPhone 15 Pro 128GB", Price = 11995.00, Quantity = 60, Description = "Pro iPhone with A17 Pro chip and premium cameras", CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 3, Name = "iPhone 15 128GB", Price = 8995.00, Quantity = 85, Description = "New iPhone with USB-C, Dynamic Island, and improved cameras", CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 4, Name = "iPhone 14 128GB", Price = 7495.00, Quantity = 70, Description = "Previous generation iPhone with excellent performance", CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 5, Name = "iPhone SE 64GB", Price = 4995.00, Quantity = 95, Description = "Compact iPhone with A15 chip and Touch ID", CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 6, Name = "Samsung Galaxy S24 Ultra 256GB", Price = 13495.00, Quantity = 50, Description = "Premium Android flagship with S Pen, 200MP camera, and AI features", CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 7, Name = "Samsung Galaxy S24+ 256GB", Price = 10995.00, Quantity = 55, Description = "Large screen Galaxy with advanced features", CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 8, Name = "Samsung Galaxy S24 128GB", Price = 8995.00, Quantity = 75, Description = "Flagship Android phone with Galaxy AI", CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 9, Name = "Samsung Galaxy S23 FE 128GB", Price = 6495.00, Quantity = 60, Description = "Fan Edition with flagship features at lower price", CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 10, Name = "Samsung Galaxy A54 5G 128GB", Price = 4495.00, Quantity = 90, Description = "Mid-range phone with great camera and 5G", CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 11, Name = "Samsung Galaxy A34 5G 128GB", Price = 3495.00, Quantity = 110, Description = "Affordable 5G phone with good performance", CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 12, Name = "Google Pixel 8 Pro 128GB", Price = 10995.00, Quantity = 35, Description = "Google flagship with advanced AI and computational photography", CategoryId = 1, SupplierId = 8 },
                new Product { ProductId = 13, Name = "Google Pixel 8 128GB", Price = 7995.00, Quantity = 50, Description = "Compact Pixel with excellent camera and clean Android", CategoryId = 1, SupplierId = 8 },
                new Product { ProductId = 14, Name = "Google Pixel 7a 128GB", Price = 4995.00, Quantity = 65, Description = "Budget Pixel with flagship camera features", CategoryId = 1, SupplierId = 8 },
                new Product { ProductId = 15, Name = "Xiaomi 13T Pro 256GB", Price = 6995.00, Quantity = 40, Description = "High-performance phone with Leica cameras", CategoryId = 1, SupplierId = 16 },
                new Product { ProductId = 16, Name = "Xiaomi Redmi Note 13 Pro 256GB", Price = 3495.00, Quantity = 80, Description = "Mid-range phone with excellent value", CategoryId = 1, SupplierId = 16 },
                new Product { ProductId = 17, Name = "OnePlus 12 256GB", Price = 8995.00, Quantity = 30, Description = "Flagship killer with Snapdragon 8 Gen 3", CategoryId = 1, SupplierId = 17 },
                new Product { ProductId = 18, Name = "OnePlus Nord 3 128GB", Price = 4495.00, Quantity = 55, Description = "Mid-range phone with fast charging", CategoryId = 1, SupplierId = 17 },
                new Product { ProductId = 19, Name = "Motorola Edge 40 Pro 256GB", Price = 6495.00, Quantity = 25, Description = "Premium Motorola with clean Android", CategoryId = 1, SupplierId = 9 },
                new Product { ProductId = 20, Name = "Sony Xperia 1 V 256GB", Price = 11995.00, Quantity = 15, Description = "Professional smartphone with 4K display", CategoryId = 1, SupplierId = 5 },

                // Laptops & Computers (IDs 21-65)
                new Product { ProductId = 21, Name = "MacBook Pro 16\" M3 Max 36GB/1TB", Price = 42995.00, Quantity = 20, Description = "Top-tier MacBook for professionals", CategoryId = 2, SupplierId = 1 },
                new Product { ProductId = 22, Name = "MacBook Pro 14\" M3 Pro 18GB/512GB", Price = 26995.00, Quantity = 35, Description = "Powerful compact MacBook Pro", CategoryId = 2, SupplierId = 1 },
                new Product { ProductId = 23, Name = "MacBook Air 15\" M3 16GB/512GB", Price = 16995.00, Quantity = 50, Description = "Large lightweight laptop with M3", CategoryId = 2, SupplierId = 1 },
                new Product { ProductId = 24, Name = "MacBook Air 13\" M3 16GB/256GB", Price = 13995.00, Quantity = 75, Description = "Popular thin and light MacBook", CategoryId = 2, SupplierId = 1 },
                new Product { ProductId = 25, Name = "MacBook Air 13\" M2 8GB/256GB", Price = 11995.00, Quantity = 60, Description = "Affordable MacBook with M2 chip", CategoryId = 2, SupplierId = 1 },
                new Product { ProductId = 26, Name = "Dell XPS 15 i9/32GB/1TB RTX4060", Price = 24995.00, Quantity = 25, Description = "Premium Windows laptop for creators", CategoryId = 2, SupplierId = 3 },
                new Product { ProductId = 27, Name = "Dell XPS 13 Plus i7/16GB/512GB", Price = 15995.00, Quantity = 40, Description = "Compact premium ultrabook", CategoryId = 2, SupplierId = 3 },
                new Product { ProductId = 28, Name = "Dell Inspiron 15 i5/16GB/512GB", Price = 7995.00, Quantity = 65, Description = "Versatile everyday laptop", CategoryId = 2, SupplierId = 3 },
                new Product { ProductId = 29, Name = "HP Spectre x360 14 i7/16GB/1TB", Price = 16995.00, Quantity = 30, Description = "2-in-1 laptop with OLED display", CategoryId = 2, SupplierId = 4 },
                new Product { ProductId = 30, Name = "HP Envy 16 i7/16GB/512GB", Price = 12995.00, Quantity = 35, Description = "Content creation laptop", CategoryId = 2, SupplierId = 4 },
                new Product { ProductId = 31, Name = "HP Pavilion 15 i5/16GB/512GB", Price = 6995.00, Quantity = 80, Description = "Affordable all-purpose laptop", CategoryId = 2, SupplierId = 4 },
                new Product { ProductId = 32, Name = "Lenovo ThinkPad X1 Carbon Gen 11 i7/16GB/512GB", Price = 18995.00, Quantity = 28, Description = "Business ultrabook with legendary keyboard", CategoryId = 2, SupplierId = 9 },
                new Product { ProductId = 33, Name = "Lenovo ThinkPad T14 Gen 4 i5/16GB/256GB", Price = 11995.00, Quantity = 45, Description = "Durable business laptop", CategoryId = 2, SupplierId = 9 },
                new Product { ProductId = 34, Name = "Lenovo IdeaPad 5 Pro Ryzen 7/16GB/512GB", Price = 8995.00, Quantity = 50, Description = "Powerful AMD laptop for productivity", CategoryId = 2, SupplierId = 9 },
                new Product { ProductId = 35, Name = "Lenovo Legion 5 Pro Ryzen 7/16GB/512GB RTX4060", Price = 14995.00, Quantity = 30, Description = "Gaming laptop with great performance", CategoryId = 2, SupplierId = 9 },
                new Product { ProductId = 36, Name = "ASUS ROG Zephyrus G16 i9/32GB/1TB RTX4070", Price = 29995.00, Quantity = 18, Description = "Premium gaming laptop with OLED", CategoryId = 2, SupplierId = 10 },
                new Product { ProductId = 37, Name = "ASUS ROG Strix G16 i7/16GB/1TB RTX4060", Price = 17995.00, Quantity = 25, Description = "Performance gaming laptop", CategoryId = 2, SupplierId = 10 },
                new Product { ProductId = 38, Name = "ASUS TUF Gaming A15 Ryzen 7/16GB/512GB RTX4050", Price = 11995.00, Quantity = 40, Description = "Durable budget gaming laptop", CategoryId = 2, SupplierId = 10 },
                new Product { ProductId = 39, Name = "ASUS Vivobook S 15 i7/16GB/512GB", Price = 9995.00, Quantity = 45, Description = "Stylish everyday laptop", CategoryId = 2, SupplierId = 10 },
                new Product { ProductId = 40, Name = "ASUS Zenbook 14 OLED i7/16GB/512GB", Price = 13995.00, Quantity = 32, Description = "Premium ultrabook with OLED screen", CategoryId = 2, SupplierId = 10 },
                new Product { ProductId = 41, Name = "Acer Predator Helios 16 i7/16GB/1TB RTX4070", Price = 19995.00, Quantity = 22, Description = "High-performance gaming laptop", CategoryId = 2, SupplierId = 19 },
                new Product { ProductId = 42, Name = "Acer Swift 3 i5/16GB/512GB", Price = 7995.00, Quantity = 55, Description = "Lightweight productivity laptop", CategoryId = 2, SupplierId = 19 },
                new Product { ProductId = 43, Name = "Microsoft Surface Laptop 5 i7/16GB/512GB", Price = 15995.00, Quantity = 28, Description = "Premium Windows laptop with touchscreen", CategoryId = 2, SupplierId = 7 },
                new Product { ProductId = 44, Name = "Razer Blade 15 i9/32GB/1TB RTX4070", Price = 32995.00, Quantity = 12, Description = "Ultra-premium gaming laptop", CategoryId = 2, SupplierId = 14 },
                new Product { ProductId = 45, Name = "MSI Stealth 16 i9/32GB/1TB RTX4080", Price = 29995.00, Quantity = 15, Description = "Thin and powerful gaming laptop", CategoryId = 2, SupplierId = 10 },

                // Tablets (IDs 46-60)
                new Product { ProductId = 46, Name = "iPad Pro 12.9\" M2 256GB WiFi", Price = 13995.00, Quantity = 35, Description = "Professional tablet with M2 chip", CategoryId = 3, SupplierId = 1 },
                new Product { ProductId = 47, Name = "iPad Pro 11\" M2 128GB WiFi", Price = 9995.00, Quantity = 50, Description = "Compact pro tablet with M2", CategoryId = 3, SupplierId = 1 },
                new Product { ProductId = 48, Name = "iPad Air 11\" M2 128GB WiFi", Price = 6995.00, Quantity = 65, Description = "Versatile tablet with M2 chip", CategoryId = 3, SupplierId = 1 },
                new Product { ProductId = 49, Name = "iPad 10th Gen 64GB WiFi", Price = 4495.00, Quantity = 90, Description = "Standard iPad with modern design", CategoryId = 3, SupplierId = 1 },
                new Product { ProductId = 50, Name = "iPad Mini 6th Gen 64GB WiFi", Price = 5995.00, Quantity = 55, Description = "Compact powerful iPad", CategoryId = 3, SupplierId = 1 },
                new Product { ProductId = 51, Name = "Samsung Galaxy Tab S9 Ultra 256GB", Price = 13995.00, Quantity = 20, Description = "Premium Android tablet with S Pen", CategoryId = 3, SupplierId = 2 },
                new Product { ProductId = 52, Name = "Samsung Galaxy Tab S9+ 256GB", Price = 10995.00, Quantity = 28, Description = "Large Android tablet with AMOLED", CategoryId = 3, SupplierId = 2 },
                new Product { ProductId = 53, Name = "Samsung Galaxy Tab S9 128GB", Price = 7995.00, Quantity = 40, Description = "Compact flagship Android tablet", CategoryId = 3, SupplierId = 2 },
                new Product { ProductId = 54, Name = "Samsung Galaxy Tab A9+ 64GB", Price = 2495.00, Quantity = 70, Description = "Affordable family tablet", CategoryId = 3, SupplierId = 2 },
                new Product { ProductId = 55, Name = "Microsoft Surface Pro 9 i7/16GB/256GB", Price = 13995.00, Quantity = 25, Description = "2-in-1 Windows tablet", CategoryId = 3, SupplierId = 7 },
                new Product { ProductId = 56, Name = "Microsoft Surface Go 3 8GB/128GB", Price = 4995.00, Quantity = 35, Description = "Compact Windows tablet", CategoryId = 3, SupplierId = 7 },
                new Product { ProductId = 57, Name = "Lenovo Tab P12 Pro 256GB", Price = 6995.00, Quantity = 22, Description = "Premium Android tablet with OLED", CategoryId = 3, SupplierId = 9 },
                new Product { ProductId = 58, Name = "Amazon Fire HD 10 64GB", Price = 1495.00, Quantity = 100, Description = "Budget-friendly media tablet", CategoryId = 3, SupplierId = 8 },

                // Audio & Headphones (IDs 59-95)
                new Product { ProductId = 59, Name = "AirPods Pro 2nd Gen", Price = 2795.00, Quantity = 120, Description = "Premium wireless earbuds with ANC", CategoryId = 4, SupplierId = 1 },
                new Product { ProductId = 60, Name = "AirPods 3rd Gen", Price = 1995.00, Quantity = 140, Description = "Wireless earbuds with spatial audio", CategoryId = 4, SupplierId = 1 },
                new Product { ProductId = 61, Name = "AirPods Max", Price = 6295.00, Quantity = 25, Description = "Premium over-ear headphones", CategoryId = 4, SupplierId = 1 },
                new Product { ProductId = 62, Name = "Sony WH-1000XM5", Price = 3995.00, Quantity = 45, Description = "Industry-leading noise canceling headphones", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 63, Name = "Sony WF-1000XM5", Price = 2995.00, Quantity = 55, Description = "Premium wireless earbuds with excellent ANC", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 64, Name = "Sony LinkBuds S", Price = 1795.00, Quantity = 60, Description = "Lightweight earbuds with smart features", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 65, Name = "Bose QuietComfort Ultra Headphones", Price = 4495.00, Quantity = 30, Description = "Premium ANC headphones with spatial audio", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 66, Name = "Bose QuietComfort Earbuds II", Price = 2995.00, Quantity = 40, Description = "High-end wireless earbuds with personalized ANC", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 67, Name = "Samsung Galaxy Buds2 Pro", Price = 2295.00, Quantity = 65, Description = "Premium wireless earbuds with 360 Audio", CategoryId = 4, SupplierId = 2 },
                new Product { ProductId = 68, Name = "Samsung Galaxy Buds FE", Price = 995.00, Quantity = 85, Description = "Affordable wireless earbuds with ANC", CategoryId = 4, SupplierId = 2 },
                new Product { ProductId = 69, Name = "JBL Charge 5", Price = 1795.00, Quantity = 70, Description = "Portable Bluetooth speaker with powerbank", CategoryId = 4, SupplierId = 15 },
                new Product { ProductId = 70, Name = "JBL Flip 6", Price = 1295.00, Quantity = 90, Description = "Compact portable Bluetooth speaker", CategoryId = 4, SupplierId = 15 },
                new Product { ProductId = 71, Name = "JBL PartyBox 310", Price = 3995.00, Quantity = 15, Description = "Large party speaker with lights", CategoryId = 4, SupplierId = 15 },
                new Product { ProductId = 72, Name = "Marshall Emberton II", Price = 1695.00, Quantity = 45, Description = "Stylish portable speaker with great sound", CategoryId = 4, SupplierId = 15 },
                new Product { ProductId = 73, Name = "Sonos Arc", Price = 9995.00, Quantity = 20, Description = "Premium soundbar with Dolby Atmos", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 74, Name = "Sonos Beam Gen 2", Price = 4995.00, Quantity = 35, Description = "Compact smart soundbar", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 75, Name = "Beats Studio Pro", Price = 3495.00, Quantity = 40, Description = "Premium wireless headphones with ANC", CategoryId = 4, SupplierId = 1 },
                new Product { ProductId = 76, Name = "Beats Fit Pro", Price = 2295.00, Quantity = 55, Description = "Sport earbuds with ANC", CategoryId = 4, SupplierId = 1 },
                new Product { ProductId = 77, Name = "Sennheiser Momentum 4 Wireless", Price = 3795.00, Quantity = 25, Description = "Audiophile wireless headphones", CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 78, Name = "Audio-Technica ATH-M50xBT2", Price = 2195.00, Quantity = 30, Description = "Studio monitor headphones with Bluetooth", CategoryId = 4, SupplierId = 5 },

                // Gaming (IDs 79-120)
                new Product { ProductId = 79, Name = "PlayStation 5 Slim Digital", Price = 4495.00, Quantity = 25, Description = "Next-gen console digital edition", CategoryId = 5, SupplierId = 5 },
                new Product { ProductId = 80, Name = "PlayStation 5 Slim", Price = 5495.00, Quantity = 30, Description = "Next-gen console with disc drive", CategoryId = 5, SupplierId = 5 },
                new Product { ProductId = 81, Name = "PlayStation VR2", Price = 5995.00, Quantity = 15, Description = "VR headset for PS5", CategoryId = 5, SupplierId = 5 },
                new Product { ProductId = 82, Name = "DualSense Wireless Controller", Price = 795.00, Quantity = 150, Description = "PS5 controller with haptic feedback", CategoryId = 5, SupplierId = 5 },
                new Product { ProductId = 83, Name = "Xbox Series X", Price = 5495.00, Quantity = 28, Description = "Most powerful Xbox console", CategoryId = 5, SupplierId = 7 },
                new Product { ProductId = 84, Name = "Xbox Series S", Price = 2995.00, Quantity = 45, Description = "Compact digital Xbox console", CategoryId = 5, SupplierId = 7 },
                new Product { ProductId = 85, Name = "Xbox Wireless Controller", Price = 695.00, Quantity = 160, Description = "Standard Xbox controller", CategoryId = 5, SupplierId = 7 },
                new Product { ProductId = 86, Name = "Nintendo Switch OLED", Price = 3695.00, Quantity = 50, Description = "Hybrid console with OLED screen", CategoryId = 5, SupplierId = 8 },
                new Product { ProductId = 87, Name = "Nintendo Switch Lite", Price = 2195.00, Quantity = 60, Description = "Handheld-only Switch", CategoryId = 5, SupplierId = 8 },
                new Product { ProductId = 88, Name = "Steam Deck 512GB", Price = 5995.00, Quantity = 20, Description = "Handheld gaming PC by Valve", CategoryId = 5, SupplierId = 7 },
                new Product { ProductId = 89, Name = "Razer DeathAdder V3 Pro", Price = 1495.00, Quantity = 55, Description = "Wireless gaming mouse", CategoryId = 5, SupplierId = 14 },
                new Product { ProductId = 90, Name = "Razer Basilisk V3 Pro", Price = 1695.00, Quantity = 40, Description = "Feature-rich gaming mouse", CategoryId = 5, SupplierId = 14 },
                new Product { ProductId = 91, Name = "Razer BlackWidow V4 Pro", Price = 2295.00, Quantity = 30, Description = "Mechanical gaming keyboard", CategoryId = 5, SupplierId = 14 },
                new Product { ProductId = 92, Name = "Razer Kraken V3 Pro", Price = 1995.00, Quantity = 35, Description = "Wireless gaming headset with haptics", CategoryId = 5, SupplierId = 14 },
                new Product { ProductId = 93, Name = "Logitech G Pro X Superlight 2", Price = 1695.00, Quantity = 50, Description = "Ultra-lightweight wireless gaming mouse", CategoryId = 5, SupplierId = 13 },
                new Product { ProductId = 94, Name = "Logitech G915 TKL", Price = 2195.00, Quantity = 28, Description = "Low-profile wireless mechanical keyboard", CategoryId = 5, SupplierId = 13 },
                new Product { ProductId = 95, Name = "Logitech G Pro X Wireless Headset", Price = 2495.00, Quantity = 32, Description = "Pro gaming headset with Blue VO!CE", CategoryId = 5, SupplierId = 13 },
                new Product { ProductId = 96, Name = "Logitech G29 Driving Force", Price = 3495.00, Quantity = 18, Description = "Racing wheel for PlayStation and PC", CategoryId = 5, SupplierId = 13 },
                new Product { ProductId = 97, Name = "Corsair K70 RGB PRO", Price = 1795.00, Quantity = 35, Description = "Premium mechanical gaming keyboard", CategoryId = 5, SupplierId = 25 },
                new Product { ProductId = 98, Name = "Corsair Dark Core RGB Pro SE", Price = 995.00, Quantity = 45, Description = "Wireless gaming mouse", CategoryId = 5, SupplierId = 25 },
                new Product { ProductId = 99, Name = "SteelSeries Arctis Nova Pro Wireless", Price = 3795.00, Quantity = 22, Description = "Premium multi-system wireless headset", CategoryId = 5, SupplierId = 13 },
                new Product { ProductId = 100, Name = "HyperX Cloud III Wireless", Price = 1695.00, Quantity = 40, Description = "Comfortable wireless gaming headset", CategoryId = 5, SupplierId = 4 },
                new Product { ProductId = 101, Name = "ASUS ROG Azoth", Price = 2495.00, Quantity = 20, Description = "Premium 75% wireless mechanical keyboard", CategoryId = 5, SupplierId = 10 },
                new Product { ProductId = 102, Name = "Elgato Stream Deck MK.2", Price = 1695.00, Quantity = 25, Description = "Live content creation controller", CategoryId = 5, SupplierId = 25 },

                // Smart Home (IDs 103-130)
                new Product { ProductId = 103, Name = "Google Nest Hub Max", Price = 2495.00, Quantity = 35, Description = "10-inch smart display with Google Assistant", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 104, Name = "Google Nest Hub 2nd Gen", Price = 995.00, Quantity = 60, Description = "7-inch smart display", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 105, Name = "Google Nest Audio", Price = 995.00, Quantity = 70, Description = "Smart speaker with great sound", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 106, Name = "Google Nest Mini", Price = 595.00, Quantity = 100, Description = "Compact smart speaker", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 107, Name = "Amazon Echo Show 10 3rd Gen", Price = 2795.00, Quantity = 25, Description = "10-inch smart display with motion tracking", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 108, Name = "Amazon Echo Dot 5th Gen", Price = 695.00, Quantity = 120, Description = "Best-selling smart speaker", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 109, Name = "Amazon Echo Studio", Price = 2195.00, Quantity = 30, Description = "High-fidelity smart speaker with Dolby Atmos", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 110, Name = "Apple HomePod 2nd Gen", Price = 3295.00, Quantity = 28, Description = "Premium smart speaker with spatial audio", CategoryId = 6, SupplierId = 1 },
                new Product { ProductId = 111, Name = "Apple HomePod mini", Price = 1095.00, Quantity = 65, Description = "Compact smart speaker with Siri", CategoryId = 6, SupplierId = 1 },
                new Product { ProductId = 112, Name = "Philips Hue White & Color Starter Kit", Price = 1995.00, Quantity = 40, Description = "Smart lighting starter pack with bridge", CategoryId = 6, SupplierId = 22 },
                new Product { ProductId = 113, Name = "Philips Hue Play Light Bar 2-pack", Price = 1495.00, Quantity = 35, Description = "Accent lighting for entertainment", CategoryId = 6, SupplierId = 22 },
                new Product { ProductId = 114, Name = "Ring Video Doorbell Pro 2", Price = 2495.00, Quantity = 30, Description = "Smart doorbell with 3D motion detection", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 115, Name = "Ring Indoor Cam 2-pack", Price = 995.00, Quantity = 50, Description = "Indoor security cameras", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 116, Name = "Arlo Pro 4 Spotlight 2-Camera Kit", Price = 3495.00, Quantity = 22, Description = "Wireless outdoor security cameras", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 117, Name = "Nest Learning Thermostat", Price = 2795.00, Quantity = 25, Description = "Smart thermostat that learns your schedule", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 118, Name = "Ecovacs Deebot X2 Omni", Price = 11995.00, Quantity = 15, Description = "Premium robot vacuum with auto-empty station", CategoryId = 6, SupplierId = 18 },
                new Product { ProductId = 119, Name = "iRobot Roomba j7+", Price = 7995.00, Quantity = 20, Description = "Smart robot vacuum with obstacle avoidance", CategoryId = 6, SupplierId = 8 },
                new Product { ProductId = 120, Name = "Roborock S8 Pro Ultra", Price = 13995.00, Quantity = 12, Description = "Premium robot vacuum and mop combo", CategoryId = 6, SupplierId = 16 },
                new Product { ProductId = 121, Name = "TP-Link Tapo C200 Pan/Tilt Camera", Price = 395.00, Quantity = 80, Description = "Affordable smart home camera", CategoryId = 6, SupplierId = 30 },
                new Product { ProductId = 122, Name = "TP-Link Kasa Smart Plug 4-pack", Price = 495.00, Quantity = 70, Description = "WiFi smart plugs", CategoryId = 6, SupplierId = 30 },

                // Wearables (IDs 123-145)
                new Product { ProductId = 123, Name = "Apple Watch Series 9 GPS 45mm", Price = 4695.00, Quantity = 60, Description = "Advanced smartwatch with health monitoring", CategoryId = 7, SupplierId = 1 },
                new Product { ProductId = 124, Name = "Apple Watch Series 9 GPS 41mm", Price = 4295.00, Quantity = 75, Description = "Compact Apple Watch with S9 chip", CategoryId = 7, SupplierId = 1 },
                new Product { ProductId = 125, Name = "Apple Watch SE 2nd Gen GPS 44mm", Price = 2995.00, Quantity = 85, Description = "Affordable Apple Watch", CategoryId = 7, SupplierId = 1 },
                new Product { ProductId = 126, Name = "Apple Watch Ultra 2", Price = 8995.00, Quantity = 25, Description = "Rugged smartwatch for extreme sports", CategoryId = 7, SupplierId = 1 },
                new Product { ProductId = 127, Name = "Samsung Galaxy Watch6 Classic 47mm", Price = 3995.00, Quantity = 35, Description = "Premium Android smartwatch with rotating bezel", CategoryId = 7, SupplierId = 2 },
                new Product { ProductId = 128, Name = "Samsung Galaxy Watch6 44mm", Price = 3295.00, Quantity = 45, Description = "Sleek Android smartwatch", CategoryId = 7, SupplierId = 2 },
                new Product { ProductId = 129, Name = "Samsung Galaxy Watch5 Pro 45mm", Price = 3795.00, Quantity = 30, Description = "Outdoor-focused smartwatch", CategoryId = 7, SupplierId = 2 },
                new Product { ProductId = 130, Name = "Google Pixel Watch 2", Price = 3795.00, Quantity = 28, Description = "Wear OS watch with Fitbit integration", CategoryId = 7, SupplierId = 8 },
                new Product { ProductId = 131, Name = "Garmin Fenix 7 Pro", Price = 7995.00, Quantity = 18, Description = "Premium multisport GPS smartwatch", CategoryId = 7, SupplierId = 8 },
                new Product { ProductId = 132, Name = "Garmin Forerunner 965", Price = 5995.00, Quantity = 22, Description = "Advanced running smartwatch with AMOLED", CategoryId = 7, SupplierId = 8 },
                new Product { ProductId = 133, Name = "Garmin Venu 3", Price = 4495.00, Quantity = 30, Description = "Fitness smartwatch with AMOLED display", CategoryId = 7, SupplierId = 8 },
                new Product { ProductId = 134, Name = "Fitbit Charge 6", Price = 1795.00, Quantity = 55, Description = "Fitness tracker with Google integration", CategoryId = 7, SupplierId = 8 },
                new Product { ProductId = 135, Name = "Fitbit Inspire 3", Price = 995.00, Quantity = 70, Description = "Slim fitness tracker", CategoryId = 7, SupplierId = 8 },
                new Product { ProductId = 136, Name = "Polar Vantage V3", Price = 5995.00, Quantity = 15, Description = "Multisport watch for athletes", CategoryId = 7, SupplierId = 8 },
                new Product { ProductId = 137, Name = "Xiaomi Smart Band 8 Pro", Price = 795.00, Quantity = 90, Description = "Affordable fitness tracker with AMOLED", CategoryId = 7, SupplierId = 16 },
                new Product { ProductId = 138, Name = "Amazfit GTR 4", Price = 2195.00, Quantity = 40, Description = "Long-lasting smartwatch", CategoryId = 7, SupplierId = 18 },
                new Product { ProductId = 139, Name = "Whoop 4.0", Price = 2995.00, Quantity = 20, Description = "Screenless fitness and recovery tracker", CategoryId = 7, SupplierId = 8 },
                new Product { ProductId = 140, Name = "Oura Ring Gen 3 Horizon", Price = 3795.00, Quantity = 25, Description = "Smart ring for sleep and health tracking", CategoryId = 7, SupplierId = 8 },

                // Cameras (IDs 141-170)
                new Product { ProductId = 141, Name = "Sony α7R V", Price = 41995.00, Quantity = 8, Description = "61MP full-frame mirrorless for professionals", CategoryId = 8, SupplierId = 5 },
                new Product { ProductId = 142, Name = "Sony α7 IV", Price = 26995.00, Quantity = 15, Description = "Versatile full-frame hybrid camera", CategoryId = 8, SupplierId = 5 },
                new Product { ProductId = 143, Name = "Sony α6700", Price = 14995.00, Quantity = 20, Description = "APS-C camera with advanced AF", CategoryId = 8, SupplierId = 5 },
                new Product { ProductId = 144, Name = "Sony ZV-E10", Price = 7995.00, Quantity = 25, Description = "Vlogging camera with great autofocus", CategoryId = 8, SupplierId = 5 },
                new Product { ProductId = 145, Name = "Canon EOS R5", Price = 37995.00, Quantity = 10, Description = "45MP full-frame with 8K video", CategoryId = 8, SupplierId = 20 },
                new Product { ProductId = 146, Name = "Canon EOS R6 Mark II", Price = 26995.00, Quantity = 12, Description = "Fast full-frame camera for action", CategoryId = 8, SupplierId = 20 },
                new Product { ProductId = 147, Name = "Canon EOS R10", Price = 10995.00, Quantity = 18, Description = "Entry-level APS-C mirrorless", CategoryId = 8, SupplierId = 20 },
                new Product { ProductId = 148, Name = "Nikon Z9", Price = 57995.00, Quantity = 5, Description = "Flagship professional mirrorless", CategoryId = 8, SupplierId = 21 },
                new Product { ProductId = 149, Name = "Nikon Z8", Price = 39995.00, Quantity = 8, Description = "Compact flagship with Z9 performance", CategoryId = 8, SupplierId = 21 },
                new Product { ProductId = 150, Name = "Nikon Z6 III", Price = 26995.00, Quantity = 12, Description = "All-round full-frame mirrorless", CategoryId = 8, SupplierId = 21 },
                new Product { ProductId = 151, Name = "Nikon Z fc", Price = 10995.00, Quantity = 15, Description = "Retro-styled APS-C camera", CategoryId = 8, SupplierId = 21 },
                new Product { ProductId = 152, Name = "Fujifilm X-T5", Price = 17995.00, Quantity = 14, Description = "40MP APS-C camera with film simulations", CategoryId = 8, SupplierId = 5 },
                new Product { ProductId = 153, Name = "Fujifilm X-S20", Price = 13995.00, Quantity = 16, Description = "Compact hybrid camera with IBIS", CategoryId = 8, SupplierId = 5 },
                new Product { ProductId = 154, Name = "Panasonic Lumix S5 II", Price = 19995.00, Quantity = 10, Description = "Full-frame hybrid with phase detect AF", CategoryId = 8, SupplierId = 22 },
                new Product { ProductId = 155, Name = "GoPro Hero 12 Black", Price = 4295.00, Quantity = 35, Description = "Action camera with 5.3K60 video", CategoryId = 8, SupplierId = 8 },
                new Product { ProductId = 156, Name = "GoPro Hero 11 Black", Price = 3495.00, Quantity = 40, Description = "Previous gen action camera", CategoryId = 8, SupplierId = 8 },
                new Product { ProductId = 157, Name = "DJI Osmo Action 4", Price = 3995.00, Quantity = 28, Description = "Action camera with excellent low-light", CategoryId = 8, SupplierId = 8 },
                new Product { ProductId = 158, Name = "DJI Pocket 3", Price = 5995.00, Quantity = 22, Description = "Gimbal camera for smooth video", CategoryId = 8, SupplierId = 8 },
                new Product { ProductId = 159, Name = "DJI Mini 4 Pro", Price = 10995.00, Quantity = 18, Description = "Compact drone with 4K60 video", CategoryId = 8, SupplierId = 8 },
                new Product { ProductId = 160, Name = "DJI Air 3", Price = 12995.00, Quantity = 15, Description = "Mid-size drone with dual cameras", CategoryId = 8, SupplierId = 8 },
                new Product { ProductId = 161, Name = "Insta360 X3", Price = 4795.00, Quantity = 20, Description = "360° action camera", CategoryId = 8, SupplierId = 8 },
                new Product { ProductId = 162, Name = "Canon PowerShot G7 X Mark III", Price = 7995.00, Quantity = 18, Description = "Compact camera for vlogging", CategoryId = 8, SupplierId = 20 },

                // TVs & Displays (IDs 163-195)
                new Product { ProductId = 163, Name = "Samsung S95C QD-OLED 65\"", Price = 24995.00, Quantity = 12, Description = "Quantum Dot OLED TV with incredible brightness", CategoryId = 9, SupplierId = 2 },
                new Product { ProductId = 164, Name = "Samsung QN90C Neo QLED 75\"", Price = 29995.00, Quantity = 8, Description = "Large premium QLED TV", CategoryId = 9, SupplierId = 2 },
                new Product { ProductId = 165, Name = "Samsung QN90C Neo QLED 65\"", Price = 22995.00, Quantity = 15, Description = "Premium 4K QLED with Mini LED", CategoryId = 9, SupplierId = 2 },
                new Product { ProductId = 166, Name = "Samsung QN85C Neo QLED 55\"", Price = 13995.00, Quantity = 20, Description = "Mid-range QLED TV", CategoryId = 9, SupplierId = 2 },
                new Product { ProductId = 167, Name = "Samsung Q60C QLED 50\"", Price = 6995.00, Quantity = 30, Description = "Entry-level QLED TV", CategoryId = 9, SupplierId = 2 },
                new Product { ProductId = 168, Name = "LG G3 OLED evo 77\"", Price = 39995.00, Quantity = 6, Description = "Brightest OLED TV with gallery design", CategoryId = 9, SupplierId = 6 },
                new Product { ProductId = 169, Name = "LG C3 OLED 65\"", Price = 17995.00, Quantity = 18, Description = "Best all-round OLED TV", CategoryId = 9, SupplierId = 6 },
                new Product { ProductId = 170, Name = "LG C3 OLED 55\"", Price = 13995.00, Quantity = 25, Description = "Popular OLED size", CategoryId = 9, SupplierId = 6 },
                new Product { ProductId = 171, Name = "LG B3 OLED 55\"", Price = 10995.00, Quantity = 22, Description = "Entry-level OLED TV", CategoryId = 9, SupplierId = 6 },
                new Product { ProductId = 172, Name = "Sony A95L QD-OLED 65\"", Price = 32995.00, Quantity = 8, Description = "Premium QD-OLED with XR processor", CategoryId = 9, SupplierId = 5 },
                new Product { ProductId = 173, Name = "Sony X90L 75\"", Price = 17995.00, Quantity = 12, Description = "Large LED TV with full-array dimming", CategoryId = 9, SupplierId = 5 },
                new Product { ProductId = 174, Name = "Sony X90L 65\"", Price = 12995.00, Quantity = 18, Description = "Mid-range LED TV with great picture", CategoryId = 9, SupplierId = 5 },
                new Product { ProductId = 175, Name = "Sony X85K 55\"", Price = 7995.00, Quantity = 25, Description = "Entry 4K TV for gaming", CategoryId = 9, SupplierId = 5 },
                new Product { ProductId = 176, Name = "TCL C845 Mini LED 65\"", Price = 11995.00, Quantity = 15, Description = "Affordable Mini LED TV", CategoryId = 9, SupplierId = 2 },
                new Product { ProductId = 177, Name = "Hisense U8K Mini LED 65\"", Price = 12995.00, Quantity = 14, Description = "Bright Mini LED TV with great value", CategoryId = 9, SupplierId = 18 },
                new Product { ProductId = 178, Name = "Philips OLED808 55\"", Price = 14995.00, Quantity = 12, Description = "OLED TV with Ambilight", CategoryId = 9, SupplierId = 22 },

                // Monitors (IDs 179-210)
                new Product { ProductId = 179, Name = "Apple Studio Display", Price = 17995.00, Quantity = 20, Description = "27\" 5K Retina display", CategoryId = 15, SupplierId = 1 },
                new Product { ProductId = 180, Name = "Dell UltraSharp U2723DE", Price = 5995.00, Quantity = 35, Description = "27\" QHD USB-C hub monitor", CategoryId = 15, SupplierId = 3 },
                new Product { ProductId = 181, Name = "Dell UltraSharp U3223QE", Price = 9995.00, Quantity = 22, Description = "32\" 4K IPS USB-C hub monitor", CategoryId = 15, SupplierId = 3 },
                new Product { ProductId = 182, Name = "LG UltraGear 27GR95QE-B", Price = 10995.00, Quantity = 18, Description = "27\" 1440p 240Hz OLED gaming monitor", CategoryId = 15, SupplierId = 6 },
                new Product { ProductId = 183, Name = "LG 27UP850-W", Price = 4995.00, Quantity = 30, Description = "27\" 4K USB-C monitor", CategoryId = 15, SupplierId = 6 },
                new Product { ProductId = 184, Name = "Samsung Odyssey OLED G9", Price = 19995.00, Quantity = 10, Description = "49\" super ultra-wide OLED gaming monitor", CategoryId = 15, SupplierId = 2 },
                new Product { ProductId = 185, Name = "Samsung ViewFinity S9 5K", Price = 16995.00, Quantity = 12, Description = "27\" 5K creator monitor", CategoryId = 15, SupplierId = 2 },
                new Product { ProductId = 186, Name = "ASUS ROG Swift PG27AQDM", Price = 10995.00, Quantity = 15, Description = "27\" 1440p 240Hz OLED", CategoryId = 15, SupplierId = 10 },
                new Product { ProductId = 187, Name = "ASUS ProArt PA279CRV", Price = 4995.00, Quantity = 25, Description = "27\" 4K creator monitor", CategoryId = 15, SupplierId = 10 },
                new Product { ProductId = 188, Name = "BenQ PD3225U", Price = 7995.00, Quantity = 18, Description = "32\" 4K designer monitor", CategoryId = 15, SupplierId = 10 },
                new Product { ProductId = 189, Name = "AOC CU34G2X", Price = 3995.00, Quantity = 28, Description = "34\" ultra-wide curved gaming monitor", CategoryId = 15, SupplierId = 22 },
                new Product { ProductId = 190, Name = "MSI MAG274UPF", Price = 4495.00, Quantity = 22, Description = "27\" 4K 144Hz gaming monitor", CategoryId = 15, SupplierId = 10 },

                // Accessories (IDs 191-240)
                new Product { ProductId = 191, Name = "MagSafe Charger", Price = 395.00, Quantity = 150, Description = "Wireless charging pad for iPhone", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 192, Name = "MagSafe Duo Charger", Price = 1395.00, Quantity = 40, Description = "Dual wireless charger for iPhone and Watch", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 193, Name = "Apple Pencil 2nd Gen", Price = 1395.00, Quantity = 60, Description = "Stylus for iPad Pro and Air", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 194, Name = "Apple Pencil USB-C", Price = 895.00, Quantity = 70, Description = "Affordable stylus for iPad", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 195, Name = "Apple Magic Keyboard for iPad Pro 12.9\"", Price = 3795.00, Quantity = 25, Description = "Premium keyboard case with trackpad", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 196, Name = "Apple Magic Keyboard", Price = 1095.00, Quantity = 50, Description = "Wireless keyboard for Mac", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 197, Name = "Apple Magic Trackpad", Price = 1495.00, Quantity = 35, Description = "Wireless trackpad for Mac", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 198, Name = "Apple Magic Mouse", Price = 895.00, Quantity = 55, Description = "Wireless mouse for Mac", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 199, Name = "Logitech MX Master 3S", Price = 1195.00, Quantity = 70, Description = "Premium wireless productivity mouse", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 200, Name = "Logitech MX Keys", Price = 1195.00, Quantity = 55, Description = "Premium wireless keyboard", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 201, Name = "Logitech MX Anywhere 3S", Price = 895.00, Quantity = 60, Description = "Compact wireless mouse", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 202, Name = "Logitech C920 HD Pro Webcam", Price = 795.00, Quantity = 80, Description = "Popular 1080p webcam", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 203, Name = "Logitech Brio 4K Webcam", Price = 2195.00, Quantity = 30, Description = "Premium 4K webcam", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 204, Name = "Anker PowerCore 10000", Price = 295.00, Quantity = 200, Description = "Compact 10000mAh power bank", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 205, Name = "Anker PowerCore 20000", Price = 495.00, Quantity = 150, Description = "High-capacity power bank", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 206, Name = "Anker 735 Charger GaNPrime 65W", Price = 595.00, Quantity = 100, Description = "3-port fast charger", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 207, Name = "Anker 747 Charger GaNPrime 150W", Price = 995.00, Quantity = 60, Description = "4-port high-power charger", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 208, Name = "Belkin BoostCharge Pro 3-in-1", Price = 1595.00, Quantity = 45, Description = "Wireless charger for Apple devices", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 209, Name = "Samsung S Pen Pro", Price = 995.00, Quantity = 40, Description = "Universal stylus for Samsung devices", CategoryId = 10, SupplierId = 2 },
                new Product { ProductId = 210, Name = "Samsung Galaxy SmartTag 2", Price = 395.00, Quantity = 120, Description = "Bluetooth tracker", CategoryId = 10, SupplierId = 2 },
                new Product { ProductId = 211, Name = "Apple AirTag 4 Pack", Price = 1195.00, Quantity = 100, Description = "Item trackers for Find My network", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 212, Name = "Tile Pro 2-pack", Price = 695.00, Quantity = 80, Description = "Bluetooth trackers", CategoryId = 10, SupplierId = 8 },
                new Product { ProductId = 213, Name = "CalDigit TS4 Thunderbolt 4 Dock", Price = 3995.00, Quantity = 20, Description = "18-port Thunderbolt dock", CategoryId = 10, SupplierId = 3 },
                new Product { ProductId = 214, Name = "Elgato Wave:3 USB Microphone", Price = 1695.00, Quantity = 35, Description = "Premium USB condenser microphone", CategoryId = 10, SupplierId = 25 },
                new Product { ProductId = 215, Name = "Blue Yeti USB Microphone", Price = 1295.00, Quantity = 50, Description = "Popular USB microphone for streaming", CategoryId = 10, SupplierId = 13 },
                new Product { ProductId = 216, Name = "Elgato Stream Deck +", Price = 2495.00, Quantity = 25, Description = "Stream controller with dials and buttons", CategoryId = 10, SupplierId = 25 },
                new Product { ProductId = 217, Name = "Elgato Key Light Air", Price = 1395.00, Quantity = 30, Description = "LED panel light for streaming", CategoryId = 10, SupplierId = 25 },
                new Product { ProductId = 218, Name = "UAG Rugged Case iPhone 15 Pro Max", Price = 595.00, Quantity = 100, Description = "Military-grade protection case", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 219, Name = "Spigen Tough Armor Case iPhone 15", Price = 295.00, Quantity = 150, Description = "Affordable protective case", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 220, Name = "dbrand Grip Case", Price = 495.00, Quantity = 80, Description = "Textured protective case with skins", CategoryId = 10, SupplierId = 8 },
                new Product { ProductId = 221, Name = "Moment Mobile Filmmaker Case", Price = 895.00, Quantity = 40, Description = "Case with lens mount system", CategoryId = 10, SupplierId = 8 },
                new Product { ProductId = 222, Name = "Nomad Leather Case iPhone 15 Pro", Price = 695.00, Quantity = 60, Description = "Premium Horween leather case", CategoryId = 10, SupplierId = 1 },
                new Product { ProductId = 223, Name = "Peak Design Mobile Tripod", Price = 895.00, Quantity = 45, Description = "Compact smartphone tripod", CategoryId = 10, SupplierId = 8 },
                new Product { ProductId = 224, Name = "DJI OM 6 Smartphone Gimbal", Price = 1595.00, Quantity = 30, Description = "3-axis smartphone stabilizer", CategoryId = 10, SupplierId = 8 },

                // Storage (IDs 225-255)
                new Product { ProductId = 225, Name = "Samsung T9 Portable SSD 4TB", Price = 3995.00, Quantity = 25, Description = "Fast USB 3.2 Gen 2x2 portable SSD", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 226, Name = "Samsung T9 Portable SSD 2TB", Price = 2195.00, Quantity = 45, Description = "Portable SSD with 2000MB/s speeds", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 227, Name = "Samsung T7 Shield 2TB", Price = 1995.00, Quantity = 55, Description = "Rugged portable SSD with IP65 rating", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 228, Name = "Samsung T7 Shield 1TB", Price = 1195.00, Quantity = 70, Description = "Durable 1TB portable SSD", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 229, Name = "SanDisk Extreme Pro Portable SSD 4TB", Price = 4495.00, Quantity = 20, Description = "Rugged high-speed portable SSD", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 230, Name = "SanDisk Extreme Portable SSD 2TB", Price = 1995.00, Quantity = 50, Description = "Durable portable SSD for outdoors", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 231, Name = "Crucial X10 Pro 2TB", Price = 2495.00, Quantity = 30, Description = "High-performance portable SSD", CategoryId = 11, SupplierId = 28 },
                new Product { ProductId = 232, Name = "WD Black SN850X 2TB", Price = 1995.00, Quantity = 40, Description = "PCIe 4.0 NVMe SSD for gaming", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 233, Name = "WD Black SN850X 1TB", Price = 1095.00, Quantity = 60, Description = "Fast 1TB NVMe SSD", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 234, Name = "Samsung 990 PRO 2TB", Price = 2195.00, Quantity = 35, Description = "Premium PCIe 4.0 NVMe SSD", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 235, Name = "Samsung 990 PRO 1TB", Price = 1195.00, Quantity = 55, Description = "High-performance 1TB NVMe", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 236, Name = "Samsung 980 PRO 2TB", Price = 1795.00, Quantity = 45, Description = "Reliable PCIe 4.0 SSD", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 237, Name = "Crucial P5 Plus 2TB", Price = 1495.00, Quantity = 40, Description = "Fast PCIe 4.0 NVMe SSD", CategoryId = 11, SupplierId = 28 },
                new Product { ProductId = 238, Name = "Kingston KC3000 1TB", Price = 995.00, Quantity = 50, Description = "High-speed PCIe 4.0 SSD", CategoryId = 11, SupplierId = 28 },
                new Product { ProductId = 239, Name = "Seagate FireCuda 530 2TB", Price = 2295.00, Quantity = 25, Description = "Gaming NVMe SSD with heatsink", CategoryId = 11, SupplierId = 27 },
                new Product { ProductId = 240, Name = "WD Blue SN570 1TB", Price = 695.00, Quantity = 80, Description = "Budget NVMe SSD", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 241, Name = "Seagate Backup Plus Hub 8TB", Price = 1995.00, Quantity = 30, Description = "Desktop external HDD with USB hub", CategoryId = 11, SupplierId = 27 },
                new Product { ProductId = 242, Name = "WD Elements Desktop 10TB", Price = 2295.00, Quantity = 25, Description = "Large capacity desktop HDD", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 243, Name = "WD My Passport 5TB", Price = 1395.00, Quantity = 50, Description = "Portable external HDD", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 244, Name = "Seagate Expansion 4TB", Price = 995.00, Quantity = 60, Description = "Simple portable storage", CategoryId = 11, SupplierId = 27 },
                new Product { ProductId = 245, Name = "SanDisk Extreme PRO SD Card 256GB", Price = 395.00, Quantity = 100, Description = "UHS-I V30 SD card for cameras", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 246, Name = "SanDisk Extreme SD Card 128GB", Price = 195.00, Quantity = 150, Description = "Fast SD card for photography", CategoryId = 11, SupplierId = 26 },
                new Product { ProductId = 247, Name = "Samsung PRO Plus microSD 256GB", Price = 345.00, Quantity = 120, Description = "Fast microSD for smartphones", CategoryId = 11, SupplierId = 2 },
                new Product { ProductId = 248, Name = "SanDisk Ultra microSD 128GB", Price = 145.00, Quantity = 200, Description = "Affordable microSD card", CategoryId = 11, SupplierId = 26 },

                // Networking (IDs 249-275)
                new Product { ProductId = 249, Name = "ASUS ROG Rapture GT-AXE16000", Price = 6995.00, Quantity = 10, Description = "Quad-band WiFi 6E gaming router", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 250, Name = "ASUS RT-AX88U Pro", Price = 3495.00, Quantity = 18, Description = "WiFi 6 router with 8 ports", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 251, Name = "ASUS RT-AX86U Pro", Price = 2795.00, Quantity = 25, Description = "Gaming WiFi 6 router", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 252, Name = "ASUS ZenWiFi AX6600 (XT8) 2-pack", Price = 4495.00, Quantity = 15, Description = "Mesh WiFi 6 system", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 253, Name = "TP-Link Archer AXE75", Price = 1995.00, Quantity = 30, Description = "WiFi 6E router with tri-band", CategoryId = 12, SupplierId = 30 },
                new Product { ProductId = 254, Name = "TP-Link Archer AX73", Price = 1295.00, Quantity = 40, Description = "WiFi 6 router for medium homes", CategoryId = 12, SupplierId = 30 },
                new Product { ProductId = 255, Name = "TP-Link Deco XE75 Pro 3-pack", Price = 4995.00, Quantity = 20, Description = "WiFi 6E mesh system", CategoryId = 12, SupplierId = 30 },
                new Product { ProductId = 256, Name = "TP-Link Deco X55 3-pack", Price = 2495.00, Quantity = 30, Description = "Affordable WiFi 6 mesh", CategoryId = 12, SupplierId = 30 },
                new Product { ProductId = 257, Name = "Netgear Nighthawk RAXE500", Price = 5995.00, Quantity = 12, Description = "WiFi 6E tri-band router", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 258, Name = "Netgear Orbi RBKE963 WiFi 6E 3-pack", Price = 14995.00, Quantity = 8, Description = "Premium mesh WiFi 6E system", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 259, Name = "Google Nest WiFi Pro 3-pack", Price = 3995.00, Quantity = 25, Description = "WiFi 6E mesh with Matter support", CategoryId = 12, SupplierId = 8 },
                new Product { ProductId = 260, Name = "Ubiquiti UniFi Dream Machine Pro", Price = 4995.00, Quantity = 15, Description = "Professional network gateway", CategoryId = 12, SupplierId = 10 },
                new Product { ProductId = 261, Name = "TP-Link TL-SG108 8-Port Switch", Price = 295.00, Quantity = 80, Description = "Gigabit unmanaged switch", CategoryId = 12, SupplierId = 30 },
                new Product { ProductId = 262, Name = "Netgear GS308P 8-Port PoE Switch", Price = 995.00, Quantity = 40, Description = "Gigabit switch with PoE+", CategoryId = 12, SupplierId = 10 },

                // Kitchen Appliances (IDs 263-295)
                new Product { ProductId = 263, Name = "Electrolux 700 Series Refrigerator", Price = 24995.00, Quantity = 8, Description = "Premium French door refrigerator", CategoryId = 13, SupplierId = 23 },
                new Product { ProductId = 264, Name = "Electrolux UltimateTaste 500 Oven", Price = 12995.00, Quantity = 10, Description = "Built-in multifunction oven", CategoryId = 13, SupplierId = 23 },
                new Product { ProductId = 265, Name = "Electrolux MaxiFlex Induction Hob", Price = 8995.00, Quantity = 12, Description = "Flexible induction cooktop", CategoryId = 13, SupplierId = 23 },
                new Product { ProductId = 266, Name = "Bosch Serie 8 Dishwasher", Price = 13995.00, Quantity = 15, Description = "Premium quiet dishwasher with Home Connect", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 267, Name = "Bosch Serie 6 Washing Machine", Price = 11995.00, Quantity = 12, Description = "9kg front load washer", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 268, Name = "Bosch ErgoMixx Hand Blender", Price = 995.00, Quantity = 40, Description = "Powerful hand blender with accessories", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 269, Name = "KitchenAid Artisan Stand Mixer", Price = 4995.00, Quantity = 25, Description = "Iconic 4.8L stand mixer", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 270, Name = "KitchenAid Artisan Blender", Price = 1995.00, Quantity = 30, Description = "High-performance blender", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 271, Name = "Philips Airfryer XXL", Price = 2495.00, Quantity = 35, Description = "Large capacity air fryer", CategoryId = 13, SupplierId = 22 },
                new Product { ProductId = 272, Name = "Philips 3200 Series Espresso Machine", Price = 5995.00, Quantity = 20, Description = "Fully automatic espresso maker", CategoryId = 13, SupplierId = 22 },
                new Product { ProductId = 273, Name = "Nespresso Vertuo Next", Price = 1495.00, Quantity = 50, Description = "Coffee and espresso machine", CategoryId = 13, SupplierId = 22 },
                new Product { ProductId = 274, Name = "De'Longhi Magnifica S", Price = 4495.00, Quantity = 18, Description = "Bean-to-cup coffee machine", CategoryId = 13, SupplierId = 22 },
                new Product { ProductId = 275, Name = "Sage Barista Express", Price = 6995.00, Quantity = 15, Description = "Manual espresso machine with grinder", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 276, Name = "Vitamix A3500i", Price = 6995.00, Quantity = 12, Description = "Professional blender with smart programs", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 277, Name = "Ninja Foodi 15-in-1 SmartLid", Price = 2995.00, Quantity = 20, Description = "Multi-cooker with pressure and air fry", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 278, Name = "Instant Pot Duo Plus 9-in-1", Price = 1295.00, Quantity = 40, Description = "Electric pressure cooker", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 279, Name = "Smeg Retro Toaster 2-Slice", Price = 1795.00, Quantity = 25, Description = "Stylish 50s style toaster", CategoryId = 13, SupplierId = 22 },
                new Product { ProductId = 280, Name = "Smeg Retro Kettle", Price = 1995.00, Quantity = 22, Description = "1.7L variable temperature kettle", CategoryId = 13, SupplierId = 22 },
                new Product { ProductId = 281, Name = "Cuisinart Food Processor 14-Cup", Price = 2495.00, Quantity = 18, Description = "Large capacity food processor", CategoryId = 13, SupplierId = 24 },
                new Product { ProductId = 282, Name = "OXO Brew 9 Cup Coffee Maker", Price = 1995.00, Quantity = 20, Description = "Pour-over style drip coffee maker", CategoryId = 13, SupplierId = 24 },

                // Office Equipment (IDs 283-310)
                new Product { ProductId = 283, Name = "HP OfficeJet Pro 9125e", Price = 2995.00, Quantity = 25, Description = "All-in-one color inkjet printer", CategoryId = 14, SupplierId = 4 },
                new Product { ProductId = 284, Name = "HP LaserJet Pro M479fdw", Price = 5495.00, Quantity = 15, Description = "Color laser multifunction printer", CategoryId = 14, SupplierId = 4 },
                new Product { ProductId = 285, Name = "Canon PIXMA TR8620", Price = 1995.00, Quantity = 30, Description = "Home office all-in-one printer", CategoryId = 14, SupplierId = 20 },
                new Product { ProductId = 286, Name = "Epson EcoTank ET-4850", Price = 3995.00, Quantity = 20, Description = "Cartridge-free all-in-one with tank", CategoryId = 14, SupplierId = 20 },
                new Product { ProductId = 287, Name = "Brother MFC-L3770CDW", Price = 3495.00, Quantity = 18, Description = "Compact color laser all-in-one", CategoryId = 14, SupplierId = 4 },
                new Product { ProductId = 288, Name = "Fujitsu ScanSnap iX1600", Price = 4995.00, Quantity = 15, Description = "High-speed document scanner", CategoryId = 14, SupplierId = 5 },
                new Product { ProductId = 289, Name = "Epson WorkForce ES-400 II", Price = 2495.00, Quantity = 20, Description = "Compact duplex document scanner", CategoryId = 14, SupplierId = 20 },
                new Product { ProductId = 290, Name = "Fellowes Powershred 99Ci", Price = 2795.00, Quantity = 12, Description = "Cross-cut paper shredder", CategoryId = 14, SupplierId = 4 },
                new Product { ProductId = 291, Name = "Rexel Auto+ 300X", Price = 3495.00, Quantity = 10, Description = "Automatic feed paper shredder", CategoryId = 14, SupplierId = 4 },
                new Product { ProductId = 292, Name = "Epson Expression Photo HD XP-15000", Price = 3995.00, Quantity = 8, Description = "Wide format photo printer", CategoryId = 14, SupplierId = 20 },
                new Product { ProductId = 293, Name = "Dymo LabelWriter 550", Price = 1995.00, Quantity = 25, Description = "Thermal label printer", CategoryId = 14, SupplierId = 4 },
                new Product { ProductId = 294, Name = "GBC Fusion Plus 3000L Laminator", Price = 1295.00, Quantity = 18, Description = "Professional laminator up to A3", CategoryId = 14, SupplierId = 4 },
                new Product { ProductId = 295, Name = "Swingline Stack-and-Shred 750X", Price = 4995.00, Quantity = 8, Description = "Auto-feed super cross-cut shredder", CategoryId = 14, SupplierId = 4 },

                // Components & Parts (IDs 296-330)
                new Product { ProductId = 296, Name = "AMD Ryzen 9 7950X", Price = 5995.00, Quantity = 15, Description = "16-core desktop processor", CategoryId = 16, SupplierId = 11 },
                new Product { ProductId = 297, Name = "AMD Ryzen 7 7800X3D", Price = 4495.00, Quantity = 25, Description = "8-core gaming processor with 3D V-Cache", CategoryId = 16, SupplierId = 11 },
                new Product { ProductId = 298, Name = "AMD Ryzen 5 7600X", Price = 2495.00, Quantity = 35, Description = "6-core mainstream processor", CategoryId = 16, SupplierId = 11 },
                new Product { ProductId = 299, Name = "Intel Core i9-14900K", Price = 6495.00, Quantity = 12, Description = "24-core flagship desktop CPU", CategoryId = 16, SupplierId = 29 },
                new Product { ProductId = 300, Name = "Intel Core i7-14700K", Price = 4495.00, Quantity = 20, Description = "20-core performance CPU", CategoryId = 16, SupplierId = 29 },
                new Product { ProductId = 301, Name = "Intel Core i5-14600K", Price = 3295.00, Quantity = 30, Description = "14-core mainstream CPU", CategoryId = 16, SupplierId = 29 },
                new Product { ProductId = 302, Name = "NVIDIA GeForce RTX 4090", Price = 19995.00, Quantity = 8, Description = "Flagship graphics card", CategoryId = 16, SupplierId = 12 },
                new Product { ProductId = 303, Name = "NVIDIA GeForce RTX 4080 SUPER", Price = 12995.00, Quantity = 12, Description = "High-end graphics card", CategoryId = 16, SupplierId = 12 },
                new Product { ProductId = 304, Name = "NVIDIA GeForce RTX 4070 Ti SUPER", Price = 8995.00, Quantity = 18, Description = "Performance graphics card", CategoryId = 16, SupplierId = 12 },
                new Product { ProductId = 305, Name = "NVIDIA GeForce RTX 4070 SUPER", Price = 6995.00, Quantity = 25, Description = "Upper-midrange GPU", CategoryId = 16, SupplierId = 12 },
                new Product { ProductId = 306, Name = "NVIDIA GeForce RTX 4060 Ti 16GB", Price = 5495.00, Quantity = 30, Description = "Midrange graphics card", CategoryId = 16, SupplierId = 12 },
                new Product { ProductId = 307, Name = "AMD Radeon RX 7900 XTX", Price = 10995.00, Quantity = 15, Description = "High-end AMD graphics card", CategoryId = 16, SupplierId = 11 },
                new Product { ProductId = 308, Name = "AMD Radeon RX 7800 XT", Price = 5495.00, Quantity = 22, Description = "Performance 1440p graphics card", CategoryId = 16, SupplierId = 11 },
                new Product { ProductId = 309, Name = "AMD Radeon RX 7600", Price = 2995.00, Quantity = 35, Description = "Budget 1080p graphics card", CategoryId = 16, SupplierId = 11 },
                new Product { ProductId = 310, Name = "Corsair Vengeance DDR5 32GB 6000MHz", Price = 1495.00, Quantity = 50, Description = "High-speed DDR5 RAM kit", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 311, Name = "G.Skill Trident Z5 RGB 32GB 6400MHz", Price = 1795.00, Quantity = 40, Description = "Premium DDR5 with RGB", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 312, Name = "Kingston Fury Beast DDR4 32GB 3200MHz", Price = 895.00, Quantity = 60, Description = "Reliable DDR4 RAM", CategoryId = 16, SupplierId = 28 },
                new Product { ProductId = 313, Name = "ASUS ROG Strix Z790-E Gaming WiFi", Price = 4995.00, Quantity = 15, Description = "Premium Intel Z790 motherboard", CategoryId = 16, SupplierId = 10 },
                new Product { ProductId = 314, Name = "MSI MAG B650 Tomahawk WiFi", Price = 2495.00, Quantity = 25, Description = "Mid-range AMD B650 motherboard", CategoryId = 16, SupplierId = 10 },
                new Product { ProductId = 315, Name = "Corsair RM1000e 1000W", Price = 1995.00, Quantity = 20, Description = "Fully modular 80+ Gold PSU", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 316, Name = "Corsair RM850x 850W", Price = 1495.00, Quantity = 30, Description = "850W 80+ Gold modular PSU", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 317, Name = "NZXT H7 Flow", Price = 1495.00, Quantity = 25, Description = "Mid-tower case with excellent airflow", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 318, Name = "Fractal Design Torrent", Price = 1795.00, Quantity = 20, Description = "High-airflow mid-tower case", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 319, Name = "Lian Li O11 Dynamic EVO", Price = 1695.00, Quantity = 22, Description = "Popular enthusiast case", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 320, Name = "Corsair iCUE H150i Elite LCD", Price = 2995.00, Quantity = 18, Description = "360mm AIO with LCD display", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 321, Name = "NZXT Kraken 360 RGB", Price = 1795.00, Quantity = 25, Description = "360mm RGB AIO cooler", CategoryId = 16, SupplierId = 25 },
                new Product { ProductId = 322, Name = "Noctua NH-D15", Price = 1095.00, Quantity = 30, Description = "Premium dual-tower air cooler", CategoryId = 16, SupplierId = 10 },
                new Product { ProductId = 323, Name = "Arctic Liquid Freezer III 360", Price = 1295.00, Quantity = 28, Description = "High-performance budget AIO", CategoryId = 16, SupplierId = 10 },

                // Smart Devices (IDs 324-350)
                new Product { ProductId = 324, Name = "Meta Quest 3 128GB", Price = 5495.00, Quantity = 25, Description = "Mixed reality VR headset", CategoryId = 17, SupplierId = 7 },
                new Product { ProductId = 325, Name = "Meta Quest 3 512GB", Price = 6495.00, Quantity = 18, Description = "High storage VR headset", CategoryId = 17, SupplierId = 7 },
                new Product { ProductId = 326, Name = "Meta Ray-Ban Smart Glasses", Price = 3295.00, Quantity = 20, Description = "Smart glasses with camera and audio", CategoryId = 17, SupplierId = 7 },
                new Product { ProductId = 327, Name = "Amazon Kindle Paperwhite", Price = 1495.00, Quantity = 60, Description = "Waterproof e-reader with 6.8\" display", CategoryId = 17, SupplierId = 8 },
                new Product { ProductId = 328, Name = "Amazon Kindle Oasis", Price = 2795.00, Quantity = 25, Description = "Premium e-reader with 7\" display", CategoryId = 17, SupplierId = 8 },
                new Product { ProductId = 329, Name = "Amazon Fire HD 10", Price = 1495.00, Quantity = 70, Description = "10.1\" entertainment tablet", CategoryId = 17, SupplierId = 8 },
                new Product { ProductId = 330, Name = "Remarkable 2", Price = 4495.00, Quantity = 15, Description = "Digital paper tablet for notes", CategoryId = 17, SupplierId = 8 },
                new Product { ProductId = 331, Name = "Tile Slim Wallet Tracker", Price = 395.00, Quantity = 100, Description = "Credit card sized Bluetooth tracker", CategoryId = 17, SupplierId = 8 },
                new Product { ProductId = 332, Name = "Chipolo One Spot 4-pack", Price = 895.00, Quantity = 60, Description = "Works with Apple Find My", CategoryId = 17, SupplierId = 8 },
                new Product { ProductId = 333, Name = "Withings Body+ Smart Scale", Price = 995.00, Quantity = 40, Description = "WiFi scale with body composition", CategoryId = 17, SupplierId = 22 },
                new Product { ProductId = 334, Name = "Withings ScanWatch 2", Price = 3495.00, Quantity = 18, Description = "Hybrid smartwatch with health sensors", CategoryId = 17, SupplierId = 22 },
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
            try
            {
                // Ensure the database and tables exist
                //await context.Database.EnsureCreatedAsync();

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
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                throw new InvalidOperationException("Failed to seed database data", ex);
            }
        }
    }
}
