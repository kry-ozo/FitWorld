using FitWord.Models;
using FitWorld.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitWorld.Database
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Meal> Meal { get; set; }
        public DbSet<Plan> Plan { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Meals)
                .WithOne(m=>m.User)
                .HasForeignKey(m=>m.MealOwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ApplicationUser>()
               .HasMany(u => u.Plans)
               .WithOne(m => m.User)
               .HasForeignKey(m => m.PlanOwnerId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<Meal>().HasData(
                new { mealId = 1, mealName = "poncho", mealDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", mealProtein = 15, mealFat = 15, mealCarbs = 15, MealOwnerId = "f20b2581-3c7f-469c-ac8a-d574be99e067", pdfMeal=new byte[] { 0x45, 0xAF } },
                new { mealId = 2, mealName = "flavor soup", mealDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", mealProtein = 15, mealFat = 15, mealCarbs = 15, MealOwnerId = "f20b2581-3c7f-469c-ac8a-d574be99e067", pdfMeal = new byte[] { 0x45, 0xAF } },
                new { mealId = 3, mealName = "chciken breast", mealDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", mealProtein = 15, mealFat = 15, mealCarbs = 15, MealOwnerId = "f20b2581-3c7f-469c-ac8a-d574be99e067", pdfMeal = new byte[] { 0x45, 0xAF } }
            );

            modelBuilder.Entity<Plan>().HasData(
                new { planId = 1, planName = "Push Pull", planDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", planDays = 4, planLevel = 0, PlanOwnerId = "f20b2581-3c7f-469c-ac8a-d574be99e067", pdfPlan = new byte[] { 0x45, 0xAF, 0x23 } },
                new { planId = 2, planName = "Upper Lower", planDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", planDays = 4, planLevel = 0, PlanOwnerId = "f20b2581-3c7f-469c-ac8a-d574be99e067", pdfPlan = new byte[] { 0x45, 0xAF, 0x23 } },
                new { planId = 3, planName = "Split", planDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", planDays = 4, planLevel = 0, PlanOwnerId = "f20b2581-3c7f-469c-ac8a-d574be99e067", pdfPlan = new byte[] { 0x45, 0xAF, 0x23 } }

                );

        }

    }
}
