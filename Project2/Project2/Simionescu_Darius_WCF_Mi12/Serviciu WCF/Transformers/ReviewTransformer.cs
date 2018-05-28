using BibApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2.Transformers {
    class ReviewTransformer {
        public static ReviewDTO fromModelToDto(Review model) {
            if (model == null) {
                return null;
            }
            ReviewDTO reviewDto = new ReviewDTO();
            reviewDto.reviewId = model.reviewId;
            reviewDto.imprumutId = model.imprumutId;
            reviewDto.text = model.text;

            return reviewDto;
        }

        public static Review fromDtoToModel(ReviewDTO dto) {
            Review review = new Review();
            review.reviewId = dto.reviewId;
            review.imprumutId = dto.imprumutId;
            review.text = dto.text;

            return review;
        }
    }
}
