using BibApi;
using BibApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF_Project2;
using WCF_Project2.Transformers;

namespace WCF_Project2 {
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class LibraryService : IBookService, ILoanService, IReaderService, IReviewService {
        private BookRepository bookRepository;
        private AutorRepository autorRepository;
        private GenderRepository genderRepository;
        private LoanRepository loanRepository;
        private ReviewRepository reviewRepository;
        private ReaderRepository readerRepository;

        public LibraryService() {
            this.readerRepository = new ReaderRepository();
            this.reviewRepository = new ReviewRepository();
            this.bookRepository = new BookRepository();
            this.autorRepository = new AutorRepository();
            this.genderRepository = new GenderRepository();
            this.loanRepository = new LoanRepository();
        }

        // @Carte - cartea ce se cumpara
        // @numberOfBooks - numarul de exemplare

        public void BuyBooks(CarteDTO carteDto, short numberOfBooks) {
            Autor autor = autorRepository.GetAutorByFirstAndLastName(carteDto.AutorDto.nume, carteDto.AutorDto.prenume);
            if (autor == null) {
                Autor autorToBeInserted = AutorTransformer.fromDtoToModel(carteDto.AutorDto);
                autor = autorRepository.InsertObject(autorToBeInserted);
            }

            Gen gen = genderRepository.GetGenByDescription(carteDto.GenDto.descriere);
            if (gen == null) {
                Gen genToBeInserted = GenTransformer.fromDtoToModel(carteDto.GenDto);
                gen = genderRepository.InsertObject(genToBeInserted);
            }

            while (numberOfBooks > 0) {
                Carte bookToSave = new Carte() {
                    autorId = autor.autorId,
                    genId = gen.genId,
                    titlu = carteDto.titlu,
                    Autor = autor,
                    Gen = gen,
                    Imprumut = new List<Imprumut>()
                };
                bookRepository.InsertObject(bookToSave);
                numberOfBooks--;
            }

            bookRepository.SaveChanges();
        }

        public List<CarteDTO> GetAvailableBooks() {
            List<Carte> books = bookRepository.GetAvailableBooks();

            foreach(Carte book in books) {
                book.Autor = autorRepository.GetObjectById(book.autorId);
                book.Gen = genderRepository.GetObjectById(book.genId);
            }

            return CarteTransformer.fromModelListToCarteDtoList(books);
        }

        public CarteDTO GetBookById(int id) {
            return CarteTransformer.fromModelToDto(bookRepository.GetObjectById(id));
        }

        public List<CarteDTO> GetAllBooks() {
            return CarteTransformer.fromModelListToCarteDtoList(bookRepository.getAll().ToList<Carte>());
        }

        public List<CarteDTO> GetBooksByGen(string gen) {
                return CarteTransformer.fromModelListToCarteDtoList(bookRepository.GetBooksByGen(gen));
        }

        public void LoanBook(CarteDTO book, CititorDTO reader, DateTime loanDate, DateTime deadLine) {
            Imprumut loan = new Imprumut() {
                carteId = book.carteId,
                cititorId = reader.cititorId,
                dataImprumut = loanDate,
                dataScadenta = deadLine
            };

            loanRepository.InsertObject(loan);
            loanRepository.SaveChanges();
        }

        public void UpdateLoan(ImprumutDTO imprumut) {
            Imprumut model = loanRepository.GetObjectById(imprumut.imprumutId);
            model.dataRestituire = imprumut.dataRestituire;
            loanRepository.DeleteObject(imprumut.imprumutId);
            loanRepository.InsertObject(model);
            loanRepository.SaveChanges();
        }

        public List<ImprumutDTO> GetLoansByUserEmail(string email) {
            Cititor reader = readerRepository.GetReaderByEmail(email);
            if (reader != null) {
                int userId = reader.cititorId;
                return ImprumutTransformer.fromModelListToDtoList(loanRepository.GetLoansByUserId(userId));
            }
            return null;
        }

        public List<ImprumutDTO> GetLoansByUserId(int id) {
            return ImprumutTransformer.fromModelListToDtoList(loanRepository.GetLoansByUserId(id));
        }

        public List<ImprumutDTO> GetLoanForBookId(int bookId) {
            return ImprumutTransformer.fromModelListToDtoList(loanRepository.GetLoansByBookId(bookId));
        }

        public CititorDTO GetReaderByEmail(string email) {
            return CititorTransformer.fromModelToDto(readerRepository.GetReaderByEmail(email));
        }

        public void RegisterReader(CititorDTO cititor) {
            readerRepository.InsertObject(CititorTransformer.fromDtoToModel(cititor));
            readerRepository.SaveChanges();
        }

        public bool IsReaderTrustworthy(CititorDTO cititor) {
            Cititor savedReader = readerRepository.GetObjectById(cititor.cititorId);

            if (savedReader.stare == 0) return true;
            else return false;
        }

        public void AddReviewForLoan(ImprumutDTO imprumut, string text) {
            Review review = new Review() {
                imprumutId = imprumut.imprumutId,
                text = text
            };

            reviewRepository.InsertObject(review);
            reviewRepository.SaveChanges();
        }
    }
}
