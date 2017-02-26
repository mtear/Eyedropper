using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eyedropper
{
    /// <summary>
    /// The form that lets the user select a color from the screen
    /// </summary>
    public partial class ChooseColorForm : Form
    {
        /// <summary>
        /// The bitmap representing the true screenshot data (not slightly transparent)
        /// </summary>
        Bitmap trueScreenData;

        /// <summary>
        /// A reference to the main form to return to
        /// </summary>
        MainForm mainForm;

        /// <summary>
        /// A reference to the preview form for colors
        /// </summary>
        PreviewForm previewForm;

        /// <summary>
        /// Constructor. Initializes components and sets member variables.
        /// </summary>
        /// <param name="trueScreenData"></param>
        /// <param name="mainForm"></param>
        public ChooseColorForm(Bitmap trueScreenData, MainForm mainForm)
        {
            InitializeComponent();
            this.trueScreenData = trueScreenData;
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Size the picturebox to the entire form and show the preview dialog on load
        /// </summary>
        /// <param name="sender">Who sent the event</param>
        /// <param name="e">Event arguments</param>
        private void ChooseColorForm_Load(object sender, EventArgs e)
        {
            //Resize picture box
            picboxScreen.Width = this.Width;
            picboxScreen.Height = this.Height;

            //Get the screen and put into picture box
            picboxScreen.Image = EyedropperUtil.SetImageOpacity(trueScreenData, 0.75f);

            //Start preview form
            previewForm = new PreviewForm();
            previewForm.Show();
        }

        /// <summary>
        /// Close the program if the form is somehow clicked on
        /// </summary>
        /// <param name="sender">Who sent the event</param>
        /// <param name="e">Event arguments</param>
        private void ChooseColorForm_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Select the color and send it to the main form
        /// </summary>
        /// <param name="sender">Who sent the event</param>
        /// <param name="e">Event arguments</param>
        private void picboxScreen_MouseUp(object sender, MouseEventArgs e)
        {
            Color color = trueScreenData.GetPixel(e.X, e.Y);
            mainForm.SetNewColor(color);
            previewForm.Close();
            this.Close();
        }

        /// <summary>
        /// Change the position and color of the preview dialog on mouse move
        /// </summary>
        /// <param name="sender">Who sent the event</param>
        /// <param name="e">Event arguments</param>
        private void picboxScreen_MouseMove(object sender, MouseEventArgs e)
        {
            previewForm.SetColor(trueScreenData.GetPixel(e.X, e.Y));
            SetPreviewPosition(e.X, e.Y);
        }

        /// <summary>
        /// Change the position of the preview dialog
        /// </summary>
        /// <param name="mouseX">Who sent the event</param>
        /// <param name="mouseY">Event arguments</param>
        private void SetPreviewPosition(int mouseX, int mouseY)
        {
            previewForm.Location = new Point(mouseX - previewForm.Width - 30,
                mouseY - previewForm.Height);
            previewForm.BringToFront();
        }
    }
}
