using BibApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibApi.Services {
    public class BookService {
        private BookRepository bookRepository;
        private AutorRepository autorRepository;
        private GenderRepository genderRepository;
        private BibContext bibContext = new BibContext();

        public BookService() {
            this.bookRepository = new BookRepository(bibContext);
            this.autorRepository = new AutorRepository(bibContext);
            this.genderRepository = new GenderRepository(bibContext);
        }

        public bool buyBooks(Carte carte, short numberOfBooks) {
            using (bibContext) {
                Autor autor = carte.Autor;
                Gen gen = carte.Gen;

                Console.WriteLine(autor);
                if (!autorRepository.autorAlreadyExists(autor.nume, autor.prenume)) {
                    autor = autorRepository.insertObject(autor);
                    Console.WriteLine("AFTER SAVE AUTOR {0}", autor);
                }

                if (!genderRepository.genderAlreadyExists(gen.descriere)) {
                    gen = genderRepository.insertObject(gen);
                }

                bookRepository.saveChanges();
                Carte bookToSave = new Carte() {
                    autorId = autor.autorId,
                    genId = gen.genId,
                    titlu = carte.titlu,
                    Imprumut = new List<Imprumut>()
                };

                while (numberOfBooks > 0) {
                    bookRepository.insertObject(bookToSave);
                    numberOfBooks--;
                }

                bookRepository.saveChanges();
                return true;
            }
        }

        public void deleteAllBooks() {
            foreach(var entry in bookRepository.getAll()) {
                autorRepository.deleteObject(entry.carteId);
            }
        }
    }
}
