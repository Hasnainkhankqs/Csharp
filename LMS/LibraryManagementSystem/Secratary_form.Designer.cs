namespace LibraryManagementSystem
{
    partial class Secratary_form
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
            this.Category_combo = new System.Windows.Forms.ComboBox();
            this.item_name_txt = new System.Windows.Forms.TextBox();
            this.insert_item_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Category_combo
            // 
            this.Category_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_combo.FormattingEnabled = true;
            this.Category_combo.Location = new System.Drawing.Point(523, 61);
            this.Category_combo.Name = "Category_combo";
            this.Category_combo.Size = new System.Drawing.Size(121, 21);
            this.Category_combo.TabIndex = 0;
            // 
            // item_name_txt
            // 
            this.item_name_txt.Location = new System.Drawing.Point(544, 121);
            this.item_name_txt.Name = "item_name_txt";
            this.item_name_txt.Size = new System.Drawing.Size(100, 20);
            this.item_name_txt.TabIndex = 1;
            // 
            // insert_item_btn
            // 
            this.insert_item_btn.Location = new System.Drawing.Point(569, 182);
            this.insert_item_btn.Name = "insert_item_btn";
            this.insert_item_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_item_btn.TabIndex = 2;
            this.insert_item_btn.Text = "button1";
            this.insert_item_btn.UseVisualStyleBackColor = true;
            this.insert_item_btn.Click += new System.EventHandler(this.Insert_item_btn_Click);
            // 
            // Secratary_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insert_item_btn);
            this.Controls.Add(this.item_name_txt);
            this.Controls.Add(this.Category_combo);
            this.Name = "Secratary_form";
            this.Text = "Secratary_form";
            this.Load += new System.EventHandler(this.Secratary_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Category_combo;
        private System.Windows.Forms.TextBox item_name_txt;
        private System.Windows.Forms.Button insert_item_btn;
    }
}