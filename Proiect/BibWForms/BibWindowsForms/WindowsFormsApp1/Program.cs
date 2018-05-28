using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibApi;
using System.Web.Mvc;
using BibApi.Services;

namespace WindowsFormsApp1 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Autor autor = new Autor() {
                nume = "test",
                prenume = "test"
            };

            Gen gen = new Gen() {
                descriere = "actiuneTest"
            };

            Carte carte = new Carte() {
                Autor = autor,
                Gen = gen,
                titlu = "test",
            };

            BookService bookService = new BookService();
            bookService.buyBooks(carte, 4);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
