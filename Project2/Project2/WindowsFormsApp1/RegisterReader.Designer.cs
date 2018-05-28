namespace WindowsFormsApp1 {
    partial class RegisterReader {
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.adressInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(0, 9);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(35, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Nume";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(0, 53);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(49, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Prenume";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(0, 93);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(40, 13);
            this.adress.TabIndex = 2;
            this.adress.Text = "Adresa";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(0, 128);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 3;
            this.email.Text = "Email";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(55, 2);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(117, 20);
            this.lastNameInput.TabIndex = 4;
            this.lastNameInput.TextChanged += new System.EventHandler(this.lastNameInput_TextChanged);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(55, 46);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(117, 20);
            this.firstNameInput.TabIndex = 5;
            // 
            // adressInput
            // 
            this.adressInput.Location = new System.Drawing.Point(55, 86);
            this.adressInput.Name = "adressInput";
            this.adressInput.Size = new System.Drawing.Size(117, 20);
            this.adressInput.TabIndex = 6;
            this.adressInput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(55, 121);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(117, 20);
            this.emailInput.TabIndex = 7;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(55, 183);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(123, 28);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Inregistreaza";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegisterReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 262);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.adressInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.email);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "RegisterReader";
            this.Text = "RegisterReader";
            this.Load += new System.EventHandler(this.RegisterReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox adressInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Button registerButton;
    }
}