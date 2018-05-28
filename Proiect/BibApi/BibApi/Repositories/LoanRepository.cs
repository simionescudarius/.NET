using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    class LoanRepository : ICRUDRepository<Imprumut> {
        private BibContext bibContext;

        public LoanRepository(BibContext context) {
            this.bibContext = context;
        }

        public void deleteObject(int id) {
            Imprumut imprumutToRemove = bibContext.Imprumut.Find(id);
            bibContext.Imprumut.Remove(imprumutToRemove);
        }

        public Imprumut getObjectById(int id) {
            return bibContext.Imprumut.Find(id);
        }

        public IEnumerable<Imprumut> getAll() {
            return bibContext.Imprumut.ToList();
        }

        public Imprumut insertObject(Imprumut imprumut) {
            return bibContext.Imprumut.Add(imprumut);
        }

        public void saveChanges() {
            bibContext.SaveChanges();
        }

        public void updateObject(Imprumut imprumut) {
            bibContext.Entry(imprumut).State = EntityState.Modified;
        }
    }
}
