﻿
namespace Fine_Management_System.Error_messages
{
    partial class InputError
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Fine_Management_System.Properties.Resources.warning;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(38, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 66);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Fine_Management_System.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.button1.Location = new System.Drawing.Point(383, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Title.Location = new System.Drawing.Point(123, 54);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(231, 30);
            this.Title.TabIndex = 3;
            this.Title.Text = "Error";
            // 
            // msg
            // 
            this.msg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msg.Location = new System.Drawing.Point(129, 90);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(225, 30);
            this.msg.TabIndex = 4;
            this.msg.Text = "Error";
            // 
            // InputError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(422, 185);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputError";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label msg;
    }
}