namespace HW_Hidreletrica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_cadastro = new Button();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_cadastro
            // 
            btn_cadastro.BackColor = Color.DarkSlateGray;
            btn_cadastro.Font = new Font("Segoe Print", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastro.Location = new Point(352, 332);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(120, 57);
            btn_cadastro.TabIndex = 5;
            btn_cadastro.Text = "Cadastro";
            btn_cadastro.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkSlateGray;
            btn_login.Font = new Font("Segoe Print", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(98, 332);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(120, 57);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Landing_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(574, 429);
            Controls.Add(pictureBox1);
            Controls.Add(btn_cadastro);
            Controls.Add(btn_login);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cadastro;
        private Button btn_login;
        private PictureBox pictureBox1;
    }
}