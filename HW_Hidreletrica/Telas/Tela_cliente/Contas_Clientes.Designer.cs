namespace HW_Hidreletrica.Telas.Tela_cliente
{
	partial class Contas_Clientes
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
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			dtContaAtual = new DataGridView();
			dtContaMesAnterior = new DataGridView();
			label1 = new Label();
			lb_MesAnterior = new Label();
			dtConta2MesesAnterior = new DataGridView();
			lb_2MesesAnteriores = new Label();
			label4 = new Label();
			cb_FiltroMes = new ComboBox();
			label2 = new Label();
			btnVoltar = new Button();
			((System.ComponentModel.ISupportInitialize)dtContaAtual).BeginInit();
			((System.ComponentModel.ISupportInitialize)dtContaMesAnterior).BeginInit();
			((System.ComponentModel.ISupportInitialize)dtConta2MesesAnterior).BeginInit();
			SuspendLayout();
			// 
			// dtContaAtual
			// 
			dtContaAtual.AllowUserToAddRows = false;
			dtContaAtual.AllowUserToDeleteRows = false;
			dtContaAtual.AllowUserToOrderColumns = true;
			dtContaAtual.BackgroundColor = Color.SeaShell;
			dtContaAtual.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dtContaAtual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dtContaAtual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtContaAtual.GridColor = SystemColors.ActiveCaption;
			dtContaAtual.Location = new Point(222, 158);
			dtContaAtual.Name = "dtContaAtual";
			dtContaAtual.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dtContaAtual.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.SelectionBackColor = Color.White;
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			dtContaAtual.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dtContaAtual.RowTemplate.Height = 25;
			dtContaAtual.Size = new Size(939, 86);
			dtContaAtual.TabIndex = 0;
			// 
			// dtContaMesAnterior
			// 
			dtContaMesAnterior.AllowUserToAddRows = false;
			dtContaMesAnterior.AllowUserToDeleteRows = false;
			dtContaMesAnterior.AllowUserToResizeRows = false;
			dtContaMesAnterior.BackgroundColor = Color.SeaShell;
			dtContaMesAnterior.BorderStyle = BorderStyle.None;
			dtContaMesAnterior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtContaMesAnterior.Location = new Point(222, 328);
			dtContaMesAnterior.Name = "dtContaMesAnterior";
			dtContaMesAnterior.ReadOnly = true;
			dataGridViewCellStyle4.SelectionBackColor = Color.White;
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			dtContaMesAnterior.RowsDefaultCellStyle = dataGridViewCellStyle4;
			dtContaMesAnterior.RowTemplate.Height = 25;
			dtContaMesAnterior.Size = new Size(939, 92);
			dtContaMesAnterior.TabIndex = 1;
			dtContaMesAnterior.Visible = false;
			// 
			// label1
			// 
			label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.SaddleBrown;
			label1.Location = new Point(222, 128);
			label1.Name = "label1";
			label1.Size = new Size(112, 27);
			label1.TabIndex = 2;
			label1.Text = "Mês Atual";
			// 
			// lb_MesAnterior
			// 
			lb_MesAnterior.AutoSize = true;
			lb_MesAnterior.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lb_MesAnterior.ForeColor = Color.SaddleBrown;
			lb_MesAnterior.Location = new Point(222, 281);
			lb_MesAnterior.Name = "lb_MesAnterior";
			lb_MesAnterior.Size = new Size(116, 22);
			lb_MesAnterior.TabIndex = 3;
			lb_MesAnterior.Text = "Mês Anterior";
			lb_MesAnterior.Visible = false;
			// 
			// dtConta2MesesAnterior
			// 
			dtConta2MesesAnterior.AllowUserToAddRows = false;
			dtConta2MesesAnterior.AllowUserToDeleteRows = false;
			dtConta2MesesAnterior.AllowUserToResizeRows = false;
			dtConta2MesesAnterior.BackgroundColor = Color.SeaShell;
			dtConta2MesesAnterior.BorderStyle = BorderStyle.None;
			dtConta2MesesAnterior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtConta2MesesAnterior.Location = new Point(222, 482);
			dtConta2MesesAnterior.Name = "dtConta2MesesAnterior";
			dtConta2MesesAnterior.ReadOnly = true;
			dataGridViewCellStyle5.SelectionBackColor = Color.White;
			dataGridViewCellStyle5.SelectionForeColor = Color.Black;
			dtConta2MesesAnterior.RowsDefaultCellStyle = dataGridViewCellStyle5;
			dtConta2MesesAnterior.RowTemplate.Height = 25;
			dtConta2MesesAnterior.Size = new Size(939, 79);
			dtConta2MesesAnterior.TabIndex = 4;
			dtConta2MesesAnterior.Visible = false;
			// 
			// lb_2MesesAnteriores
			// 
			lb_2MesesAnteriores.AutoSize = true;
			lb_2MesesAnteriores.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lb_2MesesAnteriores.ForeColor = Color.SaddleBrown;
			lb_2MesesAnteriores.Location = new Point(222, 449);
			lb_2MesesAnteriores.Name = "lb_2MesesAnteriores";
			lb_2MesesAnteriores.Size = new Size(165, 22);
			lb_2MesesAnteriores.TabIndex = 5;
			lb_2MesesAnteriores.Text = "2 Meses Anteriores";
			lb_2MesesAnteriores.Visible = false;
			// 
			// label4
			// 
			label4.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Brown;
			label4.Location = new Point(90, 50);
			label4.Name = "label4";
			label4.Size = new Size(118, 35);
			label4.TabIndex = 6;
			label4.Text = "Contas";
			// 
			// cb_FiltroMes
			// 
			cb_FiltroMes.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_FiltroMes.FormattingEnabled = true;
			cb_FiltroMes.Items.AddRange(new object[] { "Mês Atual", "Mês Anterior", "Últimos Dois Meses" });
			cb_FiltroMes.Location = new Point(1209, 87);
			cb_FiltroMes.Name = "cb_FiltroMes";
			cb_FiltroMes.Size = new Size(145, 23);
			cb_FiltroMes.TabIndex = 7;
			cb_FiltroMes.SelectedIndexChanged += cbFiltroMes_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Brown;
			label2.Location = new Point(983, 89);
			label2.Name = "label2";
			label2.Size = new Size(220, 21);
			label2.TabIndex = 8;
			label2.Text = "Selecione a conta que deseja ver:";
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.DeepSkyBlue;
			btnVoltar.FlatAppearance.BorderSize = 0;
			btnVoltar.FlatStyle = FlatStyle.Flat;
			btnVoltar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnVoltar.Location = new Point(12, 577);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(81, 40);
			btnVoltar.TabIndex = 9;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			btnVoltar.Click += btnVoltar_Click;
			// 
			// Contas_Clientes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SeaShell;
			ClientSize = new Size(1471, 629);
			Controls.Add(btnVoltar);
			Controls.Add(label2);
			Controls.Add(cb_FiltroMes);
			Controls.Add(label4);
			Controls.Add(lb_2MesesAnteriores);
			Controls.Add(dtConta2MesesAnterior);
			Controls.Add(lb_MesAnterior);
			Controls.Add(label1);
			Controls.Add(dtContaMesAnterior);
			Controls.Add(dtContaAtual);
			Name = "Contas_Clientes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Contas";
			FormClosing += Contas_Clientes_FormClosing;
			((System.ComponentModel.ISupportInitialize)dtContaAtual).EndInit();
			((System.ComponentModel.ISupportInitialize)dtContaMesAnterior).EndInit();
			((System.ComponentModel.ISupportInitialize)dtConta2MesesAnterior).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dtContaAtual;
		private DataGridView dtContaMesAnterior;
		private Label label1;
		private Label lb_MesAnterior;
		private DataGridView dtConta2MesesAnterior;
		private Label lb_2MesesAnteriores;
		private Label label4;
		private ComboBox cb_FiltroMes;
		private Label label2;
		private Button btnVoltar;
	}
}