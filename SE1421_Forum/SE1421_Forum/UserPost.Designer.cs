
namespace SE1421_Forum
{
    partial class UserPost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtPost = new System.Windows.Forms.RichTextBox();
            this.pnComment = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAddCmt = new System.Windows.Forms.TextBox();
            this.btnAddCmt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtPost
            // 
            this.rtPost.Location = new System.Drawing.Point(22, 17);
            this.rtPost.Name = "rtPost";
            this.rtPost.Size = new System.Drawing.Size(321, 29);
            this.rtPost.TabIndex = 0;
            this.rtPost.Text = "";
            // 
            // pnComment
            // 
            this.pnComment.AutoScroll = true;
            this.pnComment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnComment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnComment.Location = new System.Drawing.Point(22, 52);
            this.pnComment.Name = "pnComment";
            this.pnComment.Size = new System.Drawing.Size(321, 98);
            this.pnComment.TabIndex = 1;
            this.pnComment.WrapContents = false;
            // 
            // txtAddCmt
            // 
            this.txtAddCmt.Location = new System.Drawing.Point(22, 156);
            this.txtAddCmt.Name = "txtAddCmt";
            this.txtAddCmt.Size = new System.Drawing.Size(234, 22);
            this.txtAddCmt.TabIndex = 2;
            // 
            // btnAddCmt
            // 
            this.btnAddCmt.Location = new System.Drawing.Point(262, 156);
            this.btnAddCmt.Name = "btnAddCmt";
            this.btnAddCmt.Size = new System.Drawing.Size(81, 23);
            this.btnAddCmt.TabIndex = 3;
            this.btnAddCmt.Text = "Add";
            this.btnAddCmt.UseVisualStyleBackColor = true;
            this.btnAddCmt.Click += new System.EventHandler(this.btnAddCmt_Click);
            // 
            // UserPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddCmt);
            this.Controls.Add(this.txtAddCmt);
            this.Controls.Add(this.pnComment);
            this.Controls.Add(this.rtPost);
            this.Name = "UserPost";
            this.Size = new System.Drawing.Size(370, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtPost;
        private System.Windows.Forms.FlowLayoutPanel pnComment;
        private System.Windows.Forms.TextBox txtAddCmt;
        private System.Windows.Forms.Button btnAddCmt;
    }
}
