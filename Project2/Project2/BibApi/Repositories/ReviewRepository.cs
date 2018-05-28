using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    public class ReviewRepository : ICRUDRepository<Review> {
        private BibContext bibContext = new BibContext();

        public ReviewRepository() {
        }

        public void DeleteObject(int id) {
            Review reviewToRemove = bibContext.Review.Find(id);
            bibContext.Review.Remove(reviewToRemove);
        }

        public Review GetObjectById(int id) {
            return bibContext.Review.Find(id);
        }

        public IEnumerable<Review> getAll() {
            return bibContext.Review.ToList();
        }

        public Review InsertObject(Review review) {
            return bibContext.Review.Add(review);
        }

        public void SaveChanges() {
            bibContext.SaveChanges();
        }

        public void UpdateObject(Review review) {
            bibContext.Entry(review).State = EntityState.Modified;
        }
    }
}
