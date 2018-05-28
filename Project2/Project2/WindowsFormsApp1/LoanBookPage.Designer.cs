namespace WindowsFormsApp1 {
    partial class LoanBookPage {
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
        private void InitializeComponent() {
            this.emailLabel = new System.Windows.Forms.Label();
            this.bookIdLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.bookIdInput = new System.Windows.Forms.TextBox();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.checkUserTrustButton = new System.Windows.Forms.Button();
            this.isUserTrustworthyLabel = new System.Windows.Forms.Label();
            this.loanBookButton = new System.Windows.Forms.Button();
            this.availableBooksList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genLabel = new System.Windows.Forms.Label();
            this.genInput = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.bookIsNotAvailable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 21);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email cititor";
            this.emailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookIdLabel
            // 
            this.bookIdLabel.AutoSize = true;
            this.bookIdLabel.Location = new System.Drawing.Point(12, 58);
            this.bookIdLabel.Name = "bookIdLabel";
            this.bookIdLabel.Size = new System.Drawing.Size(45, 13);
            this.bookIdLabel.TabIndex = 1;
            this.bookIdLabel.Text = "ID carte";
            this.bookIdLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 95);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(32, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Autor";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(83, 18);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(146, 20);
            this.emailInput.TabIndex = 3;
            // 
            // bookIdInput
            // 
            this.bookIdInput.Location = new System.Drawing.Point(83, 55);
            this.bookIdInput.Name = "bookIdInput";
            this.bookIdInput.Size = new System.Drawing.Size(146, 20);
            this.bookIdInput.TabIndex = 4;
            this.bookIdInput.TextChanged += new System.EventHandler(this.titleInput_TextChanged);
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(83, 88);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(146, 20);
            this.authorInput.TabIndex = 5;
            // 
            // checkUserTrustButton
            // 
            this.checkUserTrustButton.Location = new System.Drawing.Point(273, 15);
            this.checkUserTrustButton.Name = "checkUserTrustButton";
            this.checkUserTrustButton.Size = new System.Drawing.Size(85, 23);
            this.checkUserTrustButton.TabIndex = 6;
            this.checkUserTrustButton.Text = "Verifica cititorul";
            this.checkUserTrustButton.UseVisualStyleBackColor = true;
            this.checkUserTrustButton.Click += new System.EventHandler(this.checkUserTrustButton_Click);
            // 
            // isUserTrustworthyLabel
            // 
            this.isUserTrustworthyLabel.AutoSize = true;
            this.isUserTrustworthyLabel.Location = new System.Drawing.Point(279, 55);
            this.isUserTrustworthyLabel.Name = "isUserTrustworthyLabel";
            this.isUserTrustworthyLabel.Size = new System.Drawing.Size(91, 13);
            this.isUserTrustworthyLabel.TabIndex = 7;
            this.isUserTrustworthyLabel.Text = "isUserTrustworthy";
            this.isUserTrustworthyLabel.Click += new System.EventHandler(this.isUserTrustworthyLabel_Click);
            // 
            // loanBookButton
            // 
            this.loanBookButton.Location = new System.Drawing.Point(454, 323);
            this.loanBookButton.Name = "loanBookButton";
            this.loanBookButton.Size = new System.Drawing.Size(105, 23);
            this.loanBookButton.TabIndex = 8;
            this.loanBookButton.Text = "Imprumuta cartea";
            this.loanBookButton.UseVisualStyleBackColor = true;
            this.loanBookButton.Click += new System.EventHandler(this.loanBookButton_Click);
            // 
            // availableBooksList
            // 
            this.availableBooksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Titlu,
            this.Autor,
            this.Gen});
            this.availableBooksList.Location = new System.Drawing.Point(15, 219);
            this.availableBooksList.Name = "availableBooksList";
            this.availableBooksList.Size = new System.Drawing.Size(421, 238);
            this.availableBooksList.TabIndex = 9;
            this.availableBooksList.UseCompatibleStateImageBehavior = false;
            this.availableBooksList.View = System.Windows.Forms.View.Details;
            this.availableBooksList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 66;
            // 
            // Titlu
            // 
            this.Titlu.Text = "Titlu";
            this.Titlu.Width = 105;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 115;
            // 
            // Gen
            // 
            this.Gen.Text = "Gen";
            this.Gen.Width = 102;
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Location = new System.Drawing.Point(12, 165);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(27, 13);
            this.genLabel.TabIndex = 10;
            this.genLabel.Text = "Gen";
            // 
            // genInput
            // 
            this.genInput.Location = new System.Drawing.Point(83, 165);
            this.genInput.Name = "genInput";
            this.genInput.Size = new System.Drawing.Size(146, 20);
            this.genInput.TabIndex = 11;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(273, 165);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Filtreaza";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookIsNotAvailable
            // 
            this.bookIsNotAvailable.AutoSize = true;
            this.bookIsNotAvailable.Location = new System.Drawing.Point(194, 126);
            this.bookIsNotAvailable.Name = "bookIsNotAvailable";
            this.bookIsNotAvailable.Size = new System.Drawing.Size(35, 13);
            this.bookIsNotAvailable.TabIndex = 13;
            this.bookIsNotAvailable.Text = "label1";
            // 
            // LoanBookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 469);
            this.Controls.Add(this.bookIsNotAvailable);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.genInput);
            this.Controls.Add(this.genLabel);
            this.Controls.Add(this.availableBooksList);
            this.Controls.Add(this.loanBookButton);
            this.Controls.Add(this.isUserTrustworthyLabel);
            this.Controls.Add(this.checkUserTrustButton);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.bookIdInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.bookIdLabel);
            this.Controls.Add(this.emailLabel);
            this.Name = "LoanBookPage";
            this.Text = "LoanBookPage";
            this.Load += new System.EventHandler(this.LoanBookPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label bookIdLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox bookIdInput;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.Button checkUserTrustButton;
        private System.Windows.Forms.Label isUserTrustworthyLabel;
        private System.Windows.Forms.Button loanBookButton;
        private System.Windows.Forms.ListView availableBooksList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Titlu;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.TextBox genInput;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label bookIsNotAvailable;
    }
}