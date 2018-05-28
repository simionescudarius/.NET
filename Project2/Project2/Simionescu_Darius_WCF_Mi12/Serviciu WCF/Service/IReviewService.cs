using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2 {
    [ServiceContract]
    public interface IReviewService {
        [OperationContract]
        void AddReviewForLoan(ImprumutDTO imprumut, string text);
    }
}
