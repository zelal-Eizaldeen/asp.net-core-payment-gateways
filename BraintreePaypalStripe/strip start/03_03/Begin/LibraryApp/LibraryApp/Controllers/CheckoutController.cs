using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IBookService _booksService;

        public CheckoutController(IBookService bookService)
        {
            _booksService = bookService;
        }

        public IActionResult Purchase(Guid id)
        {

            var book = _booksService.GetById(id);
            ViewBag.PurchaseAmount = book.Price;
            if (book == null) return NotFound();
            return View(book);
        }
    }
}