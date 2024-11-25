namespace DriveManager.Views
{
    partial class CadastroMotoristas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            cadBtn = new Button();
            telTxt = new TextBox();
            emailTxt = new TextBox();
            nomeTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(248, 46);
            button1.Name = "button1";
            button1.Size = new Size(43, 38);
            button1.TabIndex = 25;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // cadBtn
            // 
            cadBtn.Location = new Point(388, 365);
            cadBtn.Name = "cadBtn";
            cadBtn.Size = new Size(90, 39);
            cadBtn.TabIndex = 24;
            cadBtn.Text = "Cadastre-se";
            cadBtn.UseVisualStyleBackColor = true;
            cadBtn.Click += cadBtn_Click;
            // 
            // telTxt
            // 
            telTxt.Location = new Point(310, 304);
            telTxt.Name = "telTxt";
            telTxt.Size = new Size(230, 31);
            telTxt.TabIndex = 23;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(310, 226);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(230, 31);
            emailTxt.TabIndex = 22;
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(310, 145);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(230, 31);
            nomeTxt.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 276);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 20;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 198);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 117);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 18;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 53);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 17;
            label1.Text = "Cadastre um novo motorista:\r\n\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.EASY_PARK;
            pictureBox1.Location = new Point(673, 385);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // CadastroMotoristas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(cadBtn);
            Controls.Add(telTxt);
            Controls.Add(emailTxt);
            Controls.Add(nomeTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroMotoristas";
            Text = "Cadastro de motoristas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button cadBtn;
        private TextBox telTxt;
        private TextBox emailTxt;
        private TextBox nomeTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}