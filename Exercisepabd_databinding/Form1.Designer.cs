
namespace Exercisepabd_databinding
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
            this.textfBox_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.term_and_condition = new System.Windows.Forms.CheckBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textfBox_nama
            // 
            this.textfBox_nama.Location = new System.Drawing.Point(162, 125);
            this.textfBox_nama.Multiline = true;
            this.textfBox_nama.Name = "textfBox_nama";
            this.textfBox_nama.Size = new System.Drawing.Size(166, 20);
            this.textfBox_nama.TabIndex = 0;
            this.textfBox_nama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(89, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA MAHASISWA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_username.Location = new System.Drawing.Point(162, 109);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(55, 13);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username";
            this.label_username.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(162, 184);
            this.textBox_pass.Multiline = true;
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(166, 20);
            this.textBox_pass.TabIndex = 4;
            this.textBox_pass.TextChanged += new System.EventHandler(this.textBox_pass_TextChanged);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_pass.Location = new System.Drawing.Point(162, 168);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(53, 13);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "Password";
            // 
            // term_and_condition
            // 
            this.term_and_condition.AutoSize = true;
            this.term_and_condition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.term_and_condition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.term_and_condition.Location = new System.Drawing.Point(162, 211);
            this.term_and_condition.Name = "term_and_condition";
            this.term_and_condition.Size = new System.Drawing.Size(118, 17);
            this.term_and_condition.TabIndex = 6;
            this.term_and_condition.Text = "Term and Condition";
            this.term_and_condition.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_exit.Location = new System.Drawing.Point(162, 251);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_login
            // 
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_login.Location = new System.Drawing.Point(253, 251);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 8;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(246, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informasi";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(112, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Teknologi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(508, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.term_and_condition);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textfBox_nama);
            this.Name = "Form1";
            this.Text = "Teknologi Informasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textfBox_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.CheckBox term_and_condition;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

