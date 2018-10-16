namespace LibraryManagementSystem
{
    partial class User_profile_form
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
            this.catagory_combo = new System.Windows.Forms.ComboBox();
            this.item_combo = new System.Windows.Forms.ComboBox();
            this.loan_itm_btn = new System.Windows.Forms.Button();
            this.catagory_lbl = new System.Windows.Forms.Label();
            this.item_lbl = new System.Windows.Forms.Label();
            this.remaining_count = new System.Windows.Forms.Label();
            this.last_date_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone_no_lbl = new System.Windows.Forms.Label();
            this.ph = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.user_email_lbll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loan_history_grid_view = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loan_history_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // catagory_combo
            // 
            this.catagory_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagory_combo.FormattingEnabled = true;
            this.catagory_combo.Location = new System.Drawing.Point(458, 97);
            this.catagory_combo.Name = "catagory_combo";
            this.catagory_combo.Size = new System.Drawing.Size(121, 21);
            this.catagory_combo.TabIndex = 0;
            this.catagory_combo.DropDownClosed += new System.EventHandler(this.Catagory_combo_DropDownClosed);
            // 
            // item_combo
            // 
            this.item_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.item_combo.FormattingEnabled = true;
            this.item_combo.Location = new System.Drawing.Point(667, 92);
            this.item_combo.Name = "item_combo";
            this.item_combo.Size = new System.Drawing.Size(121, 21);
            this.item_combo.TabIndex = 1;
            // 
            // loan_itm_btn
            // 
            this.loan_itm_btn.Location = new System.Drawing.Point(713, 156);
            this.loan_itm_btn.Name = "loan_itm_btn";
            this.loan_itm_btn.Size = new System.Drawing.Size(75, 23);
            this.loan_itm_btn.TabIndex = 2;
            this.loan_itm_btn.Text = "Loan item";
            this.loan_itm_btn.UseVisualStyleBackColor = true;
            this.loan_itm_btn.Click += new System.EventHandler(this.Loan_itm_btn_Click);
            // 
            // catagory_lbl
            // 
            this.catagory_lbl.AutoSize = true;
            this.catagory_lbl.Location = new System.Drawing.Point(387, 105);
            this.catagory_lbl.Name = "catagory_lbl";
            this.catagory_lbl.Size = new System.Drawing.Size(49, 13);
            this.catagory_lbl.TabIndex = 3;
            this.catagory_lbl.Text = "Catagory";
            // 
            // item_lbl
            // 
            this.item_lbl.AutoSize = true;
            this.item_lbl.Location = new System.Drawing.Point(613, 100);
            this.item_lbl.Name = "item_lbl";
            this.item_lbl.Size = new System.Drawing.Size(27, 13);
            this.item_lbl.TabIndex = 4;
            this.item_lbl.Text = "Item";
            // 
            // remaining_count
            // 
            this.remaining_count.AutoSize = true;
            this.remaining_count.Location = new System.Drawing.Point(664, 12);
            this.remaining_count.Name = "remaining_count";
            this.remaining_count.Size = new System.Drawing.Size(35, 13);
            this.remaining_count.TabIndex = 5;
            this.remaining_count.Text = "label1";
            // 
            // last_date_lbl
            // 
            this.last_date_lbl.AutoSize = true;
            this.last_date_lbl.Location = new System.Drawing.Point(455, 12);
            this.last_date_lbl.Name = "last_date_lbl";
            this.last_date_lbl.Size = new System.Drawing.Size(35, 13);
            this.last_date_lbl.TabIndex = 6;
            this.last_date_lbl.Text = "label1";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(86, 47);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(59, 13);
            this.email_lbl.TabIndex = 7;
            this.email_lbl.Text = "nameLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phone_no_lbl);
            this.groupBox1.Controls.Add(this.ph);
            this.groupBox1.Controls.Add(this.name_lbl);
            this.groupBox1.Controls.Add(this.user_email_lbll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.email_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // phone_no_lbl
            // 
            this.phone_no_lbl.AutoSize = true;
            this.phone_no_lbl.Location = new System.Drawing.Point(86, 71);
            this.phone_no_lbl.Name = "phone_no_lbl";
            this.phone_no_lbl.Size = new System.Drawing.Size(35, 13);
            this.phone_no_lbl.TabIndex = 12;
            this.phone_no_lbl.Text = "label2";
            // 
            // ph
            // 
            this.ph.AutoSize = true;
            this.ph.Location = new System.Drawing.Point(20, 71);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(58, 13);
            this.ph.TabIndex = 11;
            this.ph.Text = "Phone No.";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(86, 25);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 10;
            this.name_lbl.Text = "label3";
            // 
            // user_email_lbll
            // 
            this.user_email_lbll.AutoSize = true;
            this.user_email_lbll.Location = new System.Drawing.Point(20, 47);
            this.user_email_lbll.Name = "user_email_lbll";
            this.user_email_lbll.Size = new System.Drawing.Size(32, 13);
            this.user_email_lbll.TabIndex = 9;
            this.user_email_lbll.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // loan_history_grid_view
            // 
            this.loan_history_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loan_history_grid_view.Location = new System.Drawing.Point(12, 169);
            this.loan_history_grid_view.Name = "loan_history_grid_view";
            this.loan_history_grid_view.Size = new System.Drawing.Size(240, 150);
            this.loan_history_grid_view.TabIndex = 9;
            // 
            // User_profile_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loan_history_grid_view);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.last_date_lbl);
            this.Controls.Add(this.remaining_count);
            this.Controls.Add(this.item_lbl);
            this.Controls.Add(this.catagory_lbl);
            this.Controls.Add(this.loan_itm_btn);
            this.Controls.Add(this.item_combo);
            this.Controls.Add(this.catagory_combo);
            this.Name = "User_profile_form";
            this.Text = "user_profile_form";
            this.Load += new System.EventHandler(this.User_profile_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loan_history_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox catagory_combo;
        private System.Windows.Forms.ComboBox item_combo;
        private System.Windows.Forms.Button loan_itm_btn;
        private System.Windows.Forms.Label catagory_lbl;
        private System.Windows.Forms.Label item_lbl;
        private System.Windows.Forms.Label remaining_count;
        private System.Windows.Forms.Label last_date_lbl;
        public System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label user_email_lbll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loan_history_grid_view;
        private System.Windows.Forms.Label phone_no_lbl;
        private System.Windows.Forms.Label ph;
    }
}