namespace hastaneotomasyonnn
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSekreterGirisi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDoktorGirisi = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHastaGirisi = new DevExpress.XtraEditors.SimpleButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Georgia", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(232, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(496, 49);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Medica Nova Hospital";
            // 
            // BtnSekreterGirisi
            // 
            this.BtnSekreterGirisi.Appearance.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSekreterGirisi.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSekreterGirisi.Appearance.Options.UseFont = true;
            this.BtnSekreterGirisi.Appearance.Options.UseForeColor = true;
            this.BtnSekreterGirisi.Location = new System.Drawing.Point(554, 550);
            this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            this.BtnSekreterGirisi.Size = new System.Drawing.Size(210, 56);
            this.BtnSekreterGirisi.TabIndex = 14;
            this.BtnSekreterGirisi.Text = "Sekreter Giriş";
            this.BtnSekreterGirisi.Click += new System.EventHandler(this.BtnSekreterGirisi_Click);
            // 
            // BtnDoktorGirisi
            // 
            this.BtnDoktorGirisi.Appearance.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDoktorGirisi.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDoktorGirisi.Appearance.Options.UseFont = true;
            this.BtnDoktorGirisi.Appearance.Options.UseForeColor = true;
            this.BtnDoktorGirisi.Location = new System.Drawing.Point(338, 550);
            this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            this.BtnDoktorGirisi.Size = new System.Drawing.Size(210, 56);
            this.BtnDoktorGirisi.TabIndex = 13;
            this.BtnDoktorGirisi.Text = "Doktor Giriş";
            this.BtnDoktorGirisi.Click += new System.EventHandler(this.BtnDoktorGirisi_Click);
            // 
            // BtnHastaGirisi
            // 
            this.BtnHastaGirisi.Appearance.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHastaGirisi.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnHastaGirisi.Appearance.Options.UseFont = true;
            this.BtnHastaGirisi.Appearance.Options.UseForeColor = true;
            this.BtnHastaGirisi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.BtnHastaGirisi.Location = new System.Drawing.Point(119, 550);
            this.BtnHastaGirisi.Name = "BtnHastaGirisi";
            this.BtnHastaGirisi.Size = new System.Drawing.Size(210, 56);
            this.BtnHastaGirisi.TabIndex = 12;
            this.BtnHastaGirisi.Text = "Hasta Giriş";
            this.BtnHastaGirisi.Click += new System.EventHandler(this.BtnHastaGirisi_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::hastaneotomasyonnn.Properties.Resources.Ekran_görüntüsü_2025_01_06_111420;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 632);
            this.Controls.Add(this.BtnSekreterGirisi);
            this.Controls.Add(this.BtnDoktorGirisi);
            this.Controls.Add(this.BtnHastaGirisi);
            this.Controls.Add(this.labelControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Hastane Giriş Sayfası";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnHastaGirisi;
        private DevExpress.XtraEditors.SimpleButton BtnDoktorGirisi;
        private DevExpress.XtraEditors.SimpleButton BtnSekreterGirisi;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

