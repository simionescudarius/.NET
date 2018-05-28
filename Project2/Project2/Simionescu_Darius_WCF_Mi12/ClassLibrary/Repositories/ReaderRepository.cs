using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    public class ReaderRepository : ICRUDRepository<Cititor> {
        private BibContext bibContext = new BibContext();

        public ReaderRepository() {
        }

        public void DeleteObject(int id) {
            Cititor cititorToRemove = bibContext.Cititor.Find(id);
            bibContext.Cititor.Remove(cititorToRemove);
        }

        public Cititor GetObjectById(int id) {
            return bibContext.Cititor.Find(id);
        }

        public IEnumerable<Cititor> getAll() {
            return bibContext.Cititor.ToList();
        }

        public Cititor InsertObject(Cititor cititor) {
            return bibContext.Cititor.Add(cititor);
        }

        public void SaveChanges() {
            bibContext.SaveChanges();
        }

        public void UpdateObject(Cititor cititor) {
            bibContext.Entry(cititor).State = EntityState.Modified;
        }

        public Cititor GetReaderByEmail(string email) {
            return bibContext.Cititor.SqlQuery("SELECT * FROM dbo.Cititor WHERE EMAIL= @p0", email).FirstOrDefault();
        }
    }
}
