using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Dto;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MostPopularBooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MostPopularBooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var query = _context.Author.Join(_context.Book,
                author => author,
                book => book.Author,
                (author, book) => new { Name = book.Name, NumberOfSold = book.NumberOfSold, AuthorName = author.Name, AuthorSurname = author.Surname })
                .GroupBy(x => new { x.AuthorName, x.AuthorSurname })
                .Select(x => new MostPopularBooks(x.Key.AuthorName, x.Key.AuthorSurname, x.Count()));
            return View(query);
        }

    }
}

