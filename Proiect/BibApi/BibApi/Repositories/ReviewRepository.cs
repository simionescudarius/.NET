using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BibApi.Repositories {
    class ReviewRepository : ICRUDRepository<Review> {
        private BibContext bibContext;

        public ReviewRepository(BibContext context) {
            this.bibContext = context;
        }

        public void deleteObject(int id) {
            Review reviewToRemove = bibContext.Review.Find(id);
            bibContext.Review.Remove(reviewToRemove);
        }

        public Review getObjectById(int id) {
            return bibContext.Review.Find(id);
        }

        public IEnumerable<Review> getAll() {
            return bibContext.Review.ToList();
        }

        public Review insertObject(Review review) {
            return bibContext.Review.Add(review);
        }

        public void saveChanges() {
            bibContext.SaveChanges();
        }

        public void updateObject(Review review) {
            bibContext.Entry(review).State = EntityState.Modified;
        }
    }
}
