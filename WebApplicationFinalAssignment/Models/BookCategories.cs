using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFinalAssignment.Models
{

    public class BookCategories
    {
        [NotNull]
        [Key]
        public int CategoryId { get; set; }

        [NotNull]
        [Required]
        public string CategoryName { get; set; }

        [NotNull]
        [Required]
        public DateTime UpdatedOn { get; set; }

        [NotNull]
        [Required]
        public bool IsDeleted { get; set; }

    }    
}