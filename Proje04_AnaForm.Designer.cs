namespace BIP2504_PROJE04
{
    partial class ESProje04_AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.ESlblkitapno = new System.Windows.Forms.Label();
            this.EStbKitapNo = new System.Windows.Forms.TextBox();
            this.EStbKitapAdi = new System.Windows.Forms.TextBox();
            this.ESlblkitapadi = new System.Windows.Forms.Label();
            this.ESlblyazaradi = new System.Windows.Forms.Label();
            this.EScmbKitapTuru = new System.Windows.Forms.ComboBox();
            this.ESlblkitapturu = new System.Windows.Forms.Label();
            this.ESdgvKitapListesi = new System.Windows.Forms.DataGridView();
            this.KitapListeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kitapGuncelleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kitapSilMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.yayinciBilgisiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbKitap = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ESlblkitaplistesi = new System.Windows.Forms.Label();
            this.EStbYazarAdi = new System.Windows.Forms.TextBox();
            this.ESbtnKitapRapor = new System.Windows.Forms.ToolStripButton();
            this.ESbtnKapat = new System.Windows.Forms.ToolStripButton();
            this.ESbtnGuncelle = new System.Windows.Forms.Button();
            this.ESbtnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ESdgvKitapListesi)).BeginInit();
            this.KitapListeMenu.SuspendLayout();
            this.tsbKitap.SuspendLayout();
            this.SuspendLayout();
            // 
            // ESlblkitapno
            // 
            this.ESlblkitapno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ESlblkitapno.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ESlblkitapno.Location = new System.Drawing.Point(22, 90);
            this.ESlblkitapno.Name = "ESlblkitapno";
            this.ESlblkitapno.Size = new System.Drawing.Size(124, 24);
            this.ESlblkitapno.TabIndex = 0;
            this.ESlblkitapno.Text = "Kitap No :";
            this.ESlblkitapno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EStbKitapNo
            // 
            this.EStbKitapNo.Location = new System.Drawing.Point(152, 91);
            this.EStbKitapNo.Name = "EStbKitapNo";
            this.EStbKitapNo.Size = new System.Drawing.Size(111, 24);
            this.EStbKitapNo.TabIndex = 0;
            // 
            // EStbKitapAdi
            // 
            this.EStbKitapAdi.Location = new System.Drawing.Point(152, 133);
            this.EStbKitapAdi.Multiline = true;
            this.EStbKitapAdi.Name = "EStbKitapAdi";
            this.EStbKitapAdi.Size = new System.Drawing.Size(191, 57);
            this.EStbKitapAdi.TabIndex = 1;
            // 
            // ESlblkitapadi
            // 
            this.ESlblkitapadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ESlblkitapadi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ESlblkitapadi.Location = new System.Drawing.Point(22, 132);
            this.ESlblkitapadi.Name = "ESlblkitapadi";
            this.ESlblkitapadi.Size = new System.Drawing.Size(124, 24);
            this.ESlblkitapadi.TabIndex = 1;
            this.ESlblkitapadi.Text = "Kitap Adı :";
            this.ESlblkitapadi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ESlblyazaradi
            // 
            this.ESlblyazaradi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ESlblyazaradi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ESlblyazaradi.Location = new System.Drawing.Point(22, 213);
            this.ESlblyazaradi.Name = "ESlblyazaradi";
            this.ESlblyazaradi.Size = new System.Drawing.Size(124, 24);
            this.ESlblyazaradi.TabIndex = 2;
            this.ESlblyazaradi.Text = "Yazar Adı :";
            this.ESlblyazaradi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EScmbKitapTuru
            // 
            this.EScmbKitapTuru.FormattingEnabled = true;
            this.EScmbKitapTuru.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Aşk",
            "Bilimsel"});
            this.EScmbKitapTuru.Location = new System.Drawing.Point(152, 258);
            this.EScmbKitapTuru.Name = "EScmbKitapTuru";
            this.EScmbKitapTuru.Size = new System.Drawing.Size(191, 24);
            this.EScmbKitapTuru.TabIndex = 3;
            // 
            // ESlblkitapturu
            // 
            this.ESlblkitapturu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ESlblkitapturu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ESlblkitapturu.Location = new System.Drawing.Point(22, 257);
            this.ESlblkitapturu.Name = "ESlblkitapturu";
            this.ESlblkitapturu.Size = new System.Drawing.Size(124, 24);
            this.ESlblkitapturu.TabIndex = 3;
            this.ESlblkitapturu.Text = "Kitap Türü :";
            this.ESlblkitapturu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ESdgvKitapListesi
            // 
            this.ESdgvKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ESdgvKitapListesi.Location = new System.Drawing.Point(374, 90);
            this.ESdgvKitapListesi.Name = "ESdgvKitapListesi";
            this.ESdgvKitapListesi.RowTemplate.ContextMenuStrip = this.KitapListeMenu;
            this.ESdgvKitapListesi.Size = new System.Drawing.Size(834, 282);
            this.ESdgvKitapListesi.TabIndex = 6;
            // 
            // KitapListeMenu
            // 
            this.KitapListeMenu.Font = new System.Drawing.Font("Verdana", 10F);
            this.KitapListeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapGuncelleMenuItem,
            this.toolStripSeparator2,
            this.kitapSilMenuItem,
            this.toolStripSeparator3,
            this.yayinciBilgisiMenuItem});
            this.KitapListeMenu.Name = "KitapListeMenu";
            this.KitapListeMenu.Size = new System.Drawing.Size(181, 104);
            // 
            // kitapGuncelleMenuItem
            // 
            this.kitapGuncelleMenuItem.Name = "kitapGuncelleMenuItem";
            this.kitapGuncelleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapGuncelleMenuItem.Text = "Kitap Güncelle";
            this.kitapGuncelleMenuItem.Click += new System.EventHandler(this.kitapGuncelleMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // kitapSilMenuItem
            // 
            this.kitapSilMenuItem.Name = "kitapSilMenuItem";
            this.kitapSilMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapSilMenuItem.Text = "Kitap Sil";
            this.kitapSilMenuItem.Click += new System.EventHandler(this.kitapSilMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // yayinciBilgisiMenuItem
            // 
            this.yayinciBilgisiMenuItem.Name = "yayinciBilgisiMenuItem";
            this.yayinciBilgisiMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yayinciBilgisiMenuItem.Text = "Yayıncı Bilgisi";
            this.yayinciBilgisiMenuItem.Click += new System.EventHandler(this.yayinciBilgisiMenuItem_Click);
            // 
            // tsbKitap
            // 
            this.tsbKitap.BackColor = System.Drawing.SystemColors.Control;
            this.tsbKitap.Font = new System.Drawing.Font("Verdana", 10F);
            this.tsbKitap.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tsbKitap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ESbtnKitapRapor,
            this.toolStripSeparator1,
            this.ESbtnKapat});
            this.tsbKitap.Location = new System.Drawing.Point(0, 0);
            this.tsbKitap.Name = "tsbKitap";
            this.tsbKitap.Size = new System.Drawing.Size(1221, 55);
            this.tsbKitap.TabIndex = 7;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // ESlblkitaplistesi
            // 
            this.ESlblkitaplistesi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ESlblkitaplistesi.Location = new System.Drawing.Point(374, 63);
            this.ESlblkitaplistesi.Name = "ESlblkitaplistesi";
            this.ESlblkitaplistesi.Size = new System.Drawing.Size(124, 24);
            this.ESlblkitaplistesi.TabIndex = 4;
            this.ESlblkitaplistesi.Text = "Kitap Listesi";
            this.ESlblkitaplistesi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EStbYazarAdi
            // 
            this.EStbYazarAdi.Location = new System.Drawing.Point(152, 213);
            this.EStbYazarAdi.Name = "EStbYazarAdi";
            this.EStbYazarAdi.Size = new System.Drawing.Size(191, 24);
            this.EStbYazarAdi.TabIndex = 2;
            // 
            // ESbtnKitapRapor
            // 
            this.ESbtnKitapRapor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ESbtnKitapRapor.Image = global::BIP2504_PROJE04.Properties.Resources.RAPOR;
            this.ESbtnKitapRapor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ESbtnKitapRapor.Name = "ESbtnKitapRapor";
            this.ESbtnKitapRapor.Size = new System.Drawing.Size(52, 52);
            this.ESbtnKitapRapor.Text = "Kitap Raporu";
            this.ESbtnKitapRapor.ToolTipText = "Kitap Raporu";
            this.ESbtnKitapRapor.Click += new System.EventHandler(this.ESbtnKitapRapor_Click);
            // 
            // ESbtnKapat
            // 
            this.ESbtnKapat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ESbtnKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ESbtnKapat.Image = global::BIP2504_PROJE04.Properties.Resources.KAPAT;
            this.ESbtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ESbtnKapat.Name = "ESbtnKapat";
            this.ESbtnKapat.Size = new System.Drawing.Size(52, 52);
            this.ESbtnKapat.Text = "Programdan Çıkış";
            this.ESbtnKapat.Click += new System.EventHandler(this.ESbtnKapat_Click);
            // 
            // ESbtnGuncelle
            // 
            this.ESbtnGuncelle.BackgroundImage = global::BIP2504_PROJE04.Properties.Resources.YENILE;
            this.ESbtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ESbtnGuncelle.Location = new System.Drawing.Point(152, 320);
            this.ESbtnGuncelle.Name = "ESbtnGuncelle";
            this.ESbtnGuncelle.Size = new System.Drawing.Size(52, 52);
            this.ESbtnGuncelle.TabIndex = 5;
            this.ESbtnGuncelle.UseVisualStyleBackColor = true;
            this.ESbtnGuncelle.Click += new System.EventHandler(this.ESbtnGuncelle_Click);
            // 
            // ESbtnKaydet
            // 
            this.ESbtnKaydet.BackgroundImage = global::BIP2504_PROJE04.Properties.Resources.KAYDET;
            this.ESbtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ESbtnKaydet.Location = new System.Drawing.Point(291, 320);
            this.ESbtnKaydet.Name = "ESbtnKaydet";
            this.ESbtnKaydet.Size = new System.Drawing.Size(52, 52);
            this.ESbtnKaydet.TabIndex = 4;
            this.ESbtnKaydet.UseVisualStyleBackColor = true;
            this.ESbtnKaydet.Click += new System.EventHandler(this.ESbtnKaydet_Click);
            // 
            // ESProje04_AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 384);
            this.ControlBox = false;
            this.Controls.Add(this.EStbYazarAdi);
            this.Controls.Add(this.ESlblkitaplistesi);
            this.Controls.Add(this.tsbKitap);
            this.Controls.Add(this.ESbtnGuncelle);
            this.Controls.Add(this.ESbtnKaydet);
            this.Controls.Add(this.ESdgvKitapListesi);
            this.Controls.Add(this.ESlblkitapturu);
            this.Controls.Add(this.EScmbKitapTuru);
            this.Controls.Add(this.ESlblyazaradi);
            this.Controls.Add(this.EStbKitapAdi);
            this.Controls.Add(this.ESlblkitapadi);
            this.Controls.Add(this.EStbKitapNo);
            this.Controls.Add(this.ESlblkitapno);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ESProje04_AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIP2504 - PROJE 04 ";
            this.Load += new System.EventHandler(this.ESProje04_AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ESdgvKitapListesi)).EndInit();
            this.KitapListeMenu.ResumeLayout(false);
            this.tsbKitap.ResumeLayout(false);
            this.tsbKitap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ESlblkitapno;
        private System.Windows.Forms.TextBox EStbKitapNo;
        private System.Windows.Forms.TextBox EStbKitapAdi;
        private System.Windows.Forms.Label ESlblkitapadi;
        private System.Windows.Forms.Label ESlblyazaradi;
        private System.Windows.Forms.ComboBox EScmbKitapTuru;
        private System.Windows.Forms.Label ESlblkitapturu;
        private System.Windows.Forms.DataGridView ESdgvKitapListesi;
        private System.Windows.Forms.Button ESbtnKaydet;
        private System.Windows.Forms.Button ESbtnGuncelle;
        private System.Windows.Forms.ContextMenuStrip KitapListeMenu;
        private System.Windows.Forms.ToolStripMenuItem kitapGuncelleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapSilMenuItem;
        private System.Windows.Forms.ToolStrip tsbKitap;
        private System.Windows.Forms.ToolStripButton ESbtnKitapRapor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ESbtnKapat;
        private System.Windows.Forms.Label ESlblkitaplistesi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox EStbYazarAdi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem yayinciBilgisiMenuItem;
    }
}

