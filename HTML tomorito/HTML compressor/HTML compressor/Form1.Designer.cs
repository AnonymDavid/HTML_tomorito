namespace HTML_compressor
{
    partial class Form1
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
            this.btnForras = new System.Windows.Forms.Button();
            this.txtForras = new System.Windows.Forms.TextBox();
            this.lblForras = new System.Windows.Forms.Label();
            this.btnCel = new System.Windows.Forms.Button();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnDeCompress = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mappaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStatisztika = new System.Windows.Forms.Button();
            this.txtStatisztika = new System.Windows.Forms.TextBox();
            this.lblStatisztika = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnForras
            // 
            this.btnForras.Location = new System.Drawing.Point(702, 45);
            this.btnForras.Name = "btnForras";
            this.btnForras.Size = new System.Drawing.Size(86, 25);
            this.btnForras.TabIndex = 1;
            this.btnForras.Text = "Tallóz";
            this.btnForras.UseVisualStyleBackColor = true;
            this.btnForras.Click += new System.EventHandler(this.btnForras_Click);
            // 
            // txtForras
            // 
            this.txtForras.Location = new System.Drawing.Point(95, 46);
            this.txtForras.Name = "txtForras";
            this.txtForras.Size = new System.Drawing.Size(601, 22);
            this.txtForras.TabIndex = 0;
            // 
            // lblForras
            // 
            this.lblForras.Location = new System.Drawing.Point(12, 43);
            this.lblForras.Name = "lblForras";
            this.lblForras.Size = new System.Drawing.Size(77, 25);
            this.lblForras.TabIndex = 2;
            this.lblForras.Text = "Forrás:";
            this.lblForras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCel
            // 
            this.btnCel.Location = new System.Drawing.Point(702, 89);
            this.btnCel.Name = "btnCel";
            this.btnCel.Size = new System.Drawing.Size(86, 25);
            this.btnCel.TabIndex = 3;
            this.btnCel.Text = "Tallóz";
            this.btnCel.UseVisualStyleBackColor = true;
            this.btnCel.Click += new System.EventHandler(this.btnCel_Click);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(95, 90);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(601, 22);
            this.txtCel.TabIndex = 2;
            // 
            // lblCel
            // 
            this.lblCel.Location = new System.Drawing.Point(12, 87);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(77, 25);
            this.lblCel.TabIndex = 2;
            this.lblCel.Text = "Cél:";
            this.lblCel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCompress
            // 
            this.btnCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompress.Location = new System.Drawing.Point(610, 172);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(86, 25);
            this.btnCompress.TabIndex = 4;
            this.btnCompress.Text = "Tömörít";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnDeCompress
            // 
            this.btnDeCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeCompress.Location = new System.Drawing.Point(702, 172);
            this.btnDeCompress.Name = "btnDeCompress";
            this.btnDeCompress.Size = new System.Drawing.Size(86, 25);
            this.btnDeCompress.TabIndex = 5;
            this.btnDeCompress.Text = "Visszafejt";
            this.btnDeCompress.UseVisualStyleBackColor = true;
            this.btnDeCompress.Click += new System.EventHandler(this.btnDeCompress_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.módToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // módToolStripMenuItem
            // 
            this.módToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.mappaToolStripMenuItem});
            this.módToolStripMenuItem.Name = "módToolStripMenuItem";
            this.módToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.módToolStripMenuItem.Text = "Mód";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Checked = true;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // mappaToolStripMenuItem
            // 
            this.mappaToolStripMenuItem.Name = "mappaToolStripMenuItem";
            this.mappaToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.mappaToolStripMenuItem.Text = "Mappa";
            this.mappaToolStripMenuItem.Click += new System.EventHandler(this.mappaToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // btnStatisztika
            // 
            this.btnStatisztika.Location = new System.Drawing.Point(702, 134);
            this.btnStatisztika.Name = "btnStatisztika";
            this.btnStatisztika.Size = new System.Drawing.Size(86, 25);
            this.btnStatisztika.TabIndex = 3;
            this.btnStatisztika.Text = "Tallóz";
            this.btnStatisztika.UseVisualStyleBackColor = true;
            this.btnStatisztika.Click += new System.EventHandler(this.btnStatisztika_Click);
            // 
            // txtStatisztika
            // 
            this.txtStatisztika.Location = new System.Drawing.Point(95, 135);
            this.txtStatisztika.Name = "txtStatisztika";
            this.txtStatisztika.Size = new System.Drawing.Size(601, 22);
            this.txtStatisztika.TabIndex = 2;
            // 
            // lblStatisztika
            // 
            this.lblStatisztika.Location = new System.Drawing.Point(12, 132);
            this.lblStatisztika.Name = "lblStatisztika";
            this.lblStatisztika.Size = new System.Drawing.Size(77, 25);
            this.lblStatisztika.TabIndex = 2;
            this.lblStatisztika.Text = "Statisztika:";
            this.lblStatisztika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.btnDeCompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.lblStatisztika);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblForras);
            this.Controls.Add(this.txtStatisztika);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.btnStatisztika);
            this.Controls.Add(this.btnCel);
            this.Controls.Add(this.txtForras);
            this.Controls.Add(this.btnForras);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HTML tömörítő";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForras;
        private System.Windows.Forms.TextBox txtForras;
        private System.Windows.Forms.Label lblForras;
        private System.Windows.Forms.Button btnCel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnDeCompress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mappaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.Button btnStatisztika;
        private System.Windows.Forms.TextBox txtStatisztika;
        private System.Windows.Forms.Label lblStatisztika;
    }
}

// MADE BY: Józsa Dávid