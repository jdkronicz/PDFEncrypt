using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFEncrypt
{
    public class PDFEncrypt
    {
        public bool EncryptPDF(string filepath,string password)
        {
            //string filepath = path;
            string fileName = Path.GetFileNameWithoutExtension(filepath);
            string ext = Path.GetExtension(filepath);
            string path = Path.GetDirectoryName(filepath);
            //Console.WriteLine("Press any key to stop..." + args[0].ToString());
            // Console.ReadKey();
            string WorkingFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string InputFile = Path.Combine(filepath);
            string OutputFile = Path.Combine(path, fileName +"_enc"+ ext);

            using (Stream input = new FileStream(InputFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (Stream output = new FileStream(OutputFile, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfReader.unethicalreading = true;
                    PdfReader reader = new PdfReader(input);



                    PdfEncryptor.Encrypt(reader, output, true, password, null, PdfWriter.ALLOW_SCREENREADERS);
                }
            }
            // byte[] USER = Encoding.ASCII.GetBytes(password);
            // byte[] OWNER = Encoding.ASCII.GetBytes("ownerpwd");
            // PdfReader reader = new PdfReader(filepath);
            // string newfile = path + fileName + "_encrpt" + ext;
            //// reader.se = true;
            // PdfStamper stamper = new PdfStamper(reader, new FileStream(newfile, FileMode.Create));
            // stamper.SetEncryption(USER, OWNER, PdfWriter.AllowPrinting, PdfWriter.ENCRYPTION_AES_128);
            // stamper.Close();
            // reader.Close();
            // reader = null;
            if (File.Exists(filepath))
            {
                File.SetAttributes(filepath, FileAttributes.Normal);
                File.Delete(filepath);
            
            }
           
            File.Move(OutputFile, filepath);
            return true;
        }


    }
}
