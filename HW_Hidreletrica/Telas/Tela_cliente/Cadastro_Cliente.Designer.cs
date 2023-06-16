namespace HW_Hidreletrica.Telas.Tela_cliente
{
	partial class Cadastro_Cliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Cliente));
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			dtNascimento = new DateTimePicker();
			txt_telefone = new MaskedTextBox();
			txt_CNPJ_CPF = new MaskedTextBox();
			cbx_cpf = new ComboBox();
			label8 = new Label();
			btn_cadastrar = new Button();
			btn_cancelar = new Button();
			label7 = new Label();
			txt_confsenha = new TextBox();
			label6 = new Label();
			txt_senha = new TextBox();
			label5 = new Label();
			label4 = new Label();
			txt_nome = new TextBox();
			label3 = new Label();
			txt_email = new TextBox();
			label2 = new Label();
			label1 = new Label();
			errorProvider1 = new ErrorProvider(components);
			errorProvider2 = new ErrorProvider(components);
			errorProvider3 = new ErrorProvider(components);
			errorProvider4 = new ErrorProvider(components);
			errorProvider5 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 94);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(282, 341);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(dtNascimento);
			panel1.Controls.Add(txt_telefone);
			panel1.Controls.Add(txt_CNPJ_CPF);
			panel1.Controls.Add(cbx_cpf);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(btn_cadastrar);
			panel1.Controls.Add(btn_cancelar);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(txt_confsenha);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(txt_senha);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(txt_nome);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(txt_email);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(309, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(557, 519);
			panel1.TabIndex = 9;
			// 
			// dtNascimento
			// 
			dtNascimento.CustomFormat = "dd/MM/yyyy";
			dtNascimento.Format = DateTimePickerFormat.Custom;
			dtNascimento.Location = new Point(316, 212);
			dtNascimento.Name = "dtNascimento";
			dtNascimento.Size = new Size(200, 23);
			dtNascimento.TabIndex = 16;
			// 
			// txt_telefone
			// 
			txt_telefone.Location = new Point(316, 141);
			txt_telefone.Mask = "00 00000-0000";
			txt_telefone.Name = "txt_telefone";
			txt_telefone.Size = new Size(216, 23);
			txt_telefone.TabIndex = 2;
			txt_telefone.TextAlign = HorizontalAlignment.Center;
			txt_telefone.Leave += txt_telefone_Leave_1;
			// 
			// txt_CNPJ_CPF
			// 
			txt_CNPJ_CPF.Location = new Point(164, 365);
			txt_CNPJ_CPF.Name = "txt_CNPJ_CPF";
			txt_CNPJ_CPF.Size = new Size(211, 23);
			txt_CNPJ_CPF.TabIndex = 8;
			txt_CNPJ_CPF.Leave += txt_CNPJ_CPF_Leave;
			// 
			// cbx_cpf
			// 
			cbx_cpf.DropDownStyle = ComboBoxStyle.DropDownList;
			cbx_cpf.FormattingEnabled = true;
			cbx_cpf.IntegralHeight = false;
			cbx_cpf.Items.AddRange(new object[] { "CPF", "CNPJ" });
			cbx_cpf.Location = new Point(19, 365);
			cbx_cpf.Name = "cbx_cpf";
			cbx_cpf.Size = new Size(108, 23);
			cbx_cpf.TabIndex = 7;
			cbx_cpf.SelectedIndexChanged += cbx_cpf_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(19, 325);
			label8.Name = "label8";
			label8.Size = new Size(108, 23);
			label8.TabIndex = 15;
			label8.Text = "CPF ou CNPJ";
			// 
			// btn_cadastrar
			// 
			btn_cadastrar.BackColor = Color.DarkCyan;
			btn_cadastrar.FlatAppearance.BorderColor = Color.DarkCyan;
			btn_cadastrar.Font = new Font("Segoe Print", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
			btn_cadastrar.Location = new Point(182, 435);
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
			btn_cancelar.Location = new Point(316, 435);
			btn_cancelar.Name = "btn_cancelar";
			btn_cancelar.Size = new Size(102, 58);
			btn_cancelar.TabIndex = 10;
			btn_cancelar.Text = "Cancelar";
			btn_cancelar.UseVisualStyleBackColor = false;
			btn_cancelar.Click += btn_cancelar_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(330, 177);
			label7.Name = "label7";
			label7.Size = new Size(166, 23);
			label7.TabIndex = 12;
			label7.Text = "Data de Nascimento";
			// 
			// txt_confsenha
			// 
			txt_confsenha.Location = new Point(291, 289);
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
			label6.Location = new Point(291, 254);
			label6.Name = "label6";
			label6.Size = new Size(136, 23);
			label6.TabIndex = 9;
			label6.Text = "Confirmar senha";
			// 
			// txt_senha
			// 
			txt_senha.Location = new Point(19, 289);
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
			label5.Location = new Point(19, 254);
			label5.Name = "label5";
			label5.Size = new Size(57, 23);
			label5.TabIndex = 7;
			label5.Text = "Senha";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(381, 115);
			label4.Name = "label4";
			label4.Size = new Size(73, 23);
			label4.TabIndex = 5;
			label4.Text = "Telefone";
			// 
			// txt_nome
			// 
			txt_nome.Location = new Point(19, 212);
			txt_nome.MaxLength = 80;
			txt_nome.Name = "txt_nome";
			txt_nome.Size = new Size(253, 23);
			txt_nome.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(19, 177);
			label3.Name = "label3";
			label3.Size = new Size(137, 23);
			label3.TabIndex = 3;
			label3.Text = "Nome Completo";
			// 
			// txt_email
			// 
			txt_email.ForeColor = SystemColors.WindowText;
			txt_email.Location = new Point(19, 141);
			txt_email.MaxLength = 256;
			txt_email.Name = "txt_email";
			txt_email.PlaceholderText = "xxxxxxx@xxxxx.com";
			txt_email.Size = new Size(253, 23);
			txt_email.TabIndex = 1;
			txt_email.Leave += txt_email_Leave;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(19, 104);
			label2.Name = "label2";
			label2.Size = new Size(51, 23);
			label2.TabIndex = 1;
			label2.Text = "Email";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe Print", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(164, 27);
			label1.Name = "label1";
			label1.Size = new Size(223, 58);
			label1.TabIndex = 0;
			label1.Text = "Cadastre-se";
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
			// errorProvider5
			// 
			errorProvider5.ContainerControl = this;
			// 
			// Cadastro_Cliente
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkCyan;
			ClientSize = new Size(878, 540);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Name = "Cadastro_Cliente";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cadastro_Cliente";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Panel panel1;
		private ComboBox cbx_cpf;
		private Label label8;
		private Button btn_cadastrar;
		private Button btn_cancelar;
		private Label label7;
		private TextBox txt_confsenha;
		private Label label6;
		private TextBox txt_senha;
		private Label label5;
		private Label label4;
		private TextBox txt_nome;
		private Label label3;
		private TextBox txt_email;
		private Label label2;
		private Label label1;
		private ErrorProvider errorProvider1;
		private ErrorProvider errorProvider2;
		private MaskedTextBox txt_CNPJ_CPF;
		private ErrorProvider errorProvider3;
		private ErrorProvider errorProvider4;
		private MaskedTextBox txt_telefone;
		private DateTimePicker dtNascimento;
		private ErrorProvider errorProvider5;
	}
}