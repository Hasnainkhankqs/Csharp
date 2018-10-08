namespace LibraryManagementSystem
{
    partial class login_form
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
            this.email_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password_label = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_link = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(23, 56);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(32, 13);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.email_txt);
            this.groupBox1.Controls.Add(this.password_label);
            this.groupBox1.Controls.Add(this.email_label);
            this.groupBox1.Location = new System.Drawing.Point(495, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(23, 100);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(127, 49);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 20);
            this.email_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(127, 100);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(152, 156);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // register_link
            // 
            this.register_link.AutoSize = true;
            this.register_link.Location = new System.Drawing.Point(657, 296);
            this.register_link.Name = "register_link";
            this.register_link.Size = new System.Drawing.Size(71, 13);
            this.register_link.TabIndex = 5;
            this.register_link.TabStop = true;
            this.register_link.Text = "Register Now";
            this.register_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_link_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login From";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.register_link);
            this.Controls.Add(this.groupBox1);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.LinkLabel register_link;
        private System.Windows.Forms.Label label3;
    }
}