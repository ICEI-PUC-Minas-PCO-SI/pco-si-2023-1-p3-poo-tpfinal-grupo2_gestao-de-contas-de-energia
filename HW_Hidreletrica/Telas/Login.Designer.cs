namespace HW_Hidreletrica.Telas
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txt_usuario = new TextBox();
            txt_password = new TextBox();
            label4 = new Label();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Print", 25.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 13);
            label1.Name = "label1";
            label1.Size = new Size(122, 62);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(163, 145);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(86, 173);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(216, 23);
            txt_usuario.TabIndex = 2;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(86, 248);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '●';
            txt_password.Size = new Size(216, 23);
            txt_password.TabIndex = 6;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(160, 220);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Segoe Print", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(136, 358);
            button1.Name = "button1";
            button1.Size = new Size(108, 53);
            button1.TabIndex = 7;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_login;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 441);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._1;
            pictureBox2.Location = new Point(389, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(377, 303);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Cliente", "Administrator" });
            comboBox1.Location = new Point(128, 308);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 280);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 12;
            label3.Text = "Tipo Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(770, 463);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_usuario;
        private TextBox txt_password;
        private Label label4;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private Label label3;
    }
}