
namespace DriveManager.Views
{
    partial class Home
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.EASY_PARK;
            pictureBox1.Location = new Point(318, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(215, 100);
            label1.Name = "label1";
            label1.Size = new Size(406, 26);
            label1.TabIndex = 1;
            label1.Text = "Seja bem-vindo, o que deseja fazer?";
            // 
            // button1
            // 
            button1.Location = new Point(112, 218);
            button1.Name = "button1";
            button1.Size = new Size(198, 37);
            button1.TabIndex = 2;
            button1.Text = "entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 180);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 3;
            label2.Text = "Cadastro de motoristas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 180);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 5;
            label3.Text = "Cadastro de veículos";
            // 
            // button2
            // 
            button2.Location = new Point(497, 218);
            button2.Name = "button2";
            button2.Size = new Size(176, 37);
            button2.TabIndex = 4;
            button2.Text = "entrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 281);
            label4.Name = "label4";
            label4.Size = new Size(246, 25);
            label4.TabIndex = 7;
            label4.Text = "Gerenciamento de motoristas";
            // 
            // button3
            // 
            button3.Location = new Point(112, 319);
            button3.Name = "button3";
            button3.Size = new Size(198, 37);
            button3.TabIndex = 6;
            button3.Text = "entrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 281);
            label5.Name = "label5";
            label5.Size = new Size(224, 25);
            label5.TabIndex = 9;
            label5.Text = "Gerenciamento de veículos";
            // 
            // button4
            // 
            button4.Location = new Point(497, 319);
            button4.Name = "button4";
            button4.Size = new Size(176, 37);
            button4.TabIndex = 8;
            button4.Text = "entrar";
            button4.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Easy Park ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button3;
        private Label label5;
        private Button button4;
    }
}