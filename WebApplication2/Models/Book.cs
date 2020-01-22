using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApplication2.Validators;

namespace WebApplication2.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Release date cannot be null")]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [BookReleaseDateValidator(ErrorMessage ="Release date cannot be future")]
        public DateTime ReleaseDate { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Release date cannot be null")]
        public long NumberOfSold { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        
    }
}
