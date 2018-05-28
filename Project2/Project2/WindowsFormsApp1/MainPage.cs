using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Project2;

namespace WindowsFormsApp1 {
    public partial class MainPage : Form {
        public MainPage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            BuyBooksPage buyBooksPage = new BuyBooksPage();
            buyBooksPage.Owner = this;
            buyBooksPage.ShowDialog();
            booksListView.Refresh();
        }

        public void MainPage_Load(object sender, EventArgs e) {
            BookServiceClient bookService = new BookServiceClient();

            booksListView.Items.Clear();
            foreach(CarteDTO carte in bookService.GetAllBooks()) {
                ListViewItem item = new ListViewItem(carte.titlu);
                item.SubItems.Add(carte.GenDto.descriere);
                item.SubItems.Add(carte.AutorDto.nume + " " + carte.AutorDto.prenume);
                item.SubItems.Add(carte.carteId.ToString());
                booksListView.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void toLoanBooksPageButton_Click(object sender, EventArgs e) {
            LoanBookPage loanBookPage = new LoanBookPage();
            loanBookPage.Owner = this;
            loanBookPage.Show();
        }
    }
}
