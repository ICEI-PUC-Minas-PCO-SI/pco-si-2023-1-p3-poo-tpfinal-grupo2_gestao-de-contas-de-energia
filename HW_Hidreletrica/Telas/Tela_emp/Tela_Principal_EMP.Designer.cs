namespace HW_Hidreletrica.Telas.Tela_emp {
	partial class Tela_Principal_EMP {
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
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			dt_Clientes = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			cbx_Filtro = new ComboBox();
			txt_Input = new MaskedTextBox();
			label3 = new Label();
			label4 = new Label();
			btn_AplicaFiltro = new Button();
			errorProvider1 = new ErrorProvider(components);
			btnVerCliente = new Button();
			menuStrip1 = new MenuStrip();
			toolStripMenuItem1 = new ToolStripMenuItem();
			perfilToolStripMenuItem = new ToolStripMenuItem();
			logOutToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)dt_Clientes).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dt_Clientes
			// 
			dt_Clientes.AllowUserToAddRows = false;
			dt_Clientes.AllowUserToDeleteRows = false;
			dt_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dt_Clientes.Location = new Point(31, 117);
			dt_Clientes.Name = "dt_Clientes";
			dt_Clientes.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dt_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
			dt_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
			dt_Clientes.RowTemplate.Height = 25;
			dt_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dt_Clientes.Size = new Size(1287, 472);
			dt_Clientes.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.SlateBlue;
			label1.Location = new Point(96, 41);
			label1.Name = "label1";
			label1.Size = new Size(170, 50);
			label1.TabIndex = 1;
			label1.Text = "Clientes";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(1092, 632);
			label2.Name = "label2";
			label2.Size = new Size(55, 19);
			label2.TabIndex = 2;
			label2.Text = "Total: ";
			// 
			// cbx_Filtro
			// 
			cbx_Filtro.DropDownStyle = ComboBoxStyle.DropDownList;
			cbx_Filtro.FormattingEnabled = true;
			cbx_Filtro.Items.AddRange(new object[] { "CPF", "CNPJ", "Identificador", "Consumo", "Contas em Atraso", "Todos os Clientes" });
			cbx_Filtro.Location = new Point(916, 75);
			cbx_Filtro.Name = "cbx_Filtro";
			cbx_Filtro.Size = new Size(121, 23);
			cbx_Filtro.TabIndex = 3;
			cbx_Filtro.SelectedIndexChanged += cbx_Filtro_SelectedIndexChanged;
			// 
			// txt_Input
			// 
			txt_Input.Location = new Point(1061, 75);
			txt_Input.Name = "txt_Input";
			txt_Input.Size = new Size(143, 23);
			txt_Input.TabIndex = 4;
			txt_Input.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(830, 78);
			label3.Name = "label3";
			label3.Size = new Size(83, 16);
			label3.TabIndex = 5;
			label3.Text = "Filtrar Cliente:";
			// 
			// label4
			// 
			label4.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(1138, 632);
			label4.Name = "label4";
			label4.Size = new Size(47, 19);
			label4.TabIndex = 6;
			label4.Text = "label4";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btn_AplicaFiltro
			// 
			btn_AplicaFiltro.BackColor = Color.MediumSlateBlue;
			btn_AplicaFiltro.FlatStyle = FlatStyle.Flat;
			btn_AplicaFiltro.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn_AplicaFiltro.ForeColor = SystemColors.ControlLightLight;
			btn_AplicaFiltro.Location = new Point(1223, 70);
			btn_AplicaFiltro.Name = "btn_AplicaFiltro";
			btn_AplicaFiltro.Size = new Size(95, 32);
			btn_AplicaFiltro.TabIndex = 7;
			btn_AplicaFiltro.Text = "Aplicar Filtro";
			btn_AplicaFiltro.UseVisualStyleBackColor = false;
			btn_AplicaFiltro.Click += btn_AplicaFiltro_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// btnVerCliente
			// 
			btnVerCliente.BackColor = Color.SteelBlue;
			btnVerCliente.FlatStyle = FlatStyle.Flat;
			btnVerCliente.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnVerCliente.ForeColor = SystemColors.ControlLightLight;
			btnVerCliente.Location = new Point(1223, 625);
			btnVerCliente.Name = "btnVerCliente";
			btnVerCliente.Size = new Size(95, 32);
			btnVerCliente.TabIndex = 8;
			btnVerCliente.Text = "Ver Cliente";
			btnVerCliente.UseVisualStyleBackColor = false;
			btnVerCliente.Click += btnVerCliente_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1494, 29);
			menuStrip1.TabIndex = 9;
			menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.BackColor = Color.DarkCyan;
			toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { perfilToolStripMenuItem, logOutToolStripMenuItem });
			toolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(57, 25);
			toolStripMenuItem1.Text = "Perfil";
			// 
			// perfilToolStripMenuItem
			// 
			perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
			perfilToolStripMenuItem.Size = new Size(132, 26);
			perfilToolStripMenuItem.Text = "Perfil";
			perfilToolStripMenuItem.Click += perfilToolStripMenuItem_Click;
			// 
			// logOutToolStripMenuItem
			// 
			logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			logOutToolStripMenuItem.Size = new Size(132, 26);
			logOutToolStripMenuItem.Text = "LogOut";
			logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
			// 
			// Tela_Principal_EMP
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SeaShell;
			ClientSize = new Size(1494, 669);
			Controls.Add(btnVerCliente);
			Controls.Add(btn_AplicaFiltro);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txt_Input);
			Controls.Add(cbx_Filtro);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dt_Clientes);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Tela_Principal_EMP";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Tela Principal Administrador";
			FormClosing += Tela_Principal_EMP_FormClosing;
			((System.ComponentModel.ISupportInitialize)dt_Clientes).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dt_Clientes;
		private Label label1;
		private Label label2;
		private ComboBox cbx_Filtro;
		private MaskedTextBox txt_Input;
		private Label label3;
		private Label label4;
		private Button btn_AplicaFiltro;
		private ErrorProvider errorProvider1;
		private Button btnVerCliente;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem perfilToolStripMenuItem;
		private ToolStripMenuItem logOutToolStripMenuItem;
	}
}