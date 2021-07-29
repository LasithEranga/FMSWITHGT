
namespace Fine_Management_System
{
    partial class test
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
            this.fineReceipt1 = new Fine_Management_System.ReportItems.FineReceipt();
            this.SuspendLayout();
            // 
            // fineReceipt1
            // 
            this.fineReceipt1.Location = new System.Drawing.Point(12, 12);
            this.fineReceipt1.Name = "fineReceipt1";
            this.fineReceipt1.Size = new System.Drawing.Size(734, 417);
            this.fineReceipt1.TabIndex = 0;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fineReceipt1);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private ReportItems.FineReceipt fineReceipt1;
    }
}