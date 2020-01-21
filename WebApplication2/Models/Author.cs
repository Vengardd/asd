using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Author
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
