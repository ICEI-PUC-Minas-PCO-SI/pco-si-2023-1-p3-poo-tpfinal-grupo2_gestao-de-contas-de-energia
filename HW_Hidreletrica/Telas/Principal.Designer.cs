namespace HW_Hidreletrica
{
	partial class Principal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
			pictureBox1 = new PictureBox();
			btn_login = new Button();
			btn_cadastro = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(152, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(309, 235);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// btn_login
			// 
			btn_login.BackColor = Color.DarkSlateGray;
			btn_login.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			btn_login.Location = new Point(75, 293);
			btn_login.Name = "btn_login";
			btn_login.Size = new Size(139, 67);
			btn_login.TabIndex = 1;
			btn_login.Text = "Login";
			btn_login.UseVisualStyleBackColor = false;
			btn_login.Click += btn_login_Click;
			// 
			// btn_cadastro
			// 
			btn_cadastro.BackColor = Color.DarkSlateGray;
			btn_cadastro.Font = new Font("Segoe Print", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
			btn_cadastro.Location = new Point(394, 293);
			btn_cadastro.Name = "btn_cadastro";
			btn_cadastro.Size = new Size(139, 67);
			btn_cadastro.TabIndex = 2;
			btn_cadastro.Text = "Cadastro";
			btn_cadastro.UseVisualStyleBackColor = false;
			btn_cadastro.Click += btn_cadastro_Click;
			// 
			// Principal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.Landing_Page;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(597, 409);
			Controls.Add(btn_cadastro);
			Controls.Add(btn_login);
			Controls.Add(pictureBox1);
			DoubleBuffered = true;
			Name = "Principal";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Principal";
			FormClosing += Principal_FormClosing;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Button btn_login;
		private Button btn_cadastro;
	}
}