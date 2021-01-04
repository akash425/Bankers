
namespace Bankers
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
            this.Allocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Allocation
            // 
            this.Allocation.AutoSize = true;
            this.Allocation.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Allocation.Location = new System.Drawing.Point(114, 26);
            this.Allocation.Name = "Allocation";
            this.Allocation.Size = new System.Drawing.Size(179, 48);
            this.Allocation.TabIndex = 0;
            this.Allocation.Text = "Allocation";
            this.Allocation.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 573);
            this.Controls.Add(this.Allocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Allocation;
    }
}

