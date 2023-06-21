namespace HW_Hidreletrica.Telas.Tela_cliente {
	partial class Tela_Principal_Cliente {
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
			label3 = new Label();
			label5 = new Label();
			menuStrip1 = new MenuStrip();
			perfilToolStripMenuItem = new ToolStripMenuItem();
			perfilToolStripMenuItem1 = new ToolStripMenuItem();
			logOutToolStripMenuItem = new ToolStripMenuItem();
			residênciasToolStripMenuItem = new ToolStripMenuItem();
			label4 = new Label();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			label1 = new Label();
			pictureBox4 = new PictureBox();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Azure;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(115, 103);
			label3.Name = "label3";
			label3.Size = new Size(301, 84);
			label3.TabIndex = 5;
			label3.Text = "◉ Utilize  iluminação  eficiente: Substitua \r\nlâmpadas incandescentes por lâmpadas\r\nLED, que consomem menos energia e têm\r\numa vida útil mais longa.";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Azure;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(115, 341);
			label5.Name = "label5";
			label5.Size = new Size(307, 84);
			label5.TabIndex = 9;
			label5.Text = "◉ Utilize eletrodomésticos eficientemente: \r\nAproveite a capacidade máxima para \r\nrealizar mais tarefas com menos ciclos, \r\notimizando o uso de energia.";
			label5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.LightSeaGreen;
			menuStrip1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			menuStrip1.Items.AddRange(new ToolStripItem[] { perfilToolStripMenuItem, residênciasToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(916, 33);
			menuStrip1.TabIndex = 10;
			menuStrip1.Text = "menuStrip1";
			// 
			// perfilToolStripMenuItem
			// 
			perfilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { perfilToolStripMenuItem1, logOutToolStripMenuItem });
			perfilToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			perfilToolStripMenuItem.ForeColor = Color.White;
			perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
			perfilToolStripMenuItem.Size = new Size(68, 29);
			perfilToolStripMenuItem.Text = "Perfil";
			// 
			// perfilToolStripMenuItem1
			// 
			perfilToolStripMenuItem1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			perfilToolStripMenuItem1.Name = "perfilToolStripMenuItem1";
			perfilToolStripMenuItem1.Size = new Size(180, 24);
			perfilToolStripMenuItem1.Text = "Perfil";
			perfilToolStripMenuItem1.Click += menu_perfil;
			// 
			// logOutToolStripMenuItem
			// 
			logOutToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			logOutToolStripMenuItem.Size = new Size(180, 24);
			logOutToolStripMenuItem.Text = "LogOut";
			logOutToolStripMenuItem.Click += menu_logout;
			// 
			// residênciasToolStripMenuItem
			// 
			residênciasToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			residênciasToolStripMenuItem.ForeColor = Color.White;
			residênciasToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
			residênciasToolStripMenuItem.Name = "residênciasToolStripMenuItem";
			residênciasToolStripMenuItem.Size = new Size(123, 29);
			residênciasToolStripMenuItem.Text = "Residências";
			residênciasToolStripMenuItem.Click += menu_residencia;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Azure;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(115, 236);
			label4.Name = "label4";
			label4.Size = new Size(301, 63);
			label4.TabIndex = 7;
			label4.Text = "◉ Desligue eletrônicos em stand-by: \r\nDesligue ou utilize uma régua de  energia \r\npara evitar o consumo desnecessário.";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.eletrodomesticos;
			pictureBox1.Location = new Point(9, 341);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(100, 84);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 11;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.eletronicos;
			pictureBox2.Location = new Point(12, 226);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(100, 84);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 12;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.led1;
			pictureBox3.Location = new Point(9, 103);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(100, 84);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 13;
			pictureBox3.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Azure;
			label1.Font = new Font("Segoe Print", 25.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(35, 38);
			label1.Name = "label1";
			label1.Size = new Size(339, 62);
			label1.TabIndex = 14;
			label1.Text = "Dicas de consumo";
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources.logoComFundo;
			pictureBox4.Location = new Point(765, 311);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(139, 143);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 15;
			pictureBox4.TabStop = false;
			// 
			// Tela_Principal_Cliente
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Azure;
			ClientSize = new Size(916, 466);
			Controls.Add(pictureBox4);
			Controls.Add(label1);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Tela_Principal_Cliente";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Home";
			FormClosing += Tela_Principal_Cliente_FormClosing;
			Load += Tela_Principal_Cliente_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label3;
		private Label label5;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem perfilToolStripMenuItem;
		private ToolStripMenuItem residênciasToolStripMenuItem;
		private ToolStripMenuItem perfilToolStripMenuItem1;
		private ToolStripMenuItem logOutToolStripMenuItem;
		private Label label4;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Label label1;
		private PictureBox pictureBox4;
	}
}