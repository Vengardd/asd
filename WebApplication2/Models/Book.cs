using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
        public DateTime ReleaseDate { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            Regex regex = new Regex(@"^[A-Za-z][A-Za-z0-9 -]*$/");
            if (!regex.IsMatch(Name))
            {
                yield return new ValidationResult("Title should start with letter or number",
                    new[] { nameof(Name) });
            }

            if (ReleaseDate > DateTime.Now)
            {
                yield return new ValidationResult("Wrong date",
                    new[] { nameof(ReleaseDate) });
            }
        }
    }
}
