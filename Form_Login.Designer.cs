
namespace PROJECT
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer varia ble.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.checkBox_ShowPass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Continue = new System.Windows.Forms.Button();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_Login.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Login.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_Login.Location = new System.Drawing.Point(319, 20);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(100, 43);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Login";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Username.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Username.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_Username.Location = new System.Drawing.Point(167, 138);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(103, 25);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Password.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_Password.Location = new System.Drawing.Point(167, 200);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(97, 25);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password:";
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.BackColor = System.Drawing.Color.Silver;
            this.comboBox_Role.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Role.ForeColor = System.Drawing.Color.DarkBlue;
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "Admin",
            "Professor",
            "Student"});
            this.comboBox_Role.Location = new System.Drawing.Point(276, 91);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(178, 25);
            this.comboBox_Role.TabIndex = 5;
            this.comboBox_Role.Text = "  Select Role";
            this.comboBox_Role.SelectedIndexChanged += new System.EventHandler(this.comboBox_Role_SelectedIndexChanged);
            // 
            // checkBox_ShowPass
            // 
            this.checkBox_ShowPass.AutoSize = true;
            this.checkBox_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_ShowPass.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_ShowPass.Location = new System.Drawing.Point(468, 206);
            this.checkBox_ShowPass.Name = "checkBox_ShowPass";
            this.checkBox_ShowPass.Size = new System.Drawing.Size(54, 19);
            this.checkBox_ShowPass.TabIndex = 7;
            this.checkBox_ShowPass.Text = "Show";
            this.checkBox_ShowPass.UseVisualStyleBackColor = true;
            this.checkBox_ShowPass.CheckedChanged += new System.EventHandler(this.checkBox_ShowPass_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 327);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.ImageLocation = "https://th.bing.com/th/id/OIP.s8q4V6wni0Ip_zQCISipNQHaMG?pid=ImgDet&rs=1";
            this.pictureBox1.Location = new System.Drawing.Point(29, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Continue
            // 
            this.button_Continue.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Continue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Continue.ForeColor = System.Drawing.Color.White;
            this.button_Continue.Location = new System.Drawing.Point(400, 255);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(136, 43);
            this.button_Continue.TabIndex = 6;
            this.button_Continue.Text = "Continue";
            this.button_Continue.UseVisualStyleBackColor = false;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.AllowDrop = true;
            this.textBox_Pass.BackColor = System.Drawing.Color.White;
            this.textBox_Pass.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Pass.Location = new System.Drawing.Point(276, 200);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(178, 23);
            this.textBox_Pass.TabIndex = 9;
            this.textBox_Pass.UseSystemPasswordChar = true;
            // 
            // textBox_Username
            // 
            this.textBox_Username.AllowDrop = true;
            this.textBox_Username.BackColor = System.Drawing.Color.White;
            this.textBox_Username.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Username.Location = new System.Drawing.Point(276, 143);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(178, 23);
            this.textBox_Username.TabIndex = 10;
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
            this.buttonExit.Location = new System.Drawing.Point(518, -6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(45, 34);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(559, 323);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox_ShowPass);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.CheckBox checkBox_ShowPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
    }
}

