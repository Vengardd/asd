using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Validators;

namespace WebApplication2.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [AuthorNameValidator(ErrorMessage = "Name must start with letter")]
        public String Name { get; set; }
        [Required]
        [AuthorNameValidator(ErrorMessage = "Surame must start with letter")]
        public String Surname { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
