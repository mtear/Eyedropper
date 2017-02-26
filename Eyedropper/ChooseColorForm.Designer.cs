namespace Eyedropper
{
    partial class ChooseColorForm
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
            this.picboxScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxScreen
            // 
            this.picboxScreen.BackColor = System.Drawing.Color.White;
            this.picboxScreen.Location = new System.Drawing.Point(0, 0);
            this.picboxScreen.Name = "picboxScreen";
            this.picboxScreen.Size = new System.Drawing.Size(243, 217);
            this.picboxScreen.TabIndex = 0;
            this.picboxScreen.TabStop = false;
            this.picboxScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picboxScreen_MouseMove);
            this.picboxScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picboxScreen_MouseUp);
            // 
            // ChooseColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picboxScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseColorForm";
            this.Text = "ChooseColorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChooseColorForm_Load);
            this.Click += new System.EventHandler(this.ChooseColorForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picboxScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxScreen;
    }
}