using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceReference2;

namespace LibraryApplication.Controllers
{
    public class BookController : Controller
    {
        private IBookService service = new BookServiceClient();
        private IReaderService readerService = new ReaderServiceClient();
        private ILoanService loanService = new LoanServiceClient();

        [HttpGet]
        public async Task<ActionResult> TakeAllBooks()
        {
            ViewBag.AllBooks =  await service.GetAllBooksAsync();

            return View("~/Views/Home/Index.cshtml");
        }

        [HttpPost]
        [Route("addBook/{count}")]
        public void AddBook([FromBody]BookModel book, string count) {
            CarteDTO carte = new CarteDTO();
            AutorDTO autor = new AutorDTO();
            GenDTO gen = new GenDTO();

            carte.titlu = book.title;
            autor.nume = book.authorFirstName;
            autor.prenume = book.authorLastName;
            carte.AutorDto = autor;
            gen.descriere = book.gender;
            carte.GenDto = gen;

            service.BuyBooksAsync(carte, short.Parse(count));
        }

        [HttpPost]
        [Route("loan")]
        public async void LoanBook([FromBody]LoanModel loanModel) {
            CarteDTO book = await service.GetBookByIdAsync(loanModel.bookId);
            CititorDTO reader = await readerService.GetReaderByEmailAsync(loanModel.readerEmail);

            await loanService.LoanBookAsync(book, reader, DateTime.Now, DateTime.Now.AddDays(30));
        }

        [HttpGet]
        [Route("userLoans/{email}")]
        public async Task<ActionResult> TakeUserBook(string email) {
            List<CarteDTO> books = new List<CarteDTO>();
            ImprumutDTO[] imprumutDTOs = await loanService.GetLoansByUserEmailAsync(email);

            foreach(ImprumutDTO imprumut in imprumutDTOs) {
                books.Add(await service.GetBookByIdAsync(imprumut.carteId));
            }

            ViewBag.UserBooks = books;
            return View("~/Views/Home/UserLoan.cshtml");
        }

        [HttpGet]
        [Route("loan")]
        public async Task<ActionResult> GetLoanBookPage() {
            ViewBag.AvailableBooks = await service.GetAvailableBooksAsync();

            return View("~/Views/Home/LoanBook.cshtml");
        }

    }
}
