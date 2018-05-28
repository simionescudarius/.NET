using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceReference2;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApplication.Controllers
{
    public class ReaderController : Controller {
        private IReaderService readerService = new ReaderServiceClient();
        private ILoanService loanService = new LoanServiceClient();
        private IBookService bookService = new BookServiceClient();

        [HttpPost]
        public async Task<bool> IsReaderTrustworth([FromBody] ReaderModel model) {
            CititorDTO cititor = await readerService.GetReaderByEmailAsync(model.email);
            return await readerService.IsReaderTrustworthyAsync(cititor);
        }

        [HttpPost]
        public async Task<StatusCodeResult> UserExists([FromBody] ReaderModel model) {
            CititorDTO cititor = await readerService.GetReaderByEmailAsync(model.email);
            
            if(cititor == null) {
                return StatusCode(204);
            } else {
                return StatusCode(200);
            }
        }

        [HttpPost]
        public async void RegisterUser([FromBody] ReaderModel model) {
            CititorDTO cititor = new CititorDTO();
            cititor.adresa = model.adress;
            cititor.nume = model.firstName;
            cititor.prenume = model.lastName;
            cititor.email = model.email;

            await readerService.RegisterReaderAsync(cititor);
        }
    }
}
