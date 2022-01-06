using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFinalAssignment.Models;

namespace WebApplicationFinalAssignment.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }

        public DbSet<Books> Book { get; set; }
        public DbSet<BookCategories> Bookcategory { get; set; }


        /// <summary>
        /// Insert Defalut Data into the database
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Add default values into the BookCategories table

            modelBuilder.Entity<BookCategories>().HasData(
                new BookCategories
                {
                    CategoryId = 1,
                    CategoryName = "IT",
                    UpdatedOn = Convert.ToDateTime("11/27/2019"),
                    IsDeleted = false
                },
                new BookCategories
                {
                    CategoryId = 2,
                    CategoryName = "Electronics",
                    UpdatedOn = Convert.ToDateTime("11/23/2019"),
                    IsDeleted = false
                },
                new BookCategories
                {
                    CategoryId = 3,
                    CategoryName = "Mechanical",
                    UpdatedOn = Convert.ToDateTime("11/22/2019"),
                    IsDeleted = false
                },
                new BookCategories
                {
                    CategoryId = 4,
                    CategoryName = "Civil",
                    UpdatedOn = Convert.ToDateTime("11/21/2019"),
                    IsDeleted = false
                },
                new BookCategories
                {
                    CategoryId = 5,
                    CategoryName = "Electricals",
                    UpdatedOn = Convert.ToDateTime("11/20/2019"),
                    IsDeleted = false
                },
                new BookCategories
                {
                    CategoryId = 6,
                    CategoryName = "Economics",
                    UpdatedOn = Convert.ToDateTime("11/2/2019"),
                    IsDeleted = true
                }
                );



            //Add defalut values into the Book table
            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    BookId = 1,
                    BookName = "C++",
                    AuthorName = "Balaguruswamy",
                    PublisherYear = 2001,
                    Price = 500,
                    BookCategoryId = 1,
                    UpdatedOn = Convert.ToDateTime("11/27/2019"),
                    IsDeleted = false
                },
                new Books
                {
                    BookId = 2,
                    BookName = "Microcontrollers",
                    AuthorName = "Mazidi",
                    PublisherYear = 2002,
                    Price = 550,
                    BookCategoryId = 2,
                    UpdatedOn = Convert.ToDateTime("11/28/2019"),
                    IsDeleted = false
                },
                new Books
                {
                    BookId = 3,
                    BookName = "Robotics",
                    AuthorName = "Sebastian",
                    PublisherYear = 2003,
                    Price = 600,
                    BookCategoryId = 3,
                    UpdatedOn = Convert.ToDateTime("11/29/2019"),
                    IsDeleted = false
                },
                new Books
                {
                    BookId = 4,
                    BookName = "Structural Engineering",
                    AuthorName = "Jacques Heyman",
                    PublisherYear = 2004,
                    Price = 800,
                    BookCategoryId = 4,
                    UpdatedOn = Convert.ToDateTime("11/21/2019"),
                    IsDeleted = false
                },
                new Books
                {
                    BookId = 5,
                    BookName = "DC Motors",
                    AuthorName = "Michael Faraday",
                    PublisherYear = 2004,
                    Price = 400,
                    BookCategoryId = 5,
                    UpdatedOn = Convert.ToDateTime("11/1/2019"),
                    IsDeleted = false
                },
                new Books
                {
                    BookId = 6,
                    BookName = "Economics",
                    AuthorName = "Nassim Nicholas",
                    PublisherYear = 2005,
                    Price = 300,
                    BookCategoryId = 6,
                    UpdatedOn = Convert.ToDateTime("11/2/2019"),
                    IsDeleted = true
                },
                new Books
                {
                    BookId = 7,
                    BookName = "Data Structure",
                    AuthorName = "",
                    Price = 430,
                    BookCategoryId = 1,
                    UpdatedOn = Convert.ToDateTime("11/3/2019"),
                    IsDeleted = false
                },
                new Books
                {
                    BookId = 8,
                    BookName = "Operating systems",
                    AuthorName = "Abraham Silberschatz",
                    PublisherYear = 2007,
                    BookCategoryId = 1,
                    UpdatedOn = Convert.ToDateTime("11/4/2019"),
                    IsDeleted = true
                },
                new Books
                {
                    BookId = 9,
                    BookName = "Digital Electronics",
                    AuthorName = "William Gothmann",
                    BookCategoryId = 2,
                    UpdatedOn = Convert.ToDateTime("11/2/2019"),
                    IsDeleted = false
                }
                );
        }

    }
}
