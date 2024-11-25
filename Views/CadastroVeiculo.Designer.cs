namespace DriveManager.Views
{
    partial class CadastroVeiculo
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
            motoristaBox = new ComboBox();
            label5 = new Label();
            cadBtn = new Button();
            corTxt = new TextBox();
            modeloTxt = new TextBox();
            placaTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(252, 25);
            button1.Name = "button1";
            button1.Size = new Size(43, 38);
            button1.TabIndex = 29;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // motoristaBox
            // 
            motoristaBox.FormattingEnabled = true;
            motoristaBox.Location = new Point(319, 339);
            motoristaBox.Name = "motoristaBox";
            motoristaBox.Size = new Size(230, 33);
            motoristaBox.TabIndex = 28;
            motoristaBox.Text = "Selecione um motorista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 311);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 27;
            label5.Text = "Motorista";
            // 
            // cadBtn
            // 
            cadBtn.Location = new Point(388, 387);
            cadBtn.Name = "cadBtn";
            cadBtn.Size = new Size(90, 39);
            cadBtn.TabIndex = 26;
            cadBtn.Text = "Cadastre-se";
            cadBtn.UseVisualStyleBackColor = true;
            cadBtn.Click += cadBtn_Click;
            // 
            // corTxt
            // 
            corTxt.Location = new Point(319, 264);
            corTxt.Name = "corTxt";
            corTxt.Size = new Size(230, 31);
            corTxt.TabIndex = 25;
            // 
            // modeloTxt
            // 
            modeloTxt.Location = new Point(319, 186);
            modeloTxt.Name = "modeloTxt";
            modeloTxt.Size = new Size(230, 31);
            modeloTxt.TabIndex = 24;
            // 
            // placaTxt
            // 
            placaTxt.Location = new Point(319, 105);
            placaTxt.Name = "placaTxt";
            placaTxt.Size = new Size(230, 31);
            placaTxt.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 236);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 22;
            label4.Text = "Cor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 158);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 21;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 77);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 20;
            label2.Text = "Placa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 32);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 19;
            label1.Text = "Cadastre um novo veículo";
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(motoristaBox);
            Controls.Add(label5);
            Controls.Add(cadBtn);
            Controls.Add(corTxt);
            Controls.Add(modeloTxt);
            Controls.Add(placaTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroVeiculo";
            Text = "Cadastro de veículos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox motoristaBox;
        private Label label5;
        private Button cadBtn;
        private TextBox corTxt;
        private TextBox modeloTxt;
        private TextBox placaTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}