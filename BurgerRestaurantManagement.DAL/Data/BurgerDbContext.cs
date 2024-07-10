using Microsoft.EntityFrameworkCore;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class BurgerDbContext : DbContext
    {
        public BurgerDbContext(DbContextOptions<BurgerDbContext> options) : base(options) { }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<IngredientDetail> IngredientsDetails { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
