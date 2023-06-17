namespace HW_Hidreletrica.Telas.Tela_emp
{
	partial class Tela_Principal_EMP
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
			dt_Clientes = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			cbx_Filtro = new ComboBox();
			txt_Input = new MaskedTextBox();
			label3 = new Label();
			label4 = new Label();
			btn_AplicaFiltro = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)dt_Clientes).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// dt_Clientes
			// 
			dt_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dt_Clientes.Location = new Point(54, 144);
			dt_Clientes.Name = "dt_Clientes";
			dt_Clientes.RowTemplate.Height = 25;
			dt_Clientes.Size = new Size(1375, 435);
			dt_Clientes.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.SlateBlue;
			label1.Location = new Point(74, 59);
			label1.Name = "label1";
			label1.Size = new Size(95, 28);
			label1.TabIndex = 1;
			label1.Text = "Clientes";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(1219, 616);
			label2.Name = "label2";
			label2.Size = new Size(55, 19);
			label2.TabIndex = 2;
			label2.Text = "Total: ";
			// 
			// cbx_Filtro
			// 
			cbx_Filtro.DropDownStyle = ComboBoxStyle.DropDownList;
			cbx_Filtro.FormattingEnabled = true;
			cbx_Filtro.Items.AddRange(new object[] { "CPF", "CNPJ", "Identificador", "Consumo", "Contas em Atraso" });
			cbx_Filtro.Location = new Point(1019, 64);
			cbx_Filtro.Name = "cbx_Filtro";
			cbx_Filtro.Size = new Size(121, 23);
			cbx_Filtro.TabIndex = 3;
			cbx_Filtro.SelectedIndexChanged += cbx_Filtro_SelectedIndexChanged;
			// 
			// txt_Input
			// 
			txt_Input.Location = new Point(1164, 64);
			txt_Input.Name = "txt_Input";
			txt_Input.Size = new Size(143, 23);
			txt_Input.TabIndex = 4;
			txt_Input.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(933, 67);
			label3.Name = "label3";
			label3.Size = new Size(83, 16);
			label3.TabIndex = 5;
			label3.Text = "Filtrar Cliente:";
			// 
			// label4
			// 
			label4.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(1280, 616);
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
			btn_AplicaFiltro.Location = new Point(1334, 59);
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
			// Tela_Principal_EMP
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SeaShell;
			ClientSize = new Size(1494, 669);
			Controls.Add(btn_AplicaFiltro);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txt_Input);
			Controls.Add(cbx_Filtro);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dt_Clientes);
			Name = "Tela_Principal_EMP";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Tela Principal Administrador";
			FormClosing += Tela_Principal_EMP_FormClosing;
			((System.ComponentModel.ISupportInitialize)dt_Clientes).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
	}
}