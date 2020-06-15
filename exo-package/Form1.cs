using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace exo_package
{
  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            string content = tbQrCode.Text;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(100, "#663084", "#ffffff");
            pictureBox1.Image = qrCodeImage;
        }
    }
}
