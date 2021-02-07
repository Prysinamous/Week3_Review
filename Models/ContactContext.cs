using Microsoft.EntityFrameworkCore;
using System;

namespace Week3_Review.Models
{
    public class ContactContext : DbContext
    {

        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        DbSet<Contact> Contacts {get; set;}
        DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 1, Name = "Work" },
                new Category { CategoryId = 1, Name = "Other" }

                );


            modelBuilder.Entity<Contact>().HasData
               (
               new Contact {
                   ContactId=1, 
                   FirstName= "Obi Wan",
                   LastName="Kenobi", 
                   Phone= "416-556-7845",
                   Email= "hellothere@gmail.com",
                   CategoryId=1, 
                   DateAdded= DateTime.Now},
               

                new Contact
                {
                    ContactId = 2,
                    FirstName = "Anakin",
                    LastName = "Skywalker",
                    Phone = "647-567-8691",
                    Email = "ihatesand@gmail.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                },

                    new Contact
                    {
                        ContactId = 3,
                        FirstName = "Padme",
                        LastName = "Amidala",
                        Phone = "647-2920-333",
                        Email = "queen@gmail.com",
                        CategoryId = 3,
                        DateAdded = DateTime.Now
                    }

                );

        }

    }
}
