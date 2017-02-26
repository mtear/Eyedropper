using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eyedropper
{
    /// <summary>
    /// The main entry form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initialize the components
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the color to show in this form's labels
        /// </summary>
        /// <param name="color"></param>
        public void SetNewColor(Color color)
        {
            lblNewColor.BackColor = color;
            lblRed.Text = "R: " + color.R.ToString();
            lblGreen.Text = "G: " + color.G.ToString();
            lblBlue.Text = "B: " + color.B.ToString();
            lblHex.Text = EyedropperUtil.HexConverter(color);
            this.Height = 215;
            Show();
        }

        /// <summary>
        /// Show the color selection form.
        /// </summary>
        /// <param name="sender">Who sent the event</param>
        /// <param name="e">Event arguments</param>
        private void btnNewColor_Click(object sender, EventArgs e)
        {
            Hide();
            System.Threading.Thread.Sleep(500);
            new ChooseColorForm(EyedropperUtil.GetScreenshot(), this).Show();
        }

    }
}
