using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCF_Project2;

namespace WCF_host {
    class Program {
        static void Main(string[] args) {
            ServiceHost host = new ServiceHost(typeof(LibraryService));
            host.Open();
        }
    }
}
