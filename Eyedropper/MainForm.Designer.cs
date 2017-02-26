namespace Eyedropper
{
    partial class MainForm
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
            this.btnNewColor = new System.Windows.Forms.Button();
            this.lblNewColor = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewColor
            // 
            this.btnNewColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewColor.Location = new System.Drawing.Point(16, 12);
            this.btnNewColor.Name = "btnNewColor";
            this.btnNewColor.Size = new System.Drawing.Size(152, 45);
            this.btnNewColor.TabIndex = 0;
            this.btnNewColor.Text = "New Color";
            this.btnNewColor.UseVisualStyleBackColor = true;
            this.btnNewColor.Click += new System.EventHandler(this.btnNewColor_Click);
            // 
            // lblNewColor
            // 
            this.lblNewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewColor.Location = new System.Drawing.Point(40, 70);
            this.lblNewColor.Name = "lblNewColor";
            this.lblNewColor.Size = new System.Drawing.Size(107, 36);
            this.lblNewColor.TabIndex = 1;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(13, 118);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(45, 16);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "label1";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(13, 134);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(45, 16);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Text = "label1";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(13, 150);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(45, 16);
            this.lblBlue.TabIndex = 4;
            this.lblBlue.Text = "label2";
            // 
            // lblHex
            // 
            this.lblHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHex.Location = new System.Drawing.Point(79, 134);
            this.lblHex.Name = "lblHex";
            this.lblHex.ReadOnly = true;
            this.lblHex.Size = new System.Drawing.Size(89, 19);
            this.lblHex.TabIndex = 5;
            this.lblHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 64);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblNewColor);
            this.Controls.Add(this.btnNewColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Eyedropper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewColor;
        private System.Windows.Forms.Label lblNewColor;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TextBox lblHex;
    }
}

