namespace HW_Hidreletrica.Telas.Tela_emp
{
	partial class Cadastro_Administrador
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Administrador));
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			btn_cadastrar = new Button();
			btn_cancelar = new Button();
			txt_confsenha = new TextBox();
			label6 = new Label();
			txt_senha = new TextBox();
			label5 = new Label();
			txt_nome = new TextBox();
			label3 = new Label();
			txt_email = new TextBox();
			label2 = new Label();
			label1 = new Label();
			errorProvider1 = new ErrorProvider(components);
			errorProvider2 = new ErrorProvider(components);
			errorProvider3 = new ErrorProvider(components);
			errorProvider4 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 78);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(330, 389);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 10;
			pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(btn_cadastrar);
			panel1.Controls.Add(btn_cancelar);
			panel1.Controls.Add(txt_confsenha);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(txt_senha);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(txt_nome);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(txt_email);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(358, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(471, 519);
			panel1.TabIndex = 11;
			// 
			// btn_cadastrar
			// 
			btn_cadastrar.BackColor = Color.DarkCyan;
			btn_cadastrar.FlatAppearance.BorderColor = Color.DarkCyan;
			btn_cadastrar.Font = new Font("Segoe Print", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
			btn_cadastrar.Location = new Point(121, 427);
			btn_cadastrar.Name = "btn_cadastrar";
			btn_cadastrar.Size = new Size(107, 58);
			btn_cadastrar.TabIndex = 9;
			btn_cadastrar.Text = "Cadastrar";
			btn_cadastrar.UseVisualStyleBackColor = false;
			btn_cadastrar.Click += btn_cadastrar_Click;
			// 
			// btn_cancelar
			// 
			btn_cancelar.BackColor = Color.DarkCyan;
			btn_cancelar.FlatAppearance.BorderColor = Color.DarkCyan;
			btn_cancelar.Font = new Font("Segoe Print", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
			btn_cancelar.Location = new Point(255, 427);
			btn_cancelar.Name = "btn_cancelar";
			btn_cancelar.Size = new Size(102, 58);
			btn_cancelar.TabIndex = 10;
			btn_cancelar.Text = "Cancelar";
			btn_cancelar.UseVisualStyleBackColor = false;
			btn_cancelar.Click += btn_cancelar_Click;
			// 
			// txt_confsenha
			// 
			txt_confsenha.Location = new Point(117, 363);
			txt_confsenha.MaxLength = 11;
			txt_confsenha.Name = "txt_confsenha";
			txt_confsenha.Size = new Size(253, 23);
			txt_confsenha.TabIndex = 6;
			txt_confsenha.UseSystemPasswordChar = true;
			txt_confsenha.Leave += txt_confsenha_Leave;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(117, 328);
			label6.Name = "label6";
			label6.Size = new Size(136, 23);
			label6.TabIndex = 9;
			label6.Text = "Confirmar senha";
			// 
			// txt_senha
			// 
			txt_senha.Location = new Point(117, 287);
			txt_senha.MaxLength = 11;
			txt_senha.Name = "txt_senha";
			txt_senha.Size = new Size(253, 23);
			txt_senha.TabIndex = 5;
			txt_senha.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(117, 252);
			label5.Name = "label5";
			label5.Size = new Size(57, 23);
			label5.TabIndex = 7;
			label5.Text = "Senha";
			// 
			// txt_nome
			// 
			txt_nome.Location = new Point(117, 213);
			txt_nome.MaxLength = 80;
			txt_nome.Name = "txt_nome";
			txt_nome.Size = new Size(253, 23);
			txt_nome.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(117, 178);
			label3.Name = "label3";
			label3.Size = new Size(137, 23);
			label3.TabIndex = 3;
			label3.Text = "Nome Completo";
			// 
			// txt_email
			// 
			txt_email.ForeColor = SystemColors.WindowText;
			txt_email.Location = new Point(117, 142);
			txt_email.MaxLength = 256;
			txt_email.Name = "txt_email";
			txt_email.PlaceholderText = "xxxxxxx@xxxxx.com";
			txt_email.Size = new Size(253, 23);
			txt_email.TabIndex = 1;
			txt_email.Leave += txt_email_Leave_1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(117, 105);
			label2.Name = "label2";
			label2.Size = new Size(51, 23);
			label2.TabIndex = 1;
			label2.Text = "Email";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe Print", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(24, 22);
			label1.Name = "label1";
			label1.Size = new Size(430, 58);
			label1.TabIndex = 0;
			label1.Text = "Cadastro Administrador";
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			errorProvider2.ContainerControl = this;
			// 
			// errorProvider3
			// 
			errorProvider3.ContainerControl = this;
			// 
			// errorProvider4
			// 
			errorProvider4.ContainerControl = this;
			// 
			// Cadastro_Administrador
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkCyan;
			ClientSize = new Size(868, 541);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Name = "Cadastro_Administrador";
			Text = "Cadastro_Administrador";
			Load += Cadastro_Administrador_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Panel panel1;
		private Button btn_cadastrar;
		private Button btn_cancelar;
		private TextBox txt_confsenha;
		private Label label6;
		private TextBox txt_senha;
		private Label label5;
		private TextBox txt_nome;
		private Label label3;
		private TextBox txt_email;
		private Label label2;
		private Label label1;
		private ErrorProvider errorProvider1;
		private ErrorProvider errorProvider2;
		private ErrorProvider errorProvider3;
		private ErrorProvider errorProvider4;
	}
}