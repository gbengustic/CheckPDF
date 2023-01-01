
namespace CheckPDF
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
            this.TxtPDFPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtPdfText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPDFPath
            // 
            this.TxtPDFPath.Location = new System.Drawing.Point(100, 29);
            this.TxtPDFPath.Name = "TxtPDFPath";
            this.TxtPDFPath.Size = new System.Drawing.Size(509, 26);
            this.TxtPDFPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDF Path:";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBrowse.Location = new System.Drawing.Point(615, 31);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(95, 23);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtPdfText
            // 
            this.TxtPdfText.Location = new System.Drawing.Point(16, 97);
            this.TxtPdfText.Multiline = true;
            this.TxtPdfText.Name = "TxtPdfText";
            this.TxtPdfText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtPdfText.Size = new System.Drawing.Size(694, 418);
            this.TxtPdfText.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnStart
            // 
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnStart.Location = new System.Drawing.Point(317, 532);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(119, 45);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 589);
            this.Controls.Add(this.TxtPdfText);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPDFPath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPDFPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtPdfText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnStart;
    }
}

