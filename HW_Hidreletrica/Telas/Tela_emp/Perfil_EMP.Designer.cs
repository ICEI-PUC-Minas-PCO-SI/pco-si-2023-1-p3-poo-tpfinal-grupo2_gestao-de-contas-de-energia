namespace HW_Hidreletrica.Telas.Tela_emp
{
	partial class Perfil_EMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil_EMP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_perfil = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_perfil);
            this.panel1.Controls.Add(this.lb_email);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.lb_nome);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Location = new System.Drawing.Point(220, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 441);
            this.panel1.TabIndex = 1;
            // 
            // lb_perfil
            // 
            this.lb_perfil.AutoSize = true;
            this.lb_perfil.Font = new System.Drawing.Font("Segoe Print", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_perfil.Location = new System.Drawing.Point(145, 4);
            this.lb_perfil.Name = "lb_perfil";
            this.lb_perfil.Size = new System.Drawing.Size(112, 58);
            this.lb_perfil.TabIndex = 12;
            this.lb_perfil.Text = "Perfil";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(180, 297);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(36, 15);
            this.lb_email.TabIndex = 8;
            this.lb_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(120, 293);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(159, 23);
            this.txt_email.TabIndex = 9;
            // 
            // btn_editar
            // 
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(285, 75);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(25, 26);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(178, 242);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(40, 15);
            this.lb_nome.TabIndex = 3;
            this.lb_nome.Text = "Nome";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Firebrick;
            this.btn_sair.Location = new System.Drawing.Point(176, 359);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(47, 37);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(120, 239);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(159, 23);
            this.txt_nome.TabIndex = 4;
            // 
            // Perfil_EMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(832, 519);
            this.Controls.Add(this.panel1);
            this.Name = "Perfil_EMP";
            this.Text = "Perfil_EMP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lb_perfil;
        private Label lb_email;
        private TextBox txt_email;
        private Button btn_editar;
        private Label lb_nome;
        private Button btn_sair;
        private PictureBox pictureBox1;
        private TextBox txt_nome;
    }
}