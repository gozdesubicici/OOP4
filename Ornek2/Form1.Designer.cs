
namespace Ornek2
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
            this.lblGoruntule = new System.Windows.Forms.Label();
            this.lbxArabalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblGoruntule
            // 
            this.lblGoruntule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGoruntule.Location = new System.Drawing.Point(12, 214);
            this.lblGoruntule.Name = "lblGoruntule";
            this.lblGoruntule.Size = new System.Drawing.Size(467, 130);
            this.lblGoruntule.TabIndex = 0;
            this.lblGoruntule.Text = "label1";
            // 
            // lbxArabalar
            // 
            this.lbxArabalar.FormattingEnabled = true;
            this.lbxArabalar.Location = new System.Drawing.Point(12, 12);
            this.lbxArabalar.Name = "lbxArabalar";
            this.lbxArabalar.Size = new System.Drawing.Size(467, 186);
            this.lbxArabalar.TabIndex = 1;
            this.lbxArabalar.SelectedIndexChanged += new System.EventHandler(this.lbxArabalar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 353);
            this.Controls.Add(this.lbxArabalar);
            this.Controls.Add(this.lblGoruntule);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGoruntule;
        private System.Windows.Forms.ListBox lbxArabalar;
    }
}

