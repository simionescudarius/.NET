using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Project2;

namespace TestClient {
    class Program {
        static void Main(string[] args) {
            BookServiceClient client = new BookServiceClient();
            CarteDTO[] list = client.GetAllBooks();
            Console.WriteLine(list);
            Console.ReadLine();
        }
    }
}
