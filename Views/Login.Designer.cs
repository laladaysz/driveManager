namespace DriveManager
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            senhaTxtBox = new TextBox();
            emailTxtBox = new TextBox();
            entrarBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // senhaTxtBox
            // 
            senhaTxtBox.Location = new Point(295, 253);
            senhaTxtBox.Name = "senhaTxtBox";
            senhaTxtBox.PasswordChar = '*';
            senhaTxtBox.Size = new Size(210, 31);
            senhaTxtBox.TabIndex = 12;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(295, 163);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(210, 31);
            emailTxtBox.TabIndex = 11;
            // 
            // entrarBtn
            // 
            entrarBtn.Location = new Point(343, 316);
            entrarBtn.Name = "entrarBtn";
            entrarBtn.Size = new Size(126, 52);
            entrarBtn.TabIndex = 10;
            entrarBtn.Text = "Entrar";
            entrarBtn.UseVisualStyleBackColor = true;
            entrarBtn.Click += this.entrarBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 225);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 135);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(367, 82);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 7;
            label1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(senhaTxtBox);
            Controls.Add(emailTxtBox);
            Controls.Add(entrarBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login page ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox senhaTxtBox;
        private TextBox emailTxtBox;
        private Button entrarBtn;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
