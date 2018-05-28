namespace WindowsFormsApp1 {
    partial class MainPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent() {
            this.toBuyBooksPageButton = new System.Windows.Forms.Button();
            this.toLoanBooksPageButton = new System.Windows.Forms.Button();
            this.booksListView = new System.Windows.Forms.ListView();
            this.Titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // toBuyBooksPageButton
            // 
            this.toBuyBooksPageButton.Location = new System.Drawing.Point(439, 12);
            this.toBuyBooksPageButton.Name = "toBuyBooksPageButton";
            this.toBuyBooksPageButton.Size = new System.Drawing.Size(175, 47);
            this.toBuyBooksPageButton.TabIndex = 0;
            this.toBuyBooksPageButton.Text = "Cumpara carti";
            this.toBuyBooksPageButton.UseVisualStyleBackColor = true;
            this.toBuyBooksPageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // toLoanBooksPageButton
            // 
            this.toLoanBooksPageButton.Location = new System.Drawing.Point(439, 98);
            this.toLoanBooksPageButton.Name = "toLoanBooksPageButton";
            this.toLoanBooksPageButton.Size = new System.Drawing.Size(176, 47);
            this.toLoanBooksPageButton.TabIndex = 1;
            this.toLoanBooksPageButton.Text = "Imprumuta carti";
            this.toLoanBooksPageButton.UseVisualStyleBackColor = true;
            this.toLoanBooksPageButton.Click += new System.EventHandler(this.toLoanBooksPageButton_Click);
            // 
            // booksListView
            // 
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titlu,
            this.Gen,
            this.Autor,
            this.ID});
            this.booksListView.Location = new System.Drawing.Point(12, 12);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(390, 517);
            this.booksListView.TabIndex = 3;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            this.booksListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Titlu
            // 
            this.Titlu.Text = "Titlu";
            this.Titlu.Width = 90;
            // 
            // Gen
            // 
            this.Gen.Text = "Gen";
            this.Gen.Width = 89;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 116;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 541);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.toLoanBooksPageButton);
            this.Controls.Add(this.toBuyBooksPageButton);
            this.Name = "MainPage";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toBuyBooksPageButton;
        private System.Windows.Forms.Button toLoanBooksPageButton;
        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ColumnHeader Titlu;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader ID;
    }
}

