﻿
namespace PROJECT
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkedListBox_Admin = new System.Windows.Forms.CheckedListBox();
            this.button_select = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(36, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Welcome Admin !";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.checkedListBox_Admin);
            this.panel2.Controls.Add(this.button_select);
            this.panel2.Location = new System.Drawing.Point(253, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 414);
            this.panel2.TabIndex = 25;
            // 
            // checkedListBox_Admin
            // 
            this.checkedListBox_Admin.BackColor = System.Drawing.Color.DarkBlue;
            this.checkedListBox_Admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Admin.CheckOnClick = true;
            this.checkedListBox_Admin.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox_Admin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkedListBox_Admin.FormattingEnabled = true;
            this.checkedListBox_Admin.Items.AddRange(new object[] {
            "Add professor",
            "Add student",
            "Add course",
            "Remove professor",
            "Remove student",
            "Remove course"});
            this.checkedListBox_Admin.Location = new System.Drawing.Point(17, 89);
            this.checkedListBox_Admin.Name = "checkedListBox_Admin";
            this.checkedListBox_Admin.Size = new System.Drawing.Size(255, 198);
            this.checkedListBox_Admin.TabIndex = 2;
            this.checkedListBox_Admin.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Admin_SelectedIndexChanged);
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.DarkBlue;
            this.button_select.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_select.Location = new System.Drawing.Point(126, 318);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(114, 54);
            this.button_select.TabIndex = 4;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://image.flaticon.com/icons/png/512/2416/2416656.png";
            this.pictureBox1.Location = new System.Drawing.Point(46, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button_Back
            // 
            this.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Lucida Console", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Back.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_Back.Location = new System.Drawing.Point(-5, 0);
            this.button_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(45, 49);
            this.button_Back.TabIndex = 26;
            this.button_Back.Text = "<";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.Location = new System.Drawing.Point(205, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(56, 40);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(513, 387);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Admin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Admin Page ";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox checkedListBox_Admin;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button buttonExit;
    }
}