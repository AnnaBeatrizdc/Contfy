namespace Contfy
{
    partial class UsuarioContainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioContainerForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbFiltroStatus = new System.Windows.Forms.ComboBox();
            this.dgvContainers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(654, 58);
            this.pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Painel de Containers";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(109, 78);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(255, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // cbFiltroStatus
            // 
            this.cbFiltroStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroStatus.FormattingEnabled = true;
            this.cbFiltroStatus.Location = new System.Drawing.Point(496, 75);
            this.cbFiltroStatus.Name = "cbFiltroStatus";
            this.cbFiltroStatus.Size = new System.Drawing.Size(121, 23);
            this.cbFiltroStatus.TabIndex = 1;
            this.cbFiltroStatus.Text = "Todos";
            this.cbFiltroStatus.SelectedIndexChanged += new System.EventHandler(this.cbFiltroStatus_SelectedIndexChanged);
            // 
            // dgvContainers
            // 
            this.dgvContainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContainers.Location = new System.Drawing.Point(12, 118);
            this.dgvContainers.Name = "dgvContainers";
            this.dgvContainers.ReadOnly = true;
            this.dgvContainers.RowHeadersWidth = 51;
            this.dgvContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContainers.Size = new System.Drawing.Size(630, 320);
            this.dgvContainers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pesquisar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(441, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status:";
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(265, 458);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(127, 28);
            this.btnHistorico.TabIndex = 15;
            this.btnHistorico.Text = "Baixar PDF";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(109, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pesquise pelo codigo, nome, localização ou responsavel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(496, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Escolha o status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contfy.Properties.Resources.ChatGPT_Image_5_de_mai__de_2026__23_05_39;
            this.pictureBox1.Location = new System.Drawing.Point(436, -43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // UsuarioContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(654, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFiltroStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvContainers);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txtPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuarioContainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contfy - Painel de Container";
            this.Load += new System.EventHandler(this.UsuarioContainerForm_Load_1);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cbFiltroStatus;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContainers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}