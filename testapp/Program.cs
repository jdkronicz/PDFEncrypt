
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFEncrypt;
namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string filepath = "c:\\LocalTax.PDF";//args[0].ToString();
                                                      //string fileName = Path.GetFileNameWithoutExtension(filepath);
                                                      //string ext = Path.GetExtension(filepath);
                                                      //string path = Path.GetPathRoot(filepath);
                                                      ////Console.WriteLine("Press any key to stop..." + args[0].ToString());
                                                      //// Console.ReadKey();

            //byte[] USER = Encoding.ASCII.GetBytes("userpwd");
            //byte[] OWNER = Encoding.ASCII.GetBytes("ownerpwd");
            //PdfReader reader = new PdfReader(filepath);
            //string newfile = path + fileName + "_encrpt" + ext;
            //PdfStamper stamper = new PdfStamper(reader, new FileStream(newfile, FileMode.Create));
            //stamper.SetEncryption(USER, OWNER, PdfWriter.AllowPrinting, PdfWriter.ENCRYPTION_AES_128);
            //stamper.Close();

            //if (File.Exists(filepath))
            //{
            //    File.Delete(filepath);
            //}

            //File.Move(newfile, filepath);
            PDFEncrypt.PDFEncrypt pdfEncryption = new PDFEncrypt.PDFEncrypt();
            pdfEncryption.EncryptPDF(filepath, "userpwd");

        }

    }
}
