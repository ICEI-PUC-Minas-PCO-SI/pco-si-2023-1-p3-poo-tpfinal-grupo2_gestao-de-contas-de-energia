namespace HW_Hidreletrica.Telas.Tela_cliente
{
	partial class Residencias_Cliente
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			dataGridViewResidencias = new DataGridView();
			textoResidencias = new Label();
			btnDeletar = new Button();
			btnAdicionar = new Button();
			btnVoltar = new Button();
			btnContas = new Button();
			btnEditar = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewResidencias).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewResidencias
			// 
			dataGridViewResidencias.AllowUserToAddRows = false;
			dataGridViewResidencias.AllowUserToDeleteRows = false;
			dataGridViewResidencias.BackgroundColor = Color.AntiqueWhite;
			dataGridViewResidencias.BorderStyle = BorderStyle.None;
			dataGridViewResidencias.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
			dataGridViewResidencias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.AntiqueWhite;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.Padding = new Padding(3);
			dataGridViewCellStyle1.SelectionBackColor = Color.AntiqueWhite;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridViewResidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewResidencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.AntiqueWhite;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.SandyBrown;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridViewResidencias.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewResidencias.EnableHeadersVisualStyles = false;
			dataGridViewResidencias.GridColor = Color.Tan;
			dataGridViewResidencias.ImeMode = ImeMode.KatakanaHalf;
			dataGridViewResidencias.Location = new Point(35, 100);
			dataGridViewResidencias.Name = "dataGridViewResidencias";
			dataGridViewResidencias.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.PapayaWhip;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = Color.SandyBrown;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridViewResidencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewResidencias.RowHeadersWidth = 50;
			dataGridViewResidencias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.BackColor = Color.PapayaWhip;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
			dataGridViewCellStyle4.Padding = new Padding(2);
			dataGridViewResidencias.RowsDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewResidencias.RowTemplate.Height = 25;
			dataGridViewResidencias.ScrollBars = ScrollBars.Vertical;
			dataGridViewResidencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewResidencias.Size = new Size(695, 293);
			dataGridViewResidencias.TabIndex = 0;
			dataGridViewResidencias.CellContentClick += dataGridView1_CellContentClick;
			// 
			// textoResidencias
			// 
			textoResidencias.AutoSize = true;
			textoResidencias.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			textoResidencias.ForeColor = Color.DarkRed;
			textoResidencias.Location = new Point(87, 3);
			textoResidencias.Name = "textoResidencias";
			textoResidencias.Size = new Size(469, 54);
			textoResidencias.TabIndex = 1;
			textoResidencias.Text = "Residencias Cadastradas";
			textoResidencias.Click += textoResidencias_Click;
			// 
			// btnDeletar
			// 
			btnDeletar.BackColor = Color.Red;
			btnDeletar.FlatAppearance.BorderSize = 0;
			btnDeletar.FlatStyle = FlatStyle.Flat;
			btnDeletar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnDeletar.ForeColor = SystemColors.ActiveCaptionText;
			btnDeletar.Location = new Point(399, 415);
			btnDeletar.Name = "btnDeletar";
			btnDeletar.Size = new Size(81, 29);
			btnDeletar.TabIndex = 2;
			btnDeletar.Text = "Excluir";
			btnDeletar.UseVisualStyleBackColor = false;
			btnDeletar.Click += btnDeletar_Click;
			// 
			// btnAdicionar
			// 
			btnAdicionar.BackColor = Color.LawnGreen;
			btnAdicionar.FlatAppearance.BorderSize = 0;
			btnAdicionar.FlatStyle = FlatStyle.Flat;
			btnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdicionar.Location = new Point(698, 415);
			btnAdicionar.Name = "btnAdicionar";
			btnAdicionar.Size = new Size(90, 29);
			btnAdicionar.TabIndex = 3;
			btnAdicionar.Text = "Adicionar";
			btnAdicionar.UseVisualStyleBackColor = false;
			btnAdicionar.Click += btnAdicionar_Click;
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.DeepSkyBlue;
			btnVoltar.FlatAppearance.BorderSize = 0;
			btnVoltar.FlatStyle = FlatStyle.Flat;
			btnVoltar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnVoltar.ForeColor = SystemColors.ActiveCaptionText;
			btnVoltar.Location = new Point(2, 3);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(63, 23);
			btnVoltar.TabIndex = 4;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			btnVoltar.Click += btnVoltar_Click;
			// 
			// btnContas
			// 
			btnContas.BackColor = Color.CornflowerBlue;
			btnContas.FlatAppearance.BorderSize = 0;
			btnContas.FlatStyle = FlatStyle.Flat;
			btnContas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnContas.Location = new Point(593, 415);
			btnContas.Name = "btnContas";
			btnContas.Size = new Size(90, 29);
			btnContas.TabIndex = 5;
			btnContas.Text = "Ver Contas";
			btnContas.UseVisualStyleBackColor = false;
			btnContas.Click += btnContas_Click;
			// 
			// btnEditar
			// 
			btnEditar.BackColor = Color.DarkGray;
			btnEditar.FlatAppearance.BorderSize = 0;
			btnEditar.FlatStyle = FlatStyle.Flat;
			btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnEditar.ForeColor = SystemColors.ActiveCaptionText;
			btnEditar.Location = new Point(496, 415);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(81, 29);
			btnEditar.TabIndex = 6;
			btnEditar.Text = "Editar";
			btnEditar.UseVisualStyleBackColor = false;
			btnEditar.Click += btnEditar_Click;
			// 
			// Residencias_Cliente
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AntiqueWhite;
			ClientSize = new Size(800, 450);
			Controls.Add(btnEditar);
			Controls.Add(btnContas);
			Controls.Add(btnVoltar);
			Controls.Add(btnAdicionar);
			Controls.Add(btnDeletar);
			Controls.Add(textoResidencias);
			Controls.Add(dataGridViewResidencias);
			Name = "Residencias_Cliente";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Residencias";
			Load += Residencias_Cliente_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewResidencias).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewResidencias;
		private Label textoResidencias;
		private Button btnDeletar;
		private Button btnAdicionar;
		private Button btnVoltar;
		private Button btnContas;
		private Button btnEditar;
	}
}