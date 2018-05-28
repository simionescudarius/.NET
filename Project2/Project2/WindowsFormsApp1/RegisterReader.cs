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
    public partial class RegisterReader : Form {
        public RegisterReader() {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void RegisterReader_Load(object sender, EventArgs e) {

        }

        private void registerButton_Click(object sender, EventArgs e) {
            CititorDTO cititor = new CititorDTO();
            cititor.nume = lastNameInput.Text;
            cititor.prenume = firstNameInput.Text;
            cititor.email = emailInput.Text;
            cititor.adresa = adressInput.Text;
            cititor.stare = 0;

            ReaderServiceClient readerService = new ReaderServiceClient();
            readerService.RegisterReader(cititor);

            this.Close();
        }

        private void lastNameInput_TextChanged(object sender, EventArgs e) {

        }
    }
}
