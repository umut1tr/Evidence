using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Evidence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void btnAufnahme_Click(object sender, EventArgs e)
        {
            captureImage();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pic.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboKamera.Items.Add(filterInfo.Name);
            cboKamera.SelectedIndex = 1; // Selects the first listed connected camera in the list
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboKamera.SelectedIndex].MonikerString); // Initialises camera with selected camera
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame; // Puts camera feed into display box
            videoCaptureDevice.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        public void captureImage()
        {
            Debug.WriteLine("Capture Image Called!!!");
            // Capture the image here
            if (pic.Image != null)
            {
                string clipboardText = Clipboard.GetText(); // Gets the text from the clipboard
                Bitmap varBmp = (Bitmap)pic.Image.Clone(); // Creates the bitmap image from whatever is shown in the video box
                string filepath = @"C:\Users\ivanw\Desktop";
                string fileName = System.IO.Path.Combine(filepath, clipboardText) + @".png";
                varBmp.Save(fileName, ImageFormat.Png);
                varBmp.Dispose();
            }
            else
            { MessageBox.Show("Unable to capture the image! Check your webcam is dispalying in the box."); }
        }
    }
}
