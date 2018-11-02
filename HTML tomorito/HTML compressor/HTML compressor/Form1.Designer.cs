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
            this.SuspendLayout();
            // 
            // btnForras
            // 
            this.btnForras.Location = new System.Drawing.Point(702, 12);
            this.btnForras.Name = "btnForras";
            this.btnForras.Size = new System.Drawing.Size(86, 25);
            this.btnForras.TabIndex = 1;
            this.btnForras.Text = "Tallóz";
            this.btnForras.UseVisualStyleBackColor = true;
            this.btnForras.Click += new System.EventHandler(this.btnForras_Click);
            // 
            // txtForras
            // 
            this.txtForras.Location = new System.Drawing.Point(81, 13);
            this.txtForras.Name = "txtForras";
            this.txtForras.Size = new System.Drawing.Size(615, 22);
            this.txtForras.TabIndex = 0;
            // 
            // lblForras
            // 
            this.lblForras.Location = new System.Drawing.Point(12, 10);
            this.lblForras.Name = "lblForras";
            this.lblForras.Size = new System.Drawing.Size(63, 25);
            this.lblForras.TabIndex = 2;
            this.lblForras.Text = "Forrás:";
            this.lblForras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCel
            // 
            this.btnCel.Location = new System.Drawing.Point(702, 56);
            this.btnCel.Name = "btnCel";
            this.btnCel.Size = new System.Drawing.Size(86, 25);
            this.btnCel.TabIndex = 3;
            this.btnCel.Text = "Tallóz";
            this.btnCel.UseVisualStyleBackColor = true;
            this.btnCel.Click += new System.EventHandler(this.btnCel_Click);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(81, 57);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(615, 22);
            this.txtCel.TabIndex = 2;
            // 
            // lblCel
            // 
            this.lblCel.Location = new System.Drawing.Point(12, 54);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(63, 25);
            this.lblCel.TabIndex = 2;
            this.lblCel.Text = "Cél:";
            this.lblCel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(610, 120);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(86, 25);
            this.btnCompress.TabIndex = 4;
            this.btnCompress.Text = "Tömörít";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnDeCompress
            // 
            this.btnDeCompress.Location = new System.Drawing.Point(702, 120);
            this.btnDeCompress.Name = "btnDeCompress";
            this.btnDeCompress.Size = new System.Drawing.Size(86, 25);
            this.btnDeCompress.TabIndex = 5;
            this.btnDeCompress.Text = "Visszafejt";
            this.btnDeCompress.UseVisualStyleBackColor = true;
            this.btnDeCompress.Click += new System.EventHandler(this.btnDeCompress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 157);
            this.Controls.Add(this.btnDeCompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblForras);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.btnCel);
            this.Controls.Add(this.txtForras);
            this.Controls.Add(this.btnForras);
            this.Name = "Form1";
            this.Text = "HTML tömörítő";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

// MADE BY: Józsa Dávid