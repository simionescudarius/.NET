using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    class GenderRepository : ICRUDRepository<Gen> {
        private BibContext bibContext;

        public GenderRepository(BibContext context) {
            this.bibContext = context;
        }

        public void deleteObject(int id) {
            Gen genToRemove = bibContext.Gen.Find(id);
            bibContext.Gen.Remove(genToRemove);

        }

        public Gen getObjectById(int id) {
            return bibContext.Gen.Find(id);
        }

        public IEnumerable<Gen> getAll() {
            return bibContext.Gen.ToList();
        }

        public Gen insertObject(Gen gen) {
            return bibContext.Gen.Add(gen);
        }

        public void saveChanges() {
            bibContext.SaveChanges();
        }

        public void updateObject(Gen gen) {
            bibContext.Entry(gen).State = EntityState.Modified;
        }

        public bool genderAlreadyExists(string description) {
            return bibContext.Autor.SqlQuery("SELECT * FROM dbo.Gen WHERE DESCRIERE = @p0", description) != null;
        }
    }
}
