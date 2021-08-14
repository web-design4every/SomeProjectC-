
namespace SE1421_Forum
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
            this.txtPost = new System.Windows.Forms.TextBox();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.pnPost = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(12, 12);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(347, 22);
            this.txtPost.TabIndex = 0;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(375, 11);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(75, 23);
            this.btnAddPost.TabIndex = 1;
            this.btnAddPost.Text = "Post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // pnPost
            // 
            this.pnPost.AutoScroll = true;
            this.pnPost.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnPost.Location = new System.Drawing.Point(13, 51);
            this.pnPost.Name = "pnPost";
            this.pnPost.Size = new System.Drawing.Size(437, 469);
            this.pnPost.TabIndex = 2;
            this.pnPost.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 532);
            this.Controls.Add(this.pnPost);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.txtPost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.FlowLayoutPanel pnPost;
    }
}

