namespace HW_Hidreletrica.Telas.Tela_emp
{
    partial class UsuarioADM__EMP
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txt_nome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_email = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(323, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 457);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.adm;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(305, 457);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Print", 25.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(426, 23);
            label1.Name = "label1";
            label1.Size = new Size(410, 62);
            label1.TabIndex = 2;
            label1.Text = "Cadastro Colaborador";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(502, 109);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(217, 23);
            txt_nome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(431, 106);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(438, 154);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(502, 157);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(217, 23);
            txt_email.TabIndex = 6;
            // 
            // UsuarioADM__EMP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(894, 481);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "UsuarioADM__EMP";
            Text = "UsuarioADM__EMP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txt_nome;
        private Label label2;
        private Label label3;
        private TextBox txt_email;
    }
}