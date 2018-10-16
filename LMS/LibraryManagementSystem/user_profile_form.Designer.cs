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
            this.name_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // catagory_combo
            // 
            this.catagory_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagory_combo.FormattingEnabled = true;
            this.catagory_combo.Location = new System.Drawing.Point(249, 122);
            this.catagory_combo.Name = "catagory_combo";
            this.catagory_combo.Size = new System.Drawing.Size(121, 21);
            this.catagory_combo.TabIndex = 0;
            this.catagory_combo.DropDownClosed += new System.EventHandler(this.Catagory_combo_DropDownClosed);
            // 
            // item_combo
            // 
            this.item_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.item_combo.FormattingEnabled = true;
            this.item_combo.Location = new System.Drawing.Point(508, 122);
            this.item_combo.Name = "item_combo";
            this.item_combo.Size = new System.Drawing.Size(121, 21);
            this.item_combo.TabIndex = 1;
            // 
            // loan_itm_btn
            // 
            this.loan_itm_btn.Location = new System.Drawing.Point(554, 208);
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
            this.catagory_lbl.Location = new System.Drawing.Point(144, 130);
            this.catagory_lbl.Name = "catagory_lbl";
            this.catagory_lbl.Size = new System.Drawing.Size(49, 13);
            this.catagory_lbl.TabIndex = 3;
            this.catagory_lbl.Text = "Catagory";
            // 
            // item_lbl
            // 
            this.item_lbl.AutoSize = true;
            this.item_lbl.Location = new System.Drawing.Point(435, 130);
            this.item_lbl.Name = "item_lbl";
            this.item_lbl.Size = new System.Drawing.Size(27, 13);
            this.item_lbl.TabIndex = 4;
            this.item_lbl.Text = "Item";
            // 
            // remaining_count
            // 
            this.remaining_count.AutoSize = true;
            this.remaining_count.Location = new System.Drawing.Point(615, 20);
            this.remaining_count.Name = "remaining_count";
            this.remaining_count.Size = new System.Drawing.Size(35, 13);
            this.remaining_count.TabIndex = 5;
            this.remaining_count.Text = "label1";
            // 
            // last_date_lbl
            // 
            this.last_date_lbl.AutoSize = true;
            this.last_date_lbl.Location = new System.Drawing.Point(455, 20);
            this.last_date_lbl.Name = "last_date_lbl";
            this.last_date_lbl.Size = new System.Drawing.Size(35, 13);
            this.last_date_lbl.TabIndex = 6;
            this.last_date_lbl.Text = "label1";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(147, 60);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(59, 13);
            this.name_lbl.TabIndex = 7;
            this.name_lbl.Text = "nameLabel";
            // 
            // User_profile_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name_lbl);
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
        public System.Windows.Forms.Label name_lbl;
    }
}