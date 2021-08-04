
namespace Fine_Management_System.Error_messages
{
    partial class DBError
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::Fine_Management_System.Properties.Resources.close;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.closeBtn.Location = new System.Drawing.Point(383, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(31, 29);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // msg
            // 
            this.msg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msg.Location = new System.Drawing.Point(137, 96);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(225, 30);
            this.msg.TabIndex = 7;
            this.msg.Text = "Error";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Title.Location = new System.Drawing.Point(136, 51);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(246, 30);
            this.Title.TabIndex = 6;
            this.Title.Text = "Error";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Fine_Management_System.Properties.Resources.warning;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(45, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 66);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.msg);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 183);
            this.panel2.TabIndex = 8;
            // 
            // DBError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(423, 185);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DBError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBError";
            this.Load += new System.EventHandler(this.DBError_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}