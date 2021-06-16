﻿
namespace PROJECT
{
    partial class Form_Professor
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
            this.panel_Output = new System.Windows.Forms.Panel();
            this.textBox_Query = new System.Windows.Forms.TextBox();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.button_Grades = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Students = new System.Windows.Forms.Button();
            this.button_HighestScore = new System.Windows.Forms.Button();
            this.button_LowestScore = new System.Windows.Forms.Button();
            this.button_Average = new System.Windows.Forms.Button();
            this.button_PassingStudents = new System.Windows.Forms.Button();
            this.panel_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Output
            // 
            this.panel_Output.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_Output.Controls.Add(this.textBox_Query);
            this.panel_Output.Controls.Add(this.comboBox_Course);
            this.panel_Output.Location = new System.Drawing.Point(227, 27);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(332, 296);
            this.panel_Output.TabIndex = 0;
            // 
            // textBox_Query
            // 
            this.textBox_Query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Query.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Query.Location = new System.Drawing.Point(26, 60);
            this.textBox_Query.Multiline = true;
            this.textBox_Query.Name = "textBox_Query";
            this.textBox_Query.PlaceholderText = "The output will be displayed here! ";
            this.textBox_Query.ReadOnly = true;
            this.textBox_Query.Size = new System.Drawing.Size(282, 223);
            this.textBox_Query.TabIndex = 20;
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_Course.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Course.ForeColor = System.Drawing.Color.DarkBlue;
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(84, 19);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(178, 25);
            this.comboBox_Course.TabIndex = 19;
            this.comboBox_Course.Text = "Select Course";
            // 
            // button_Grades
            // 
            this.button_Grades.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Grades.FlatAppearance.BorderSize = 0;
            this.button_Grades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Grades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Grades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Grades.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Grades.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_Grades.Location = new System.Drawing.Point(27, 40);
            this.button_Grades.Name = "button_Grades";
            this.button_Grades.Size = new System.Drawing.Size(177, 42);
            this.button_Grades.TabIndex = 1;
            this.button_Grades.Text = "Add grades";
            this.button_Grades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Grades.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonExit.Location = new System.Drawing.Point(514, -3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(45, 27);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(149, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor   Menu";
            // 
            // button_Students
            // 
            this.button_Students.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Students.FlatAppearance.BorderSize = 0;
            this.button_Students.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Students.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Students.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Students.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_Students.Location = new System.Drawing.Point(26, 87);
            this.button_Students.Name = "button_Students";
            this.button_Students.Size = new System.Drawing.Size(177, 42);
            this.button_Students.TabIndex = 14;
            this.button_Students.Text = "Show Students";
            this.button_Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Students.UseVisualStyleBackColor = true;
            // 
            // button_HighestScore
            // 
            this.button_HighestScore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_HighestScore.FlatAppearance.BorderSize = 0;
            this.button_HighestScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_HighestScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_HighestScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HighestScore.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_HighestScore.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_HighestScore.Location = new System.Drawing.Point(27, 228);
            this.button_HighestScore.Name = "button_HighestScore";
            this.button_HighestScore.Size = new System.Drawing.Size(177, 42);
            this.button_HighestScore.TabIndex = 15;
            this.button_HighestScore.Text = "Show highest grade student";
            this.button_HighestScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HighestScore.UseVisualStyleBackColor = true;
            this.button_HighestScore.Click += new System.EventHandler(this.button_HighestScore_Click);
            // 
            // button_LowestScore
            // 
            this.button_LowestScore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_LowestScore.FlatAppearance.BorderSize = 0;
            this.button_LowestScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_LowestScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_LowestScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LowestScore.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_LowestScore.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_LowestScore.Location = new System.Drawing.Point(26, 180);
            this.button_LowestScore.Name = "button_LowestScore";
            this.button_LowestScore.Size = new System.Drawing.Size(177, 42);
            this.button_LowestScore.TabIndex = 16;
            this.button_LowestScore.Text = "Show lowest grade student";
            this.button_LowestScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LowestScore.UseVisualStyleBackColor = true;
            this.button_LowestScore.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Average
            // 
            this.button_Average.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Average.FlatAppearance.BorderSize = 0;
            this.button_Average.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Average.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Average.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Average.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Average.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_Average.Location = new System.Drawing.Point(28, 130);
            this.button_Average.Name = "button_Average";
            this.button_Average.Size = new System.Drawing.Size(177, 42);
            this.button_Average.TabIndex = 17;
            this.button_Average.Text = "Show course average";
            this.button_Average.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Average.UseVisualStyleBackColor = true;
            // 
            // button_PassingStudents
            // 
            this.button_PassingStudents.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_PassingStudents.FlatAppearance.BorderSize = 0;
            this.button_PassingStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_PassingStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_PassingStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PassingStudents.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_PassingStudents.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_PassingStudents.Location = new System.Drawing.Point(29, 268);
            this.button_PassingStudents.Name = "button_PassingStudents";
            this.button_PassingStudents.Size = new System.Drawing.Size(177, 42);
            this.button_PassingStudents.TabIndex = 18;
            this.button_PassingStudents.Text = "Show passing students";
            this.button_PassingStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PassingStudents.UseCompatibleTextRendering = true;
            this.button_PassingStudents.UseVisualStyleBackColor = true;
            // 
            // Form_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(559, 323);
            this.Controls.Add(this.button_PassingStudents);
            this.Controls.Add(this.button_Average);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_LowestScore);
            this.Controls.Add(this.button_HighestScore);
            this.Controls.Add(this.button_Students);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button_Grades);
            this.Controls.Add(this.panel_Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Professor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorForm";
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.Button button_Grades;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Students;
        private System.Windows.Forms.Button button_HighestScore;
        private System.Windows.Forms.Button button_LowestScore;
        private System.Windows.Forms.Button button_Average;
        private System.Windows.Forms.Button button_PassingStudents;
        private System.Windows.Forms.TextBox textBox_Query;
        private System.Windows.Forms.ComboBox comboBox_Course;
    }
}