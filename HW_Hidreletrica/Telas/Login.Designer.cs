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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 25.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 62);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(124, 145);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 1;
            label2.Text = "Email o Usuario";
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
            txt_password.Location = new Point(86, 261);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(216, 23);
            txt_password.TabIndex = 6;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(163, 233);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe Print", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(124, 341);
            button1.Name = "button1";
            button1.Size = new Size(139, 67);
            button1.TabIndex = 7;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_login;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(401, 494);
            Controls.Add(button1);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
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
    }
}