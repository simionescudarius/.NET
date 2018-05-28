namespace WindowsFormsApp1 {
    partial class BuyBooksPage {
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
            this.titleInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.genderInput = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.buyBooksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(98, 24);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(154, 20);
            this.titleInput.TabIndex = 0;
            this.titleInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Titlu";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 104);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(65, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Nume autor:";
            this.authorLabel.Click += new System.EventHandler(this.authorLabel_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 136);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(27, 13);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gen";
            this.genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(98, 101);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(154, 20);
            this.authorInput.TabIndex = 4;
            // 
            // genderInput
            // 
            this.genderInput.Location = new System.Drawing.Point(98, 136);
            this.genderInput.Name = "genderInput";
            this.genderInput.Size = new System.Drawing.Size(154, 20);
            this.genderInput.TabIndex = 5;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(12, 174);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(38, 13);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "Numar";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(98, 174);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(53, 20);
            this.numberInput.TabIndex = 7;
            // 
            // buyBooksButton
            // 
            this.buyBooksButton.Location = new System.Drawing.Point(98, 219);
            this.buyBooksButton.Name = "buyBooksButton";
            this.buyBooksButton.Size = new System.Drawing.Size(154, 29);
            this.buyBooksButton.TabIndex = 8;
            this.buyBooksButton.Text = "Cumpara !";
            this.buyBooksButton.UseVisualStyleBackColor = true;
            this.buyBooksButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prenume Autor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 10;
            // 
            // BuyBooksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 272);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyBooksButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.genderInput);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleInput);
            this.Name = "BuyBooksPage";
            this.Text = "BuyBooksForm";
            this.Load += new System.EventHandler(this.BuyBooksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.TextBox genderInput;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button buyBooksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}