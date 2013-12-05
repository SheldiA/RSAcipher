using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RSA
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void WriteTwoByte(FileStream fs,int twoByte)
        {
            string bytes = Convert.ToString(twoByte,2);
            while (bytes.Length < 16)
                bytes = "0" + bytes;
            string firstByte = bytes.Substring(0,8);
            string secondByte = bytes.Substring(8);
            fs.WriteByte(Convert.ToByte(firstByte,2));
            fs.WriteByte(Convert.ToByte(secondByte, 2));
        }

        private int GetIntFromTwoByte(byte firstByte, byte secondByte)
        {
            int result = 0;

            string bytes = Convert.ToString(firstByte, 2);
            while (bytes.Length < 8)
                bytes = "0" + bytes;
            string byte2 = Convert.ToString(secondByte,2);
            while (byte2.Length < 8)
                byte2 = "0" + byte2;
            bytes += byte2;
            result = Convert.ToInt16(bytes,2);

            return result;
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            /*FileStream sr = new FileStream(tb_messageFile.Text,FileMode.Open);
            FileStream sw = new FileStream(tb_cipherFile.Text,FileMode.Create);
            RSA rsa = new RSA();
            if (rb_encrypt.Checked)
            {
                for (int i = 0; i < sr.Length; ++i )
                {
                    int messageByte = sr.ReadByte();
                    int cipherByte = rsa.Encrypt(messageByte);
                    WriteTwoByte(sw, cipherByte);
                }
            }
            else
            {
                for (int i = 0; i < sr.Length / 2; ++i)
                {
                    int cipherByte = GetIntFromTwoByte((byte)sr.ReadByte(), (byte)sr.ReadByte());
                    sw.WriteByte((byte)rsa.Decrypt(cipherByte));
                }
            }
            sr.Close();
            sw.Close();*/
            Generator generator = new Generator();
            generator.GeneratePrimeIntegers(101);
        }

        private void bt_openMessage_Click(object sender, EventArgs e)
        {
            if ((openFileDialog1.ShowDialog() == DialogResult.OK) && (openFileDialog1.FileName.Length > 0))
                tb_messageFile.Text = openFileDialog1.FileName;
        }

        private void bt_openCipher_Click(object sender, EventArgs e)
        {
            if ((saveFileDialog1.ShowDialog() == DialogResult.OK) && (saveFileDialog1.FileName.Length > 0))
                tb_cipherFile.Text = saveFileDialog1.FileName;
        }
    }
}
