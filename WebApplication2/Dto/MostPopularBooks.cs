using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Dto
{
    public class MostPopularBooks
    {
        public String AuthorName { get; set; }
        public String AuthorSurname { get; set; }
        public long Count { get; set; }

        public MostPopularBooks(string authorName, string authorSurname, long count)
        {
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            Count = count;
        }
    }
}
