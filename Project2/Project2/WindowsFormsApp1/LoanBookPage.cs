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
    public partial class LoanBookPage : Form {
        public LoanBookPage() {
            InitializeComponent();
            isUserTrustworthyLabel.Hide();
            bookIsNotAvailable.Hide();
            loanBookButton.Hide();
            genLabel.Hide();
            genInput.Hide();
            authorLabel.Hide();
            authorInput.Hide();
            availableBooksList.Hide();
            filterButton.Hide();
            bookIdInput.Hide();
            bookIdLabel.Hide();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void LoanBookPage_Load(object sender, EventArgs e) {
            BookServiceClient bookService = new BookServiceClient();

            foreach (CarteDTO carte in bookService.GetAvailableBooks()) {
                ListViewItem item = new ListViewItem(carte.carteId.ToString());
                item.SubItems.Add(carte.titlu);
                item.SubItems.Add(carte.AutorDto.nume + " " + carte.AutorDto.prenume);
                item.SubItems.Add(carte.GenDto.descriere);
                availableBooksList.Items.Add(item);
            }
        }

        private void checkUserTrustButton_Click(object sender, EventArgs e) {
            string input = emailInput.Text;

            ReaderServiceClient readerService = new ReaderServiceClient();
            LoanServiceClient loanService = new LoanServiceClient();
            CititorDTO cititor = readerService.GetReaderByEmail(input);

            if (cititor != null && loanService.GetLoanByUserId(cititor.cititorId) != null && loanService.GetLoanByUserId(cititor.cititorId).dataRestituire == null) {
                isUserTrustworthyLabel.Text = "Acest cititor are deja o carte imprumutata !";
                isUserTrustworthyLabel.Show();
                return;
            } else {
                isUserTrustworthyLabel.Hide();
                genLabel.Show();
                genInput.Show();
                authorLabel.Show();
                authorInput.Show();
                availableBooksList.Show();
                filterButton.Show();
                bookIdInput.Show();
                bookIdLabel.Show();
            }

            if (cititor == null) {
                RegisterReader registerReader = new RegisterReader();
                registerReader.Show();
            } else {
                if (readerService.IsReaderTrustworthy(cititor) == true) {
                    isUserTrustworthyLabel.Text = "Este de incredere !";
                } else {
                    isUserTrustworthyLabel.Text = "Nu este de incredere !";
                }
                isUserTrustworthyLabel.Show();
            }
            loanBookButton.Show();
        }

        private void loanBookButton_Click(object sender, EventArgs e) {
            ReaderServiceClient readerService = new ReaderServiceClient();
            BookServiceClient bookService = new BookServiceClient();
            LoanServiceClient loanService = new LoanServiceClient();

            CititorDTO citior = readerService.GetReaderByEmail(emailInput.Text);
            CarteDTO carte = bookService.GetBookById(Int32.Parse(bookIdInput.Text));

            ImprumutDTO existingLoan = loanService.GetLoanForBookId(carte.carteId);
            if (existingLoan == null) {
                loanService.LoanBook(carte, citior, DateTime.Now, DateTime.Now.AddDays(30));
                this.Close();
            } else {
                bookIsNotAvailable.Text = "Cartea va fi disponibila in data de: " + existingLoan.dataScadenta;
                bookIsNotAvailable.Show();
            }
        }

        private void titleInput_TextChanged(object sender, EventArgs e) {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            bookIsNotAvailable.Hide();
            BookServiceClient bookService = new BookServiceClient();
            string filterGender = genInput.Text;

            availableBooksList.Items.Clear();
            foreach (CarteDTO carte in bookService.GetAvailableBooks()) {
                if (filterGender.Equals("") || filterGender.Equals(' ') || filterGender.Equals(carte.GenDto.descriere)) {
                    ListViewItem item = new ListViewItem(carte.carteId.ToString());
                    item.SubItems.Add(carte.titlu);
                    item.SubItems.Add(carte.AutorDto.nume + " " + carte.AutorDto.prenume);
                    item.SubItems.Add(carte.GenDto.descriere);
                    availableBooksList.Items.Add(item);
                }
            }
        }

        private void isUserTrustworthyLabel_Click(object sender, EventArgs e) {

        }
    }
}
