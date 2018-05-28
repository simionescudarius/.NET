using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    public class GenderRepository : ICRUDRepository<Gen> {
        private BibContext bibContext = new BibContext();

        public GenderRepository() {
        }

        public void DeleteObject(int id) {
            Gen genToRemove = bibContext.Gen.Find(id);
            bibContext.Gen.Remove(genToRemove);

        }

        public Gen GetObjectById(int id) {
            return bibContext.Gen.Find(id);
        }

        public IEnumerable<Gen> getAll() {
            return bibContext.Gen.ToList();
        }

        public Gen InsertObject(Gen gen) {
            return bibContext.Gen.Add(gen);
        }

        public void SaveChanges() {
            bibContext.SaveChanges();
        }

        public void UpdateObject(Gen gen) {
            bibContext.Entry(gen).State = EntityState.Modified;
        }

        public Gen GetGenByDescription(string description) {
            return bibContext.Gen.SqlQuery("SELECT * FROM dbo.Gen WHERE DESCRIERE = @p0", description).FirstOrDefault();
        }
    }
}
