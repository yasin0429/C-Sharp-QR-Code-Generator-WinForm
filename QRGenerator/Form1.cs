using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qrGen = new QRCoder.QRCodeGenerator();
            var data = qrGen.CreateQrCode(dataTxt.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(data);
            pictureBox1.Image = code.GetGraphic(50);

        }
    }
}
