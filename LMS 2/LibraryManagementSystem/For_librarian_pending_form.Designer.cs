namespace LibraryManagementSystem
{
    partial class For_librarian_pending_form
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
            this.pending_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pending_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // pending_gridview
            // 
            this.pending_gridview.AllowUserToOrderColumns = true;
            this.pending_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pending_gridview.Location = new System.Drawing.Point(12, 14);
            this.pending_gridview.Name = "pending_gridview";
            this.pending_gridview.Size = new System.Drawing.Size(602, 424);
            this.pending_gridview.TabIndex = 0;
            // 
            // For_librarian_pending_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pending_gridview);
            this.Name = "For_librarian_pending_form";
            this.Text = "For_librarian_pending_form";
            this.Load += new System.EventHandler(this.For_librarian_pending_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pending_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pending_gridview;
    }
}