namespace HW_Hidreletrica.Telas.Tela_cliente
{
	partial class Contas
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
			dtContaAtual = new DataGridView();
			dtContaMesAnterior = new DataGridView();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dtContaAtual).BeginInit();
			((System.ComponentModel.ISupportInitialize)dtContaMesAnterior).BeginInit();
			SuspendLayout();
			// 
			// dtContaAtual
			// 
			dtContaAtual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtContaAtual.Location = new Point(222, 80);
			dtContaAtual.Name = "dtContaAtual";
			dtContaAtual.RowTemplate.Height = 25;
			dtContaAtual.Size = new Size(816, 146);
			dtContaAtual.TabIndex = 0;
			// 
			// dtContaMesAnterior
			// 
			dtContaMesAnterior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtContaMesAnterior.Location = new Point(222, 288);
			dtContaMesAnterior.Name = "dtContaMesAnterior";
			dtContaMesAnterior.RowTemplate.Height = 25;
			dtContaMesAnterior.Size = new Size(816, 149);
			dtContaMesAnterior.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(222, 38);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 2;
			label1.Text = "Mês Atual";
			// 
			// Contas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1420, 629);
			Controls.Add(label1);
			Controls.Add(dtContaMesAnterior);
			Controls.Add(dtContaAtual);
			Name = "Contas";
			Text = "Contas";
			((System.ComponentModel.ISupportInitialize)dtContaAtual).EndInit();
			((System.ComponentModel.ISupportInitialize)dtContaMesAnterior).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dtContaAtual;
		private DataGridView dtContaMesAnterior;
		private Label label1;
	}
}