namespace HW_Hidreletrica.Telas.Tela_emp
{
	partial class Perfil_EMP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil_EMP));
			panel1 = new Panel();
			btn_voltar = new Button();
			btnCadastro = new Button();
			lb_perfil = new Label();
			lb_email = new Label();
			lb_nome = new Label();
			btn_sair = new Button();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(btn_voltar);
			panel1.Controls.Add(btnCadastro);
			panel1.Controls.Add(lb_perfil);
			panel1.Controls.Add(lb_email);
			panel1.Controls.Add(lb_nome);
			panel1.Controls.Add(btn_sair);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(220, 36);
			panel1.Name = "panel1";
			panel1.Size = new Size(409, 441);
			panel1.TabIndex = 1;
			// 
			// btn_voltar
			// 
			btn_voltar.BackColor = Color.LightSkyBlue;
			btn_voltar.FlatAppearance.BorderSize = 0;
			btn_voltar.FlatStyle = FlatStyle.Flat;
			btn_voltar.Location = new Point(129, 378);
			btn_voltar.Name = "btn_voltar";
			btn_voltar.Size = new Size(63, 37);
			btn_voltar.TabIndex = 14;
			btn_voltar.Text = "Voltar";
			btn_voltar.UseVisualStyleBackColor = false;
			btn_voltar.Click += btn_voltar_Click;
			// 
			// btnCadastro
			// 
			btnCadastro.BackColor = Color.FromArgb(0, 192, 0);
			btnCadastro.FlatAppearance.BorderSize = 0;
			btnCadastro.FlatStyle = FlatStyle.Flat;
			btnCadastro.Location = new Point(129, 328);
			btnCadastro.Name = "btnCadastro";
			btnCadastro.Size = new Size(150, 32);
			btnCadastro.TabIndex = 13;
			btnCadastro.Text = "Cadastrar administrador";
			btnCadastro.UseVisualStyleBackColor = false;
			btnCadastro.Click += btnCadastro_Click;
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
			lb_email.BorderStyle = BorderStyle.FixedSingle;
			lb_email.Location = new Point(99, 285);
			lb_email.MinimumSize = new Size(200, 20);
			lb_email.Name = "lb_email";
			lb_email.Size = new Size(200, 20);
			lb_email.TabIndex = 8;
			lb_email.Text = "Email";
			lb_email.TextAlign = ContentAlignment.BottomCenter;
			// 
			// lb_nome
			// 
			lb_nome.AutoSize = true;
			lb_nome.BorderStyle = BorderStyle.FixedSingle;
			lb_nome.Location = new Point(99, 236);
			lb_nome.MinimumSize = new Size(200, 20);
			lb_nome.Name = "lb_nome";
			lb_nome.Size = new Size(200, 20);
			lb_nome.TabIndex = 3;
			lb_nome.Text = "Nome";
			lb_nome.TextAlign = ContentAlignment.BottomCenter;
			// 
			// btn_sair
			// 
			btn_sair.BackColor = Color.Firebrick;
			btn_sair.FlatAppearance.BorderSize = 0;
			btn_sair.FlatStyle = FlatStyle.Flat;
			btn_sair.Location = new Point(198, 378);
			btn_sair.Name = "btn_sair";
			btn_sair.Size = new Size(65, 37);
			btn_sair.TabIndex = 2;
			btn_sair.Text = "Sair";
			btn_sair.UseVisualStyleBackColor = false;
			btn_sair.Click += btn_sair_Click;
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
			// Perfil_EMP
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkCyan;
			ClientSize = new Size(832, 519);
			Controls.Add(panel1);
			Name = "Perfil_EMP";
			StartPosition = FormStartPosition.CenterScreen;
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
		private Button btn_editar;
		private Label lb_nome;
		private Button btn_sair;
		private PictureBox pictureBox1;
		private Button btnCadastro;
		private Button btn_voltar;
	}
}