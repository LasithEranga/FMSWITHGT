
namespace Fine_Management_System.ReportItems
{
    partial class ShowReceipt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRef = new System.Windows.Forms.Label();
            this.labelDriverName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPoliceOfficer = new System.Windows.Forms.Label();
            this.labelFineAmount = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRef);
            this.panel1.Location = new System.Drawing.Point(34, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 65);
            this.panel1.TabIndex = 0;
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRef.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRef.Location = new System.Drawing.Point(291, 14);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(144, 40);
            this.labelRef.TabIndex = 0;
            this.labelRef.Text = "Ref_No :";
            // 
            // labelDriverName
            // 
            this.labelDriverName.AutoSize = true;
            this.labelDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriverName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDriverName.Location = new System.Drawing.Point(64, 95);
            this.labelDriverName.Name = "labelDriverName";
            this.labelDriverName.Size = new System.Drawing.Size(108, 20);
            this.labelDriverName.TabIndex = 1;
            this.labelDriverName.Text = "Driver Name : ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDate.Location = new System.Drawing.Point(64, 134);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(56, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date : ";
            // 
            // labelPoliceOfficer
            // 
            this.labelPoliceOfficer.AutoSize = true;
            this.labelPoliceOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoliceOfficer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPoliceOfficer.Location = new System.Drawing.Point(489, 134);
            this.labelPoliceOfficer.Name = "labelPoliceOfficer";
            this.labelPoliceOfficer.Size = new System.Drawing.Size(110, 20);
            this.labelPoliceOfficer.TabIndex = 3;
            this.labelPoliceOfficer.Text = "Police Officer :";
            // 
            // labelFineAmount
            // 
            this.labelFineAmount.AutoSize = true;
            this.labelFineAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFineAmount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelFineAmount.Location = new System.Drawing.Point(489, 95);
            this.labelFineAmount.Name = "labelFineAmount";
            this.labelFineAmount.Size = new System.Drawing.Size(108, 20);
            this.labelFineAmount.TabIndex = 4;
            this.labelFineAmount.Text = "Fine Amount :";
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(34, 214);
            this.table.Name = "table";
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(787, 209);
            this.table.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(30, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Reciept Info";
            // 
            // ShowReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.table);
            this.Controls.Add(this.labelFineAmount);
            this.Controls.Add(this.labelPoliceOfficer);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDriverName);
            this.Controls.Add(this.panel1);
            this.Name = "ShowReceipt";
            this.Size = new System.Drawing.Size(895, 481);
            this.Load += new System.EventHandler(this.ShowReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.Label labelDriverName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPoliceOfficer;
        private System.Windows.Forms.Label labelFineAmount;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label6;
    }
}
