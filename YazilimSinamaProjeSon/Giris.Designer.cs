
namespace YazilimSinamaProjeSon
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.buttonliste = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 48);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the section you want to go";
            // 
            // buttonekle
            // 
            this.buttonekle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonekle.FlatAppearance.BorderSize = 0;
            this.buttonekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonekle.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonekle.ForeColor = System.Drawing.Color.White;
            this.buttonekle.Location = new System.Drawing.Point(83, 179);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(164, 36);
            this.buttonekle.TabIndex = 12;
            this.buttonekle.Text = "Task Ekle";
            this.buttonekle.UseVisualStyleBackColor = false;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonguncelle.FlatAppearance.BorderSize = 0;
            this.buttonguncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonguncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonguncelle.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguncelle.ForeColor = System.Drawing.Color.White;
            this.buttonguncelle.Location = new System.Drawing.Point(371, 179);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(164, 44);
            this.buttonguncelle.TabIndex = 13;
            this.buttonguncelle.Text = "Task Güncelle";
            this.buttonguncelle.UseVisualStyleBackColor = false;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // buttonliste
            // 
            this.buttonliste.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonliste.FlatAppearance.BorderSize = 0;
            this.buttonliste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonliste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonliste.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonliste.ForeColor = System.Drawing.Color.White;
            this.buttonliste.Location = new System.Drawing.Point(221, 288);
            this.buttonliste.Name = "buttonliste";
            this.buttonliste.Size = new System.Drawing.Size(164, 40);
            this.buttonliste.TabIndex = 14;
            this.buttonliste.Text = "Task Listele";
            this.buttonliste.UseVisualStyleBackColor = false;
            this.buttonliste.Click += new System.EventHandler(this.buttonliste_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 448);
            this.Controls.Add(this.buttonliste);
            this.Controls.Add(this.buttonguncelle);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Giris";
            this.Text = "Giris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.Button buttonliste;
    }
}