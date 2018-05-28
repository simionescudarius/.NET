using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BibApi.Repositories {
    class BookRepository : ICRUDRepository<Carte> {
        private BibContext bibContext;

        public BookRepository(BibContext context) {
            this.bibContext = context;
        }

        public void deleteObject(int id) {
            Carte bookToRemove = bibContext.Carte.Find(id);
            bibContext.Carte.Remove(bookToRemove);

        }

        public Carte getObjectById(int id) {
            return bibContext.Carte.Find(id);

        }

        public IEnumerable<Carte> getAll() {
            return bibContext.Carte.ToList();

        }

        public Carte insertObject(Carte book) {
            return bibContext.Carte.Add(book);

        }

        public void saveChanges() {
            bibContext.SaveChanges();

        }

        public void updateObject(Carte book) {
            bibContext.Entry(book).State = EntityState.Modified;

        }
    }
}
