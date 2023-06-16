namespace HW_Hidreletrica.Telas {
	partial class Login {
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
			label1 = new Label();
			label2 = new Label();
			txtEmail = new TextBox();
			txtSenha = new TextBox();
			label4 = new Label();
			button1 = new Button();
			folderBrowserDialog1 = new FolderBrowserDialog();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			label3 = new Label();
			cbxTipoUsuario = new ComboBox();
			mensagem = new Label();
			btnVoltar = new Button();
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
			label2.Location = new Point(166, 103);
			label2.Name = "label2";
			label2.Size = new Size(54, 25);
			label2.TabIndex = 1;
			label2.Text = "Email";
			label2.Click += label2_Click;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(89, 131);
			txtEmail.MaxLength = 30;
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(216, 23);
			txtEmail.TabIndex = 1;
			txtEmail.TextChanged += txt_usuario_TextChanged;
			// 
			// txtSenha
			// 
			txtSenha.Location = new Point(89, 206);
			txtSenha.MaxLength = 11;
			txtSenha.Name = "txtSenha";
			txtSenha.PasswordChar = '●';
			txtSenha.Size = new Size(216, 23);
			txtSenha.TabIndex = 2;
			txtSenha.TextChanged += txt_password_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.White;
			label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(163, 178);
			label4.Name = "label4";
			label4.Size = new Size(60, 25);
			label4.TabIndex = 5;
			label4.Text = "Senha";
			label4.Click += label4_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.DarkCyan;
			button1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Location = new Point(197, 350);
			button1.Name = "button1";
			button1.Size = new Size(88, 49);
			button1.TabIndex = 4;
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
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.White;
			label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(134, 238);
			label3.Name = "label3";
			label3.Size = new Size(112, 25);
			label3.TabIndex = 12;
			label3.Text = "Tipo Usuario";
			// 
			// cbxTipoUsuario
			// 
			cbxTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxTipoUsuario.FormattingEnabled = true;
			cbxTipoUsuario.Items.AddRange(new object[] { "Cliente", "Administrador" });
			cbxTipoUsuario.Location = new Point(130, 266);
			cbxTipoUsuario.Name = "cbxTipoUsuario";
			cbxTipoUsuario.Size = new Size(131, 23);
			cbxTipoUsuario.TabIndex = 3;
			// 
			// mensagem
			// 
			mensagem.AutoSize = true;
			mensagem.BackColor = Color.White;
			mensagem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			mensagem.ForeColor = Color.Red;
			mensagem.Location = new Point(89, 311);
			mensagem.Name = "mensagem";
			mensagem.Size = new Size(186, 20);
			mensagem.TabIndex = 15;
			mensagem.Text = "Preencha todos os campos";
			mensagem.Visible = false;
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.DarkCyan;
			btnVoltar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnVoltar.Location = new Point(89, 350);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(90, 49);
			btnVoltar.TabIndex = 16;
			btnVoltar.Text = "Cancelar";
			btnVoltar.UseVisualStyleBackColor = false;
			btnVoltar.Click += btnVoltar_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkCyan;
			ClientSize = new Size(770, 463);
			Controls.Add(btnVoltar);
			Controls.Add(mensagem);
			Controls.Add(cbxTipoUsuario);
			Controls.Add(label3);
			Controls.Add(pictureBox2);
			Controls.Add(button1);
			Controls.Add(txtSenha);
			Controls.Add(label4);
			Controls.Add(txtEmail);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtEmail;
		private TextBox txtSenha;
		private Label label4;
		private Button button1;
		private FolderBrowserDialog folderBrowserDialog1;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label label3;
		private ComboBox cbxTipoUsuario;
		private Label mensagem;
		private Button btnVoltar;
	}
}