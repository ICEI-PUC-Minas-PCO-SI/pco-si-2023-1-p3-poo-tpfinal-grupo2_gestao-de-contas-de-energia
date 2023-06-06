namespace HW_Hidreletrica.Telas.Tela_cliente
{
    partial class Cadastro_Residencias_Cliente
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
            txt_num = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_cidade = new TextBox();
            label2 = new Label();
            txt_logadouro = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txt_cep = new TextBox();
            label5 = new Label();
            cbx_uf = new ComboBox();
            cbx_tResidencia = new ComboBox();
            label6 = new Label();
            btn_retornar = new Button();
            btn_cadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_num
            // 
            txt_num.Location = new Point(724, 103);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(52, 23);
            txt_num.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(652, 106);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 18;
            label4.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(689, 59);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 16;
            label3.Text = "UF:";
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(487, 101);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(139, 23);
            txt_cidade.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(422, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 14;
            label2.Text = "Cidade:";
            // 
            // txt_logadouro
            // 
            txt_logadouro.Location = new Point(487, 56);
            txt_logadouro.Name = "txt_logadouro";
            txt_logadouro.Size = new Size(139, 23);
            txt_logadouro.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(388, 57);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 12;
            label1.Text = "Longadouro:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkOrange;
            pictureBox2.Image = Properties.Resources.casa_cadastro;
            pictureBox2.Location = new Point(42, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(333, 262);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOrange;
            pictureBox1.Location = new Point(0, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 436);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txt_cep
            // 
            txt_cep.Location = new Point(487, 148);
            txt_cep.Name = "txt_cep";
            txt_cep.Size = new Size(139, 23);
            txt_cep.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(444, 148);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 20;
            label5.Text = "CEP:";
            // 
            // cbx_uf
            // 
            cbx_uf.FormattingEnabled = true;
            cbx_uf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbx_uf.Location = new Point(724, 60);
            cbx_uf.Name = "cbx_uf";
            cbx_uf.Size = new Size(52, 23);
            cbx_uf.TabIndex = 22;
            // 
            // cbx_tResidencia
            // 
            cbx_tResidencia.FormattingEnabled = true;
            cbx_tResidencia.Items.AddRange(new object[] { "Comercial", "Residencial" });
            cbx_tResidencia.Location = new Point(616, 207);
            cbx_tResidencia.Name = "cbx_tResidencia";
            cbx_tResidencia.Size = new Size(102, 23);
            cbx_tResidencia.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(476, 207);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 23;
            label6.Text = "Tipo de residencia:";
            // 
            // btn_retornar
            // 
            btn_retornar.BackColor = Color.DarkSlateGray;
            btn_retornar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_retornar.ForeColor = Color.White;
            btn_retornar.Location = new Point(12, 12);
            btn_retornar.Name = "btn_retornar";
            btn_retornar.Size = new Size(84, 34);
            btn_retornar.TabIndex = 26;
            btn_retornar.Text = "Retornar";
            btn_retornar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.DarkOrange;
            btn_cadastrar.Font = new Font("Segoe Print", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.Location = new Point(539, 298);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(124, 63);
            btn_cadastrar.TabIndex = 27;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // Cadastro_Residencias_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cadastrar);
            Controls.Add(btn_retornar);
            Controls.Add(cbx_tResidencia);
            Controls.Add(label6);
            Controls.Add(cbx_uf);
            Controls.Add(txt_cep);
            Controls.Add(label5);
            Controls.Add(txt_num);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_cidade);
            Controls.Add(label2);
            Controls.Add(txt_logadouro);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Cadastro_Residencias_Cliente";
            Text = "Cadastro_Residencias_Cliente";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_num;
        private Label label4;
        private Label label3;
        private TextBox txt_cidade;
        private Label label2;
        private TextBox txt_logadouro;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txt_cep;
        private Label label5;
        private ComboBox cbx_uf;
        private ComboBox cbx_tResidencia;
        private Label label6;
        private Button btn_retornar;
        private Button btn_cadastrar;
    }
}