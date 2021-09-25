
namespace Draw_on_Form
{
    partial class DrawCircle
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
            this.components = new System.ComponentModel.Container();
            this.timermove = new System.Windows.Forms.Timer(this.components);
            this.timerReturn = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timermove
            // 
            this.timermove.Enabled = true;
            this.timermove.Tick += new System.EventHandler(this.timermove_Tick);
            // 
            // DrawCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 268);
            this.Name = "DrawCircle";
            this.Text = "DrawCircle";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCircle_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timermove;
        private System.Windows.Forms.Timer timerReturn;
    }
}