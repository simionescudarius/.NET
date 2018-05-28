using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    public class LoanRepository : ICRUDRepository<Imprumut> {
        private BibContext bibContext = new BibContext();

        public LoanRepository() {
        }

        public void DeleteObject(int id) {
            Imprumut imprumutToRemove = bibContext.Imprumut.Find(id);
            bibContext.Imprumut.Remove(imprumutToRemove);
        }

        public Imprumut GetObjectById(int id) {
            return bibContext.Imprumut.Find(id);
        }

        public IEnumerable<Imprumut> getAll() {
            return bibContext.Imprumut.ToList();
        }

        public Imprumut InsertObject(Imprumut imprumut) {
            return bibContext.Imprumut.Add(imprumut);
        }

        public void SaveChanges() {
            bibContext.SaveChanges();
        }

        public List<Imprumut> GetLoansByUserId(int id) {
            return bibContext.Imprumut.SqlQuery("SELECT * FROM dbo.Imprumut WHERE CITITORID= @p0", id).ToList();
        }

        public List<Imprumut> GetLoansByBookId(int id) {
            return bibContext.Imprumut.SqlQuery("SELECT * FROM dbo.Imprumut WHERE CARTEID= @p0", id).ToList();
        }

        public void UpdateObject(Imprumut imprumut) {
            bibContext.Entry(imprumut).State = EntityState.Modified;
        }
    }
}
