namespace HW_Hidreletrica.Telas.Tela_cliente {
	partial class Cadastro_Residencias_Cliente {
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
			txtNumero = new TextBox();
			labelNumero = new Label();
			labelUF = new Label();
			txtCidade = new TextBox();
			labelCidade = new Label();
			txbRua = new TextBox();
			labelRua = new Label();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			txtCep = new TextBox();
			labelCep = new Label();
			cbxUF = new ComboBox();
			label6 = new Label();
			btnCancelar = new Button();
			btnCadastro = new Button();
			labelApelido = new Label();
			txbApelido = new TextBox();
			labelBairro = new Label();
			txbBairro = new TextBox();
			aviso = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// txtNumero
			// 
			txtNumero.Location = new Point(748, 130);
			txtNumero.Name = "txtNumero";
			txtNumero.Size = new Size(58, 23);
			txtNumero.TabIndex = 4;
			txtNumero.KeyPress += txtNumero_KeyPress;
			// 
			// labelNumero
			// 
			labelNumero.AutoSize = true;
			labelNumero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelNumero.ForeColor = Color.White;
			labelNumero.Location = new Point(669, 133);
			labelNumero.Name = "labelNumero";
			labelNumero.Size = new Size(66, 20);
			labelNumero.TabIndex = 18;
			labelNumero.Text = "Numero:";
			// 
			// labelUF
			// 
			labelUF.AutoSize = true;
			labelUF.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelUF.ForeColor = Color.White;
			labelUF.Location = new Point(706, 174);
			labelUF.Name = "labelUF";
			labelUF.Size = new Size(29, 20);
			labelUF.TabIndex = 16;
			labelUF.Text = "UF:";
			// 
			// txtCidade
			// 
			txtCidade.Location = new Point(467, 174);
			txtCidade.Name = "txtCidade";
			txtCidade.Size = new Size(154, 23);
			txtCidade.TabIndex = 5;
			// 
			// labelCidade
			// 
			labelCidade.AutoSize = true;
			labelCidade.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelCidade.ForeColor = Color.White;
			labelCidade.Location = new Point(388, 174);
			labelCidade.Name = "labelCidade";
			labelCidade.Size = new Size(59, 20);
			labelCidade.TabIndex = 14;
			labelCidade.Text = "Cidade:";
			// 
			// txbRua
			// 
			txbRua.Location = new Point(465, 92);
			txbRua.Name = "txbRua";
			txbRua.Size = new Size(231, 23);
			txbRua.TabIndex = 2;
			// 
			// labelRua
			// 
			labelRua.AutoSize = true;
			labelRua.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelRua.ForeColor = Color.White;
			labelRua.Location = new Point(391, 91);
			labelRua.Name = "labelRua";
			labelRua.Size = new Size(37, 20);
			labelRua.TabIndex = 12;
			labelRua.Text = "Rua:";
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.DarkOrange;
			pictureBox2.Image = Properties.Resources.casa_cadastro;
			pictureBox2.Location = new Point(32, 82);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(333, 262);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 11;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.DarkOrange;
			pictureBox1.Location = new Point(0, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(352, 439);
			pictureBox1.TabIndex = 10;
			pictureBox1.TabStop = false;
			// 
			// txtCep
			// 
			txtCep.Location = new Point(560, 223);
			txtCep.MaxLength = 8;
			txtCep.Name = "txtCep";
			txtCep.Size = new Size(119, 23);
			txtCep.TabIndex = 7;
			txtCep.KeyPress += txtCep_KeyPress;
			// 
			// labelCep
			// 
			labelCep.AutoSize = true;
			labelCep.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelCep.ForeColor = Color.White;
			labelCep.Location = new Point(496, 223);
			labelCep.Name = "labelCep";
			labelCep.Size = new Size(37, 20);
			labelCep.TabIndex = 20;
			labelCep.Text = "CEP:";
			// 
			// cbxUF
			// 
			cbxUF.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxUF.FormattingEnabled = true;
			cbxUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
			cbxUF.Location = new Point(754, 171);
			cbxUF.Name = "cbxUF";
			cbxUF.Size = new Size(52, 23);
			cbxUF.TabIndex = 6;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(490, 226);
			label6.Name = "label6";
			label6.Size = new Size(0, 20);
			label6.TabIndex = 23;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.DarkSlateGray;
			btnCancelar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnCancelar.ForeColor = Color.White;
			btnCancelar.Location = new Point(12, 12);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(84, 34);
			btnCancelar.TabIndex = 26;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnCadastro
			// 
			btnCadastro.BackColor = Color.DarkOrange;
			btnCadastro.Font = new Font("Segoe Print", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btnCadastro.Location = new Point(552, 363);
			btnCadastro.Name = "btnCadastro";
			btnCadastro.Size = new Size(124, 63);
			btnCadastro.TabIndex = 8;
			btnCadastro.Text = "Cadastrar";
			btnCadastro.UseVisualStyleBackColor = false;
			btnCadastro.Click += btnCadastro_Click;
			// 
			// labelApelido
			// 
			labelApelido.AutoSize = true;
			labelApelido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelApelido.ForeColor = Color.White;
			labelApelido.Location = new Point(388, 49);
			labelApelido.Name = "labelApelido";
			labelApelido.Size = new Size(69, 20);
			labelApelido.TabIndex = 28;
			labelApelido.Text = "Apelido: ";
			// 
			// txbApelido
			// 
			txbApelido.Location = new Point(465, 50);
			txbApelido.Name = "txbApelido";
			txbApelido.Size = new Size(282, 23);
			txbApelido.TabIndex = 1;
			// 
			// labelBairro
			// 
			labelBairro.AutoSize = true;
			labelBairro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelBairro.ForeColor = Color.White;
			labelBairro.Location = new Point(391, 134);
			labelBairro.Name = "labelBairro";
			labelBairro.Size = new Size(56, 20);
			labelBairro.TabIndex = 30;
			labelBairro.Text = "Bairro: ";
			// 
			// txbBairro
			// 
			txbBairro.Location = new Point(467, 134);
			txbBairro.Name = "txbBairro";
			txbBairro.Size = new Size(188, 23);
			txbBairro.TabIndex = 3;
			// 
			// aviso
			// 
			aviso.AutoSize = true;
			aviso.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			aviso.ForeColor = Color.FromArgb(192, 30, 10);
			aviso.Location = new Point(408, 281);
			aviso.Name = "aviso";
			aviso.Size = new Size(270, 23);
			aviso.TabIndex = 32;
			aviso.Text = "Preencha todos os campos.";
			aviso.Visible = false;
			// 
			// Cadastro_Residencias_Cliente
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateGray;
			ClientSize = new Size(812, 455);
			Controls.Add(aviso);
			Controls.Add(txbBairro);
			Controls.Add(labelBairro);
			Controls.Add(txbApelido);
			Controls.Add(labelApelido);
			Controls.Add(btnCadastro);
			Controls.Add(btnCancelar);
			Controls.Add(label6);
			Controls.Add(cbxUF);
			Controls.Add(txtCep);
			Controls.Add(labelCep);
			Controls.Add(txtNumero);
			Controls.Add(labelNumero);
			Controls.Add(labelUF);
			Controls.Add(txtCidade);
			Controls.Add(labelCidade);
			Controls.Add(txbRua);
			Controls.Add(labelRua);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Name = "Cadastro_Residencias_Cliente";
			Text = "Cadastro_Residencias_Cliente";
			TopMost = true;
			Load += Cadastro_Residencias_Cliente_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtNumero;
		private Label labelNumero;
		private Label labelUF;
		private TextBox txtCidade;
		private Label labelCidade;
		private TextBox txbRua;
		private Label labelRua;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private TextBox txtCep;
		private Label labelCep;
		private ComboBox cbxUF;
		private Label label6;
		private Button btnCancelar;
		private Button btnCadastro;
		private Label labelApelido;
		private TextBox txbApelido;
		private Label labelBairro;
		private TextBox txbBairro;
		private Label aviso;
	}
}