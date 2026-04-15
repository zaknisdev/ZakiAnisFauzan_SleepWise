namespace SleepWise
{
    partial class FormSleepTracker
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
            this.dtpTidur = new System.Windows.Forms.DateTimePicker();
            this.dtpBangun = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTidur
            // 
            this.dtpTidur.CustomFormat = "HH:mm";
            this.dtpTidur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTidur.Location = new System.Drawing.Point(134, 100);
            this.dtpTidur.Name = "dtpTidur";
            this.dtpTidur.ShowUpDown = true;
            this.dtpTidur.Size = new System.Drawing.Size(74, 26);
            this.dtpTidur.TabIndex = 1;
            this.dtpTidur.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpBangun
            // 
            this.dtpBangun.CustomFormat = "HH:mm";
            this.dtpBangun.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBangun.Location = new System.Drawing.Point(134, 147);
            this.dtpBangun.Name = "dtpBangun";
            this.dtpBangun.ShowUpDown = true;
            this.dtpBangun.Size = new System.Drawing.Size(74, 26);
            this.dtpBangun.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Waktu Tidur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waktu Bangun:";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSimpan.Location = new System.Drawing.Point(477, 62);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(194, 75);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(134, 47);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(119, 26);
            this.dtpTanggal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tanggal:";
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayat.Location = new System.Drawing.Point(13, 229);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.RowHeadersWidth = 62;
            this.dgvRiwayat.RowTemplate.Height = 28;
            this.dgvRiwayat.Size = new System.Drawing.Size(760, 196);
            this.dgvRiwayat.TabIndex = 8;
            // 
            // FormSleepTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRiwayat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBangun);
            this.Controls.Add(this.dtpTidur);
            this.Name = "FormSleepTracker";
            this.Text = "FormSleepTracker";
            this.Load += new System.EventHandler(this.FormSleepTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpTidur;
        private System.Windows.Forms.DateTimePicker dtpBangun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRiwayat;
    }
}