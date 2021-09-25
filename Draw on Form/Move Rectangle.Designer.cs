
namespace Draw_on_Form
{
    partial class Move_Rectangle
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
            this.SuspendLayout();
            // 
            // Move_Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 261);
            this.Name = "Move_Rectangle";
            this.Text = "Move_Rectangle";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Move_Rectangle_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Rectangle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_Rectangle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_Rectangle_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}