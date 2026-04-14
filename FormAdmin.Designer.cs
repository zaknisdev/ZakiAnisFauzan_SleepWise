namespace SleepWise
{
    partial class FormAdmin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnDataPengguna = new System.Windows.Forms.Button();
            this.btnDataLog = new System.Windows.Forms.Button();
            this.btnHapusPengguna = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdKategori = new System.Windows.Forms.TextBox();
            this.txtSaranBaru = new System.Windows.Forms.TextBox();
            this.btnUpdateSaran = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(34, 19);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersWidth = 62;
            this.dgvAdmin.RowTemplate.Height = 28;
            this.dgvAdmin.Size = new System.Drawing.Size(291, 419);
            this.dgvAdmin.TabIndex = 0;
            // 
            // btnDataPengguna
            // 
            this.btnDataPengguna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDataPengguna.Location = new System.Drawing.Point(664, 198);
            this.btnDataPengguna.Name = "btnDataPengguna";
            this.btnDataPengguna.Size = new System.Drawing.Size(124, 54);
            this.btnDataPengguna.TabIndex = 1;
            this.btnDataPengguna.Text = "Load Pengguna";
            this.btnDataPengguna.UseVisualStyleBackColor = false;
            this.btnDataPengguna.Click += new System.EventHandler(this.btnDataPengguna_Click);
            // 
            // btnDataLog
            // 
            this.btnDataLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDataLog.Location = new System.Drawing.Point(664, 258);
            this.btnDataLog.Name = "btnDataLog";
            this.btnDataLog.Size = new System.Drawing.Size(124, 54);
            this.btnDataLog.TabIndex = 2;
            this.btnDataLog.Text = "Load Log Tidur";
            this.btnDataLog.UseVisualStyleBackColor = false;
            this.btnDataLog.Click += new System.EventHandler(this.btnDataLog_Click);
            // 
            // btnHapusPengguna
            // 
            this.btnHapusPengguna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHapusPengguna.Location = new System.Drawing.Point(664, 318);
            this.btnHapusPengguna.Name = "btnHapusPengguna";
            this.btnHapusPengguna.Size = new System.Drawing.Size(124, 54);
            this.btnHapusPengguna.TabIndex = 3;
            this.btnHapusPengguna.Text = "Hapus pengguna";
            this.btnHapusPengguna.UseVisualStyleBackColor = false;
            this.btnHapusPengguna.Click += new System.EventHandler(this.btnHapusPengguna_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Location = new System.Drawing.Point(664, 378);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 54);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategori ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saran Baru";
            // 
            // txtIdKategori
            // 
            this.txtIdKategori.Location = new System.Drawing.Point(450, 79);
            this.txtIdKategori.Name = "txtIdKategori";
            this.txtIdKategori.Size = new System.Drawing.Size(33, 26);
            this.txtIdKategori.TabIndex = 7;
            // 
            // txtSaranBaru
            // 
            this.txtSaranBaru.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSaranBaru.Location = new System.Drawing.Point(430, 111);
            this.txtSaranBaru.Multiline = true;
            this.txtSaranBaru.Name = "txtSaranBaru";
            this.txtSaranBaru.Size = new System.Drawing.Size(228, 183);
            this.txtSaranBaru.TabIndex = 8;
            // 
            // btnUpdateSaran
            // 
            this.btnUpdateSaran.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateSaran.Location = new System.Drawing.Point(664, 138);
            this.btnUpdateSaran.Name = "btnUpdateSaran";
            this.btnUpdateSaran.Size = new System.Drawing.Size(124, 54);
            this.btnUpdateSaran.TabIndex = 9;
            this.btnUpdateSaran.Text = "Update Saran";
            this.btnUpdateSaran.UseVisualStyleBackColor = false;
            this.btnUpdateSaran.Click += new System.EventHandler(this.btnUpdateSaran_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateSaran);
            this.Controls.Add(this.txtSaranBaru);
            this.Controls.Add(this.txtIdKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHapusPengguna);
            this.Controls.Add(this.btnDataLog);
            this.Controls.Add(this.btnDataPengguna);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnDataPengguna;
        private System.Windows.Forms.Button btnDataLog;
        private System.Windows.Forms.Button btnHapusPengguna;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdKategori;
        private System.Windows.Forms.TextBox txtSaranBaru;
        private System.Windows.Forms.Button btnUpdateSaran;
    }
}