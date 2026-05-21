namespace Contfy
{
    partial class CadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.cbTipoConta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.btnCCriarConta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crie sua conta!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbMostrarSenha);
            this.groupBox1.Controls.Add(this.cbTipoConta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbTelefone);
            this.groupBox1.Controls.Add(this.tbSenha);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(251, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(13, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "(DDD) 00000-0000";
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarSenha.ForeColor = System.Drawing.Color.White;
            this.cbMostrarSenha.Location = new System.Drawing.Point(16, 197);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(102, 19);
            this.cbMostrarSenha.TabIndex = 17;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // cbTipoConta
            // 
            this.cbTipoConta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbTipoConta.FormattingEnabled = true;
            this.cbTipoConta.Items.AddRange(new object[] {
            "Usuario",
            "Admin"});
            this.cbTipoConta.Location = new System.Drawing.Point(16, 88);
            this.cbTipoConta.Name = "cbTipoConta";
            this.cbTipoConta.Size = new System.Drawing.Size(200, 23);
            this.cbTipoConta.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefone*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Senha*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo da Conta*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome*";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(16, 237);
            this.mtbTelefone.Mask = "(00) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(91, 23);
            this.mtbTelefone.TabIndex = 8;
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(16, 174);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(200, 23);
            this.tbSenha.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(16, 131);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 23);
            this.tbEmail.TabIndex = 1;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(16, 40);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(200, 23);
            this.tbNome.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbEstado);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mtbCEP);
            this.groupBox2.Controls.Add(this.tbRua);
            this.groupBox2.Controls.Add(this.tbCidade);
            this.groupBox2.Controls.Add(this.tbBairro);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(309, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(251, 283);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(26, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "0000-000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(21, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Somente a sigla (SP)";
            // 
            // tbEstado
            // 
            this.tbEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstado.Location = new System.Drawing.Point(24, 230);
            this.tbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(200, 23);
            this.tbEstado.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(28, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Estado*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cidade*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bairro*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rua*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "CEP (Opcional)";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCEP.Location = new System.Drawing.Point(24, 40);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(100, 23);
            this.mtbCEP.TabIndex = 6;
            this.mtbCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCEP_MaskInputRejected);
            this.mtbCEP.Leave += new System.EventHandler(this.mtbCEP_Leave);
            // 
            // tbRua
            // 
            this.tbRua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRua.Location = new System.Drawing.Point(24, 100);
            this.tbRua.Margin = new System.Windows.Forms.Padding(2);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(200, 23);
            this.tbRua.TabIndex = 4;
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCidade.Location = new System.Drawing.Point(24, 187);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(2);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(200, 23);
            this.tbCidade.TabIndex = 2;
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(24, 144);
            this.tbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(200, 23);
            this.tbBairro.TabIndex = 1;
            // 
            // btnCCriarConta
            // 
            this.btnCCriarConta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCriarConta.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCriarConta.ForeColor = System.Drawing.Color.White;
            this.btnCCriarConta.Location = new System.Drawing.Point(207, 354);
            this.btnCCriarConta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCCriarConta.Name = "btnCCriarConta";
            this.btnCCriarConta.Size = new System.Drawing.Size(180, 40);
            this.btnCCriarConta.TabIndex = 7;
            this.btnCCriarConta.Text = "Criar Conta";
            this.btnCCriarConta.UseVisualStyleBackColor = false;
            this.btnCCriarConta.Click += new System.EventHandler(this.btnCCriarConta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(129, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 24);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(581, 406);
            this.Controls.Add(this.btnCCriarConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contfy - Cadastre-se";
            this.Load += new System.EventHandler(this.CadastroForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Button btnCCriarConta;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.ComboBox cbTipoConta;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscar;
    }
}