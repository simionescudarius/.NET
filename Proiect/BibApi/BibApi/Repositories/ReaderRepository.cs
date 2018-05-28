using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    class ReaderRepository : ICRUDRepository<Cititor> {
        private BibContext bibContext;

        public void deleteObject(int id) {
            Cititor cititorToRemove = bibContext.Cititor.Find(id);
            bibContext.Cititor.Remove(cititorToRemove);
        }

        public Cititor getObjectById(int id) {
            return bibContext.Cititor.Find(id);
        }

        public IEnumerable<Cititor> getAll() {
            return bibContext.Cititor.ToList();
        }

        public Cititor insertObject(Cititor cititor) {
            return bibContext.Cititor.Add(cititor);
        }

        public void saveChanges() {
            bibContext.SaveChanges();
        }

        public void updateObject(Cititor cititor) {
            bibContext.Entry(cititor).State = EntityState.Modified;
        }
    }
}
