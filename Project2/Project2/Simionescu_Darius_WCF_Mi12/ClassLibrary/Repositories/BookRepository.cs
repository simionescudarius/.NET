using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;

namespace BibApi.Repositories {
    public class BookRepository : ICRUDRepository<Carte> {
        private BibContext bibContext = new BibContext();

        public BookRepository() {
        }

        public void DeleteObject(int id) {
            Carte bookToRemove = bibContext.Carte.Find(id);
            bibContext.Carte.Remove(bookToRemove);

        }

        public Carte GetObjectById(int id) {
            return bibContext.Carte.Find(id);

        }

        public IEnumerable<Carte> getAll() {
            return bibContext.Carte.ToList();

        }

        public Carte InsertObject(Carte book) {
            return bibContext.Carte.Add(book);

        }

        public void SaveChanges() {
            bibContext.SaveChanges();

        }

        public void UpdateObject(Carte book) {
            bibContext.Entry(book).State = EntityState.Modified;

        }

        public List<Carte> GetBooksByGen(string gen) {
            return bibContext.Carte.SqlQuery("SELECT * FROM dbo.Carte WHERE GEN = @p0", gen).ToList<Carte>();
        }

        public List<Carte> GetAvailableBooks() {
            return bibContext.Database.SqlQuery<Carte>("SELECT * FROM dbo.Carte WHERE CARTEID NOT IN (SELECT carteId FROM dbo.Imprumut)").ToList();
        }
    }
}
