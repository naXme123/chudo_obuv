namespace WinFormsApp1
{
    partial class Form1
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
            idTitle = new Label();
            label2 = new Label();
            txtLogin = new TextBox();
            btnLogin = new Button();
            btnGuest = new Button();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // idTitle
            // 
            idTitle.AutoSize = true;
            idTitle.Location = new Point(363, 117);
            idTitle.Name = "idTitle";
            idTitle.Size = new Size(93, 15);
            idTitle.TabIndex = 0;
            idTitle.Text = "Вход в систему ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 167);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Логин ";
            label2.Click += label2_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(307, 195);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 23);
            txtLogin.TabIndex = 2;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(307, 224);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Войти ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(307, 253);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(200, 23);
            btnGuest.TabIndex = 4;
            btnGuest.Text = "Смотреть каталог без входа ";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(307, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(191, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picLogo);
            Controls.Add(btnGuest);
            Controls.Add(btnLogin);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(idTitle);
            Name = "Form1";
            Text = "Чудо Обувь — вход в систему";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idTitle;
        private Label label2;
        private TextBox txtLogin;
        private Button btnLogin;
        private Button btnGuest;
        private PictureBox picLogo;
    }
}
