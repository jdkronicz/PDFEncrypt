using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PDFEncrpt : Form
    {
        public PDFEncrpt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDFEncrypt.PDFEncrypt ass = new PDFEncrypt.PDFEncrypt();
            ass.EncryptPDF("c:\\Users\\JD_DCS_1\\Documents\\Chemical solutions\\test Directories\\Temp\\W18A00510003.pdf", "test");

        }
    }
}
