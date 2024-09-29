using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication210924_Books.Models;

namespace WebApplication210924_Books.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "Книга 1", Price = 100, Description = "Описание книги 1", ImageUrl = "/images/book1.jpeg" },
        new Book { Id = 2, Title = "Книга 2", Price = 200, Description = "Описание книги 2", ImageUrl = "/images/book2.jpeg" }
    };

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Order(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Order(int id, string name, string phone, string city, string postOffice)
        {
            
            ViewBag.Message = "Спасибо за ваш заказ!";
            return View("ThankYou");
        }
    }
}
