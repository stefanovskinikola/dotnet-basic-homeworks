List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};

// ====================================================================================================
// Retrieve all products with a price greater than $500.
// ====================================================================================================
var greaterThan500Method = products.Where(product => product.Price > 500).ToList();
var greaterThan500Query = (from product in products
                           where product.Price > 500
                           select product).ToList();

Console.WriteLine("All products with a price greater than $500:");
foreach (var product in greaterThan500Method)
{
    Console.WriteLine($"{product.Title} - ${product.Price}");
}

// ====================================================================================================
// Retrive all Skincare products.
// ====================================================================================================
var allSkincareProductsMethod = products.Where(product => product.Category == ProductCategory.Skincare).ToList();
var allSkincareProductsQuery = (from product in products
                                where product.Category == ProductCategory.Skincare
                                select product).ToList();

Console.WriteLine("\nAll Skincare products:");
foreach (var product in allSkincareProductsMethod)
{
    Console.WriteLine($"{product.Title}");
}

// ====================================================================================================
// Retrive all products titles.
// ====================================================================================================
var allProductsTitlesMethod = products.Select(product => product.Title).ToList();
var allProductsTitlesQuery = (from product in products
                              select product.Title).ToList();

Console.WriteLine("\nAll product titles:");
foreach (var title in allProductsTitlesMethod)
{
    Console.WriteLine(title);
}

// ====================================================================================================
// Select the titles of all products in the "Laptops" category.
// ====================================================================================================
var allLaptopTitlesMethod = products.Where(product => product.Category == ProductCategory.Laptops).Select(product => product.Title).ToList();
var allLaptopTitlesQuery = (from product in products
                            where product.Category == ProductCategory.Laptops
                            select product.Title).ToList();

Console.WriteLine("\nTitles of all products in the 'Laptops' category:");
foreach (var title in allLaptopTitlesMethod)
{
    Console.WriteLine(title);
}

// ====================================================================================================
// Select the descriptions of all products with a stock of less than 50.
// ====================================================================================================
var allLowStockDescriptionsMethod = products.Where(product => product.Stock < 50).Select(product => product.Description).ToList();
var allLowStockDescriptionsQuery = (from product in products
                                    where product.Stock < 50
                                    select product.Description).ToList();

Console.WriteLine("\nDescriptions of all products with a stock of less than 50:");
foreach (var description in allLowStockDescriptionsMethod)
{
    Console.WriteLine(description);
}

// ====================================================================================================
// Retrieve the titles of all products with a rating above 4.5.
// ====================================================================================================
var allHighRatingTitlesMethod = products.Where(product => product.Rating > 4.5).Select(product => product.Title).ToList();
var allHighRatingTitlesQuery = (from product in products
                                where product.Rating > 4.5
                                select product.Title).ToList();

Console.WriteLine("\nTitles of all products with a rating above 4.5:");
foreach (var title in allHighRatingTitlesMethod)
{
    Console.WriteLine(title);
}

// ====================================================================================================
// Select the titles of all products with a price between $100 and $200.
// ====================================================================================================
var allMidRangeTitlesMethod = products.Where(product => product.Price >= 100 && product.Price <= 200).Select(product => product.Title).ToList();
var allMidRangeTitlesQuery = (from product in products
                              where product.Price >= 100 && product.Price <= 200
                              select product.Title).ToList();

Console.WriteLine("\nTitles of all products with a price between $100 and $200:");
foreach (var title in allMidRangeTitlesMethod)
{
    Console.WriteLine(title);
}

// ====================================================================================================
// Select the titles of all products from the "Fragrances" category with a rating above 4.6.
// ====================================================================================================
var allHighRatedFragranceTitlesMethod = products.Where(product => product.Category == ProductCategory.Fragrances && product.Rating > 4.6).Select(product => product.Title).ToList();
var allHighRatedFragranceTitlesQuery = (from product in products
                                        where product.Category == ProductCategory.Fragrances && product.Rating > 4.6
                                        select product.Title).ToList();

Console.WriteLine("\nTitles of all products from the 'Fragrances' category with a rating above 4.6:");
foreach (var title in allHighRatedFragranceTitlesMethod)
{
    Console.WriteLine(title);
}

// ====================================================================================================
// Retrieve the brands of all products with a price above $1000.
// ====================================================================================================
var allHighPriceBrandsMethod = products.Where(product => product.Price > 1000).Select(product => product.Brand).ToList();
var allHighPriceBrandsQuery = (from product in products
                               where product.Price > 1000
                               select product.Brand).ToList();

Console.WriteLine("\nBrands of all products with a price above $1000:");
foreach (var brand in allHighPriceBrandsMethod)
{
    Console.WriteLine(brand);
}

// ====================================================================================================
// Select the titles of all products with the word "perfume" in the title.
// ====================================================================================================
var allPerfumeTitlesMethod = products.Where(product => product.Title.ToLower().Contains("perfume")).Select(product => product.Title).ToList();
var allPerfumeTitlesQuery = (from product in products
                             where product.Title.ToLower().Contains("perfume")
                             select product.Title).ToList();

Console.WriteLine("\nTitles of all products with the word 'perfume' in the title:");
foreach (var title in allPerfumeTitlesMethod)
{
    Console.WriteLine(title);
}

// ====================================================================================================
// Find the last Grocery product.
// ====================================================================================================
var lastGroceryProductMethod = products.LastOrDefault(product => product.Category == ProductCategory.Groceries);
var lastGroceryProductQuery = (from product in products
                               where product.Category == ProductCategory.Groceries
                               select product).LastOrDefault();

Console.WriteLine("\nThe last Grocery product:");
if (lastGroceryProductMethod != null)
{
    Console.WriteLine($"{lastGroceryProductMethod.Title}");
}
else
{
    Console.WriteLine("No Grocery products were found.");
}

// ====================================================================================================
// Find the first product with a price above $1000.
// ====================================================================================================
var firstHighPriceProductMethod = products.FirstOrDefault(product => product.Price > 1000);
var firstHighPriceProductQuery = (from product in products
                                  where product.Price > 1000
                                  select product).FirstOrDefault();

Console.WriteLine("\nThe first product with a price above $1000:");
if (firstHighPriceProductMethod != null)
{
    Console.WriteLine($"{firstHighPriceProductMethod.Title}");
}
else
{
    Console.WriteLine("No products over $1000 were found.");
}

// ====================================================================================================
// Select the titles of all products from the "Groceries" category with a stock above 150.
// ====================================================================================================
var allHighStockGroceryTitlesMethod = products.Where(product => product.Category == ProductCategory.Groceries && product.Stock > 150).Select(product => product.Title).ToList();
var allHighStockGroceryTitlesQuery = (from product in products
                                      where product.Category == ProductCategory.Groceries && product.Stock > 150
                                      select product.Title).ToList();

Console.WriteLine("\nTitles of all products from the 'Groceries' category with a stock above 150:");
foreach (var title in allHighStockGroceryTitlesMethod)
{
    Console.WriteLine(title);
}

// ====================================================================================================
// Find the first item from the brand "Hemani Tea".
// ====================================================================================================
var firstHemaniTeaProductMethod = products.FirstOrDefault(product => product.Brand == "Hemani Tea");
var firstHemaniTeaProductQuery = (from product in products
                                  where product.Brand == "Hemani Tea"
                                  select product).FirstOrDefault();

Console.WriteLine("\nThe first item from the brand 'Hemani Tea':");
if (firstHemaniTeaProductMethod != null)
{
    Console.WriteLine($"{firstHemaniTeaProductMethod.Title}");
}
else
{
    Console.WriteLine("No products from the brand 'Hemani Tea' were found.");
}

// ====================================================================================================
// Retrieve the ratings of all products with a stock between 30 and 50.
// ====================================================================================================
var allRatingsLowStockMethod = products.Where(product => product.Stock >= 30 && product.Stock <= 50).Select(product => product.Rating).ToList();
var allRatingsLowStockQuery = (from product in products
                               where product.Stock >= 30 && product.Stock <= 50
                               select product.Rating).ToList();

Console.WriteLine("\nRatings of all products with a stock between 30 and 50:");
foreach (var rating in allRatingsLowStockMethod)
{
    Console.WriteLine(rating);
}

// ====================================================================================================
// Find the average price of all products.
// ====================================================================================================
var averagePriceMethod = products.Average(product => product.Price);
var averagePriceQuery = (from product in products
                         select product.Price).Average();

Console.WriteLine("\nThe average price of all products:");
Console.WriteLine($"{averagePriceMethod:F2}");

// ====================================================================================================
// Find the total stock of all products.
// ====================================================================================================
var totalStockMethod = products.Sum(product => product.Stock);
var totalStockQuery = (from product in products
                       select product.Stock).Sum();

Console.WriteLine("\nThe total stock of all products:");
Console.WriteLine(totalStockMethod);

// ====================================================================================================
// Check if there is any product with price over $2000.
// ====================================================================================================
var anyOver2000Method = products.Any(product => product.Price > 2000);
var anyOver2000Query = (
    from product in products
    where product.Price > 2000
    select product).Any();

if (anyOver2000Method)
{
    Console.WriteLine("\nThere is at least one product with a price over $2000.");
}
else
{
    Console.WriteLine("\nThere are no products with a price over $2000.");
}

// ====================================================================================================
// Find the most expensive Laptop.
// ====================================================================================================

var mostExpensiveLaptopMethod = products.Where(product => product.Category == ProductCategory.Laptops).MaxBy(product => product.Price);
var mostExpensiveLaptopQuery = (from product in products
                                where product.Category == ProductCategory.Laptops
                                select product).MaxBy(product => product.Price);

Console.WriteLine("\nThe most expensive Laptop:");
if (mostExpensiveLaptopMethod != null)
{
    Console.WriteLine($"{mostExpensiveLaptopMethod.Title} - ${mostExpensiveLaptopMethod.Price}");
}
else
{
    Console.WriteLine("No Laptops were found in the inventory.");
}

// ====================================================================================================
// Retrieve the titles and descriptions of all products from the "Skincare" category.
// ====================================================================================================

var skincareProductsMethod = products.Where(product => product.Category == ProductCategory.Skincare).Select(product => new { product.Title, product.Description }).ToList();
var skincareProductsQuery = (
    from product in products
    where product.Category == ProductCategory.Skincare
    select new { product.Title, product.Description }).ToList();

Console.WriteLine("\nTitles and descriptions of all products from the 'Skincare' category:");
foreach (var product in skincareProductsMethod)
{
    Console.WriteLine($"{product.Title} - {product.Description}");
}