namespace Contfy
{
    partial class UsuarioForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoginUsuario = new System.Windows.Forms.TextBox();
            this.tbLoginSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkCriarConta = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-Vindo!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(86, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Não tem login?";
            // 
            // tbLoginUsuario
            // 
            this.tbLoginUsuario.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginUsuario.Location = new System.Drawing.Point(43, 121);
            this.tbLoginUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginUsuario.Name = "tbLoginUsuario";
            this.tbLoginUsuario.Size = new System.Drawing.Size(180, 24);
            this.tbLoginUsuario.TabIndex = 4;
            // 
            // tbLoginSenha
            // 
            this.tbLoginSenha.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginSenha.Location = new System.Drawing.Point(43, 169);
            this.tbLoginSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginSenha.Name = "tbLoginSenha";
            this.tbLoginSenha.Size = new System.Drawing.Size(180, 24);
            this.tbLoginSenha.TabIndex = 5;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.Location = new System.Drawing.Point(76, 220);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(104, 31);
            this.btnLogar.TabIndex = 6;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarSenha.ForeColor = System.Drawing.Color.White;
            this.cbMostrarSenha.Location = new System.Drawing.Point(47, 196);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(102, 19);
            this.cbMostrarSenha.TabIndex = 9;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contfy.Properties.Resources.ChatGPT_Image_5_de_mai__de_2026__23_05_39;
            this.pictureBox1.Location = new System.Drawing.Point(21, -41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lnkCriarConta
            // 
            this.lnkCriarConta.AutoSize = true;
            this.lnkCriarConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCriarConta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnkCriarConta.Location = new System.Drawing.Point(96, 284);
            this.lnkCriarConta.Name = "lnkCriarConta";
            this.lnkCriarConta.Size = new System.Drawing.Size(67, 15);
            this.lnkCriarConta.TabIndex = 12;
            this.lnkCriarConta.TabStop = true;
            this.lnkCriarConta.Text = "Criar Conta";
            this.lnkCriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCriarConta_LinkClicked);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(264, 313);
            this.Controls.Add(this.lnkCriarConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.tbLoginSenha);
            this.Controls.Add(this.tbLoginUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contfy - Login";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLoginUsuario;
        private System.Windows.Forms.TextBox tbLoginSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkCriarConta;
    }
}

