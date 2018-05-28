using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    public class AutorRepository : ICRUDRepository<Autor> {
        private BibContext bibContext = new BibContext();

        public AutorRepository() {
        }

        public void DeleteObject(int id) {
            Autor autorToRemove = bibContext.Autor.Find(id);
            bibContext.Autor.Remove(autorToRemove);
        }

        public Autor GetObjectById(int id) {
            return bibContext.Autor.Find(id);
        }

        public IEnumerable<Autor> getAll() {
            return bibContext.Autor.ToList();
        }

        public Autor InsertObject(Autor autor) {
            return bibContext.Autor.Add(autor);
        }

        public void SaveChanges() {
            bibContext.SaveChanges();

        }

        public void UpdateObject(Autor autor) {
            bibContext.Entry(autor).State = EntityState.Modified;

        }

        public Autor GetAutorByFirstAndLastName(string firstName, string lastName) {
            return bibContext.Autor.SqlQuery("SELECT * FROM dbo.Autor WHERE NUME = @p0 AND PRENUME = @p1", firstName, lastName).FirstOrDefault();
        }
    }
}
