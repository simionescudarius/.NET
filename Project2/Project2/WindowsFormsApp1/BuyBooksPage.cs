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
    public partial class BuyBooksPage : Form {
        public BuyBooksPage() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            string input;
            string nume = authorInput.Text;
            string prenume = textBox1.Text;

            AutorDTO autor = new AutorDTO();
            autor.nume = nume;
            autor.prenume = prenume;

            input = genderInput.Text;
            GenDTO gen = new GenDTO();
            gen.descriere = input;

            input = titleInput.Text;
            CarteDTO carte = new CarteDTO();
            carte.titlu = input;
            carte.GenDto = gen;
            carte.AutorDto = autor;

            input = numberInput.Text;

            BookServiceClient bookService = new BookServiceClient();
            bookService.BuyBooks(carte, Int16.Parse(input));

          ((MainPage)this.Owner).MainPage_Load(null, null);
           this.Close();
        }

        private void BuyBooksForm_Load(object sender, EventArgs e) {

        }

        private void genderLabel_Click(object sender, EventArgs e) {

        }

        private void authorLabel_Click(object sender, EventArgs e) {

        }
    }
}
