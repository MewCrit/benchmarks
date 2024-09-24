


namespace Benches.Data;

public class ProductData
{
    public List<Product> ProductSamples { get; set; }

    public ProductData()
    {
        ProductSamples = new List<Product>
            {
                new Product
                {
                    ID = "P001",
                    ItemName = "Smartphone",
                    Brand = "TechBrand",
                    ItemType = "Electronics",
                    Price = 599.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "Color", Value = "Black" },
                        new ProductAttributes { Name = "Storage", Value = "128GB" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "TechVendor",
                        Location = "New York",
                        Country = "USA",
                        ZipCode = "10001",
                        Description = "Leading electronics provider."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "Alice", Rating = 5, Comment = "Great product!" },
                        new Reviews { ReviewerName = "Bob", Rating = 4, Comment = "Very good, but battery life could be better." }
                    },
                    CreatedDate = DateTime.Now.AddDays(-30)
                },
                new Product
                {
                    ID = "P002",
                    ItemName = "Running Shoes",
                    Brand = "FitBrand",
                    ItemType = "Sportswear",
                    Price = 89.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "Size", Value = "10" },
                        new ProductAttributes { Name = "Color", Value = "Red" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "FitVendor",
                        Location = "San Francisco",
                        Country = "USA",
                        ZipCode = "94103",
                        Description = "Top sportswear brand."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "John", Rating = 5, Comment = "Very comfortable and durable." },
                        new Reviews { ReviewerName = "Emma", Rating = 4, Comment = "Stylish and lightweight." }
                    },
                    CreatedDate = DateTime.Now.AddDays(-60)
                },
                new Product
                {
                    ID = "P003",
                    ItemName = "Coffee Maker",
                    Brand = "HomeAppliances",
                    ItemType = "Kitchen",
                    Price = 49.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "Capacity", Value = "12 Cups" },
                        new ProductAttributes { Name = "Color", Value = "White" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "HomeApplianceVendor",
                        Location = "Los Angeles",
                        Country = "USA",
                        ZipCode = "90001",
                        Description = "Appliances for modern homes."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "Sophia", Rating = 3, Comment = "Decent, but takes time to brew." },
                        new Reviews { ReviewerName = "Michael", Rating = 4, Comment = "Good value for the price." }
                    },
                    CreatedDate = DateTime.Now.AddDays(-90)
                },
                new Product
                {
                    ID = "P004",
                    ItemName = "Gaming Laptop",
                    Brand = "GameTech",
                    ItemType = "Electronics",
                    Price = 1299.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "RAM", Value = "16GB" },
                        new ProductAttributes { Name = "Graphics Card", Value = "NVIDIA RTX 3060" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "GameHub",
                        Location = "Seattle",
                        Country = "USA",
                        ZipCode = "98101",
                        Description = "Specializes in gaming products."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "Chris", Rating = 5, Comment = "Best gaming experience so far." },
                        new Reviews { ReviewerName = "Lily", Rating = 4, Comment = "High performance, but a bit heavy." }
                    },
                    CreatedDate = DateTime.Now.AddDays(-45)
                },
                new Product
                {
                    ID = "P005",
                    ItemName = "Blender",
                    Brand = "KitchenPlus",
                    ItemType = "Home Appliance",
                    Price = 39.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "Power", Value = "600W" },
                        new ProductAttributes { Name = "Capacity", Value = "1.5 Liters" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "HomeGadgets",
                        Location = "Miami",
                        Country = "USA",
                        ZipCode = "33101",
                        Description = "Kitchen essentials and gadgets."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "Maria", Rating = 4, Comment = "Good for smoothies, but a bit noisy." },
                        new Reviews { ReviewerName = "James", Rating = 5, Comment = "Great value for money!" }
                    },
                    CreatedDate = DateTime.Now.AddDays(-100)
                },
                new Product
                {
                    ID = "P006",
                    ItemName = "Wireless Headphones",
                    Brand = "SoundWave",
                    ItemType = "Audio",
                    Price = 199.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "Battery Life", Value = "30 Hours" },
                        new ProductAttributes { Name = "Noise Cancellation", Value = "Yes" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "SoundWorld",
                        Location = "Austin",
                        Country = "USA",
                        ZipCode = "73301",
                        Description = "Premium audio devices."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "Lucas", Rating = 5, Comment = "Amazing sound quality and comfort." },
                        new Reviews { ReviewerName = "Olivia", Rating = 4, Comment = "Battery lasts long, but pricey." }
                    },
                    CreatedDate = DateTime.Now.AddDays(-15)
                },
        
                new Product
                {
                    ID = "P007",
                    ItemName = "Electric Scooter",
                    Brand = "EcoRide",
                    ItemType = "Transport",
                    Price = 499.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "Max Speed", Value = "25 km/h" },
                        new ProductAttributes { Name = "Battery Life", Value = "40 km" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "RideTech",
                        Location = "Boston",
                        Country = "USA",
                        ZipCode = "02108",
                        Description = "Specializes in eco-friendly transportation solutions."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "Diana", Rating = 4, Comment = "Smooth ride but charging takes a while." },
                        new Reviews { ReviewerName = "Mark", Rating = 5, Comment = "Great for commuting!" }
                    },
                    CreatedDate = DateTime.Now.AddDays(-50)
                },

                new Product
                {
                    ID = "P008",
                    ItemName = "Smartwatch",
                    Brand = "TimePro",
                    ItemType = "Wearable",
                    Price = 149.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "Water Resistance", Value = "50m" },
                        new ProductAttributes { Name = "Battery Life", Value = "7 days" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "GadgetWorld",
                        Location = "Chicago",
                        Country = "USA",
                        ZipCode = "60601",
                        Description = "Innovative gadgets and wearables."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "Tom", Rating = 5, Comment = "Amazing battery life and features!" },
                        new Reviews { ReviewerName = "Nina", Rating = 4, Comment = "Great but needs more apps." }
                    },
                    CreatedDate = DateTime.Now.AddDays(-80)
                },

                new Product
                {
                    ID = "P009",
                    ItemName = "4K TV",
                    Brand = "VisionTech",
                    ItemType = "Electronics",
                    Price = 799.99M,
                    Attributes = new List<ProductAttributes>
                    {
                        new ProductAttributes { Name = "Screen Size", Value = "55 inches" },
                        new ProductAttributes { Name = "Resolution", Value = "3840 x 2160" }
                    },
                    Vendor = new Vendor
                    {
                        VendorName = "TechDeals",
                        Location = "Houston",
                        Country = "USA",
                        ZipCode = "77001",
                        Description = "Affordable electronics and gadgets."
                    },
                    Reviews = new List<Reviews>
                    {
                        new Reviews { ReviewerName = "Jake", Rating = 5, Comment = "Picture quality is outstanding!" },
                        new Reviews { ReviewerName = "Sarah", Rating = 4, Comment = "Great TV, but sound could be better." }
                    },
                    CreatedDate = DateTime.Now.AddDays(-20)
                }
                
                
                    };
    }

    public List<Product> ProductsSamples() => ProductSamples;

}



public class Product
{
    public string ID { get; set; }

    public string ItemName { get; set; }

    public string Brand { get; set; }

    public string ItemType { get; set; }

    public decimal Price { get; set; }

    public IList<ProductAttributes> Attributes { get; set; }

    public Vendor Vendor { get; set; }

    public IList<Reviews> Reviews { get; set; }

    public DateTime CreatedDate { get; set; }
}

public class ProductAttributes
{
    public string Name { get; set; }

    public string Value { get; set; }
}

public class Vendor
{
    public string VendorName { get; set; }

    public string Location { get; set; }

    public string Country { get; set; }

    public string ZipCode { get; set; }

    public string Description { get; set; }
}


public class Reviews
{

    public string ReviewerName { get; set; }

    public int Rating { get; set; }


    public string Comment { get; set; }

}




