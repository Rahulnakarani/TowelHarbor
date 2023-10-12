using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TowelHarbor.Data;

namespace TowelHarbor.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TowelHarborContext(serviceProvider.GetRequiredService<DbContextOptions<TowelHarborContext>>()))
            {
                if (context.Towels.Any())
                {
                    return;   // DB has been seeded
                }

                context.Towels.AddRange(
                    new Towels
                    {
                        Name = "Luxurious Spa-Quality",
                        Type = "Bath Towel",
                        Material = "100% Cotton",
                        Stock = 100,
                        Price = 20,
                        Description = "Indulge in the ultimate bathing experience with our spa-quality bath towel. Crafted from 100% plush cotton, it offers exceptional softness, absorbency, and durability. Its generous size ensures you're wrapped in comfort, making it perfect for a relaxing post-shower ritual."
                    },

                    new Towels
                    {
                        Name = "Embroidered Elegance",
                        Type = "Hand Towel",
                        Material = "Microfiber",
                        Stock = 150,
                        Price = 10,
                        Description = "Elevate your hand-drying experience with our embroidered elegance hand towel. These towels are adorned with intricate and stylish embroidery, adding a touch of sophistication to your bathroom or powder room. The fine cotton fabric ensures gentle and effective drying, while the elegant design enhances your space's aesthetics."
                    },

                    new Towels
                    {
                        Name = "Classic Elegance",
                        Type = "Bath Towel",
                        Material = "100% Cotton",
                        Stock = 150,
                        Price = 25,
                        Description = "Elevate your bathroom decor with our Classic Elegance bath towel. Made from high-quality, long-staple cotton, it exudes timeless sophistication and charm. The meticulously woven fabric not only feels exceptionally soft against your skin but also adds a touch of luxury to your daily routine. Wrap yourself in elegance with our carefully crafted bath towel."
                    },
                    
                    new Towels
                    {
                        Name = "Quick-Dry Microfiber",
                        Type = "Bath Towel",
                        Material = "Linen",
                        Stock = 200,
                        Price = 20,
                        Description = "Say goodbye to damp, heavy towels with our quick-dry microfiber bath towel. It's designed for modern, on-the-go lifestyles, featuring ultra-absorbent microfiber material that dries you off in no time. The lightweight and compact design makes it ideal for travel and active individuals."
                    },

                    new Towels
                    {
                        Name = "Tropical Paradise",
                        Type = "Beach Towel",
                        Material = "Microfiber",
                        Stock = 158,
                        Price = 50,
                        Description = "Transport yourself to a tropical paradise with our vibrant beach towel. This oversized, ultra-soft towel is perfect for a day at the beach or by the pool. Its colorful, eye-catching design features palm trees, vibrant sunsets, and soft, absorbent material that lets you relax in style."
                    },

                    new Towels
                    {
                        Name = "Farmhouse Chic",
                        Type = "Kitchen Towel",
                        Material = "Linen",
                        Stock = 50,
                        Price = 15,
                        Description = "Add a touch of rustic charm to your kitchen with our Farmhouse Chic kitchen towels. These towels are not just practical but also decorative, featuring classic checkered patterns and a farmhouse-inspired color palette. They are perfect for drying dishes, lining baskets, or simply hanging on the oven handle for that cozy farmhouse look."
                    },

                    new Towels
                    {
                        Name = "Eco-Friendly Bamboo",
                        Type = "Bath Towel",
                        Material = "Bamboo",
                        Stock = 200,
                        Price = 20,
                        Description = "Our eco-conscious bamboo bath towel is not only incredibly soft and luxurious but also eco-friendly. Crafted from sustainable bamboo fibers, it's naturally antibacterial and hypoallergenic, making it the perfect choice for those with sensitive skin. Pamper yourself while contributing to a greener planet."
                    },

                    new Towels
                    {
                        Name = "Ultra-Absorbent",
                        Type = "Kitchen Towel",
                        Material = "100% Cotton",
                        Stock = 500,
                        Price = 20,
                        Description = "Our kitchen towel set is a chef's best friend in the kitchen. These ultra-absorbent towels are designed to tackle spills and messes with ease. Their soft, lint-free, and quick-drying fabric makes them perfect for drying dishes, wiping counters, and even doubling as a stylish hand towel. Keep your kitchen spotless with this essential set."
                    },

                    new Towels
                    {
                        Name = "Sand-Free",
                        Type = "Beach Towel",
                        Material = "Microfiber",
                        Stock = 100,
                        Price = 50,
                        Description = "Transport yourself to a tropical paradise with our vibrant beach towel. This oversized, ultra-soft towel is perfect for a day at the beach or by the pool. Its colorful, eye-catching design features palm trees, vibrant sunsets, and soft, absorbent material that lets you relax in style."
                    },

                    new Towels
                    {
                        Name = "Velvet Touch",
                        Type = "Hand Towel",
                        Material = "Velvet",
                        Stock = 150,
                        Price = 10,
                        Description = "Our velvet touch hand towel offers an exquisite, plush feel that's second to none. With its fine combed cotton fibers, these towels provide exceptional softness and quick moisture absorption. Keep them in your guest bathroom for an added touch of luxury or in your kitchen for convenient hand-drying."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
