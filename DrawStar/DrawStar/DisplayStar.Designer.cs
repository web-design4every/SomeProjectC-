
namespace DrawStar
{
    partial class DisplayStar
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
            this.SuspendLayout();
            // 
            // DisplayStar
            // 
            this.Name = "DisplayStar";
            this.Size = new System.Drawing.Size(646, 252);
            this.Load += new System.EventHandler(this.DisplayStar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayStar_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayStar_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
