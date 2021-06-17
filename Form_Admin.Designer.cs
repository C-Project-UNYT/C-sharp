
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox_Admin = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(131, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose what to do:";
            // 
            // checkedListBox_Admin
            // 
            this.checkedListBox_Admin.BackColor = System.Drawing.Color.Blue;
            this.checkedListBox_Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_Admin.CheckOnClick = true;
            this.checkedListBox_Admin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox_Admin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkedListBox_Admin.FormattingEnabled = true;
            this.checkedListBox_Admin.Items.AddRange(new object[] {
            "Add professor",
            "Add student",
            "Add course",
            "Remove professor",
            "Remove student",
            "Remove course"});
            this.checkedListBox_Admin.Location = new System.Drawing.Point(12, 102);
            this.checkedListBox_Admin.Name = "checkedListBox_Admin";
            this.checkedListBox_Admin.Size = new System.Drawing.Size(251, 206);
            this.checkedListBox_Admin.TabIndex = 2;
            this.checkedListBox_Admin.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Admin_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(65, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hello Boss!";
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.Silver;
            this.button_select.Location = new System.Drawing.Point(165, 314);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(123, 38);
            this.button_select.TabIndex = 4;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonExit.Location = new System.Drawing.Point(269, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(41, 37);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
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
            this.button_Back.Location = new System.Drawing.Point(0, 0);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(39, 37);
            this.button_Back.TabIndex = 20;
            this.button_Back.Text = "<";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(309, 364);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox_Admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form_Admin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Admin Page ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox_Admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button_Back;
    }
}