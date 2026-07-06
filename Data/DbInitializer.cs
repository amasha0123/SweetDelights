using SweetDelights.Models;

namespace SweetDelights.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Look for any cakes.
            if (context.Cakes.Any())
            {
                return;   // DB has been seeded
            }

            var cakes = new Cake[]
            {
                new Cake { 
                    Name = "Decadent Black Forest", 
                    Category = "Chocolate", 
                    Description = "Multiple layers of chocolate sponge cake with cherries and whipped cream, sprinkled with chocolate shavings.", 
                    Price = 45.00m, 
                    ImageUrl = "https://images.unsplash.com/photo-1578985545062-69928b1d9587?q=80&w=2000&auto=format&fit=crop", 
                    Weight = "1.5 kg", 
                    IsAvailable = true 
                },
                new Cake { 
                    Name = "Classic Red Velvet", 
                    Category = "Red Velvet", 
                    Description = "Soft, moist, and fluffy red velvet layers with a luxurious cream cheese frosting.", 
                    Price = 55.50m, 
                    ImageUrl = "https://images.unsplash.com/photo-1616541823729-00fe0aacd32c?q=80&w=2000&auto=format&fit=crop", 
                    Weight = "1.2 kg", 
                    IsAvailable = true 
                },
                new Cake { 
                    Name = "Strawberry Bliss Cheesecake", 
                    Category = "Cheesecake", 
                    Description = "A smooth and creamy New York style cheesecake topped with fresh glazed strawberries.", 
                    Price = 60.00m, 
                    ImageUrl = "https://images.unsplash.com/photo-1571115177098-24ec42ed204d?q=80&w=2000&auto=format&fit=crop", 
                    Weight = "1.0 kg", 
                    IsAvailable = true 
                },
                new Cake { 
                    Name = "Lemon Blueberry Delight", 
                    Category = "Fruit Cake", 
                    Description = "Zesty lemon cake layers infused with fresh blueberries, coated in a light buttercream.", 
                    Price = 50.00m, 
                    ImageUrl = "https://images.unsplash.com/photo-1565958011703-44f9829ba187?q=80&w=2000&auto=format&fit=crop", 
                    Weight = "1.2 kg", 
                    IsAvailable = true 
                },
                new Cake { 
                    Name = "Ultimate Chocolate Fudge", 
                    Category = "Chocolate", 
                    Description = "A dense, rich chocolate cake covered in a thick layer of glossy chocolate fudge frosting.", 
                    Price = 65.00m, 
                    ImageUrl = "https://images.unsplash.com/photo-1606890737304-57a1ca8a5b62?q=80&w=2000&auto=format&fit=crop", 
                    Weight = "2.0 kg", 
                    IsAvailable = true 
                },
                new Cake { 
                    Name = "Elegant Vanilla Bean", 
                    Category = "Vanilla", 
                    Description = "Classic vanilla bean cake with a delicate crumb and a silky smooth Swiss meringue buttercream.", 
                    Price = 40.00m, 
                    ImageUrl = "https://images.unsplash.com/photo-1535141192574-5d4897c12636?q=80&w=2000&auto=format&fit=crop", 
                    Weight = "1.0 kg", 
                    IsAvailable = true 
                }
            };

            foreach (var c in cakes)
            {
                context.Cakes.Add(c);
            }
            context.SaveChanges();
        }
    }
}
