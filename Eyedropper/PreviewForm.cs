using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eyedropper
{
    /// <summary>
    /// A form that previews the color as you move the mouse around
    /// </summary>
    public partial class PreviewForm : Form
    {
        /// <summary>
        /// Initialize the components
        /// </summary>
        public PreviewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the color of this preview box
        /// </summary>
        /// <param name="color">The color to set this to</param>
        public void SetColor(Color color)
        {
            this.BackColor = color;
            lblColor.BackColor = color;
        }

        /// <summary>
        /// What happens on load for this form.
        /// Sets the color label to be the full size of the form.
        /// </summary>
        /// <param name="sender">Who sent the event</param>
        /// <param name="e">Event arguments</param>
        private void PreviewForm_Load(object sender, EventArgs e)
        {
            lblColor.Location = new Point(0, 0);
            lblColor.Width = this.Width;
            lblColor.Height = this.Height;
        }
    }
}
