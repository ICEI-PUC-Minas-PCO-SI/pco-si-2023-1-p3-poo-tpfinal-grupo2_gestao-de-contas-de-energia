namespace HW_Hidreletrica.Telas.Tela_emp {
	partial class Perfil_EMP {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil_EMP));
			panel1 = new Panel();
			lb_perfil = new Label();
			lb_email = new Label();
			txt_email = new TextBox();
			lb_nome = new Label();
			btn_sair = new Button();
			pictureBox1 = new PictureBox();
			txt_nome = new TextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(lb_perfil);
			panel1.Controls.Add(lb_email);
			panel1.Controls.Add(txt_email);
			panel1.Controls.Add(lb_nome);
			panel1.Controls.Add(btn_sair);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(txt_nome);
			panel1.Location = new Point(220, 36);
			panel1.Name = "panel1";
			panel1.Size = new Size(409, 441);
			panel1.TabIndex = 1;
			// 
			// lb_perfil
			// 
			lb_perfil.AutoSize = true;
			lb_perfil.Font = new Font("Segoe Print", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
			lb_perfil.Location = new Point(145, 4);
			lb_perfil.Name = "lb_perfil";
			lb_perfil.Size = new Size(112, 58);
			lb_perfil.TabIndex = 12;
			lb_perfil.Text = "Perfil";
			// 
			// lb_email
			// 
			lb_email.AutoSize = true;
			lb_email.Location = new Point(180, 297);
			lb_email.Name = "lb_email";
			lb_email.Size = new Size(36, 15);
			lb_email.TabIndex = 8;
			lb_email.Text = "Email";
			// 
			// txt_email
			// 
			txt_email.Location = new Point(120, 293);
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(159, 23);
			txt_email.TabIndex = 9;
			// 
			// lb_nome
			// 
			lb_nome.AutoSize = true;
			lb_nome.Location = new Point(178, 242);
			lb_nome.Name = "lb_nome";
			lb_nome.Size = new Size(40, 15);
			lb_nome.TabIndex = 3;
			lb_nome.Text = "Nome";
			// 
			// btn_sair
			// 
			btn_sair.BackColor = Color.Firebrick;
			btn_sair.Location = new Point(176, 359);
			btn_sair.Name = "btn_sair";
			btn_sair.Size = new Size(47, 37);
			btn_sair.TabIndex = 2;
			btn_sair.Text = "Sair";
			btn_sair.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(120, 75);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(159, 127);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// txt_nome
			// 
			txt_nome.Location = new Point(120, 239);
			txt_nome.Name = "txt_nome";
			txt_nome.Size = new Size(159, 23);
			txt_nome.TabIndex = 4;
			// 
			// Perfil_EMP
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkCyan;
			ClientSize = new Size(832, 519);
			Controls.Add(panel1);
			Name = "Perfil_EMP";
			Text = "Perfil_EMP";
			Load += Perfil_EMP_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label lb_perfil;
		private Label lb_email;
		private TextBox txt_email;
		private Button btn_editar;
		private Label lb_nome;
		private Button btn_sair;
		private PictureBox pictureBox1;
		private TextBox txt_nome;
	}
}