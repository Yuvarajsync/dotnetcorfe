using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFinalAssignment.Models;

namespace WebApplicationFinalAssignment.Models
{

   
    public class Books
    {
        [Key]
        [NotNull]
        public int BookId { get; set; }

        [NotNull]
        [Required]
        public string BookName { get; set; }


        [Required(ErrorMessage ="Author Name is Required!")]
        public string AuthorName { get; set; }


        [Required(ErrorMessage ="Published Year is Required!")]
        public int PublisherYear { get; set; }


        [Required(ErrorMessage ="Price is Required!")]
        public Decimal Price { get; set; }

        [NotNull]
        public int BookCategoryId { get; set; } //Foreignkey set
        [ForeignKey("BookCategoryId")] // Foreignkey
        public virtual BookCategories BookCategories { get; set; } //Route path


        [NotNull]
        [Required(ErrorMessage ="Date is Required!")]
        public DateTime UpdatedOn { get; set; }


        public virtual string BookDept { get; set; }
        [NotNull]
        public bool IsDeleted { get; set; }

    }

    public class BookCategories
    {
        [NotNull]
        [Key]
        public int CategoryId { get; set; }

        [NotNull]
        public string CategoryName { get; set; }

        [NotNull]
        public DateTime UpdatedOn { get; set; }

        [NotNull]
        public bool IsDeleted { get; set; }

    }
}
