using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    class AutorRepository : ICRUDRepository<Autor> {
        private BibContext bibContext;

        public AutorRepository(BibContext context) {
            this.bibContext = context;
        }

        public void deleteObject(int id) {
            Autor autorToRemove = bibContext.Autor.Find(id);
            bibContext.Autor.Remove(autorToRemove);
        }

        public Autor getObjectById(int id) {
            return bibContext.Autor.Find(id);
        }

        public IEnumerable<Autor> getAll() {
            return bibContext.Autor.ToList();
        }

        public Autor insertObject(Autor autor) {
            return bibContext.Autor.Add(autor);
        }

        public void saveChanges() {
            bibContext.SaveChanges();

        }

        public void updateObject(Autor autor) {
            bibContext.Entry(autor).State = EntityState.Modified;

        }

        public bool autorAlreadyExists(string firstName, string lastName) {
            return bibContext.Autor.SqlQuery("SELECT * FROM dbo.Autor WHERE NUME = @p0 AND PRENUME = @p1", firstName, lastName) != null;

        }
    }
}
