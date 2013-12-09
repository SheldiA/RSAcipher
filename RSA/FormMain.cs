using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace RSA
{
    public partial class FormMain : Form
    {
        private readonly int maxPrimeNumber = 256;
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

        private int GetSumElements(byte[] arr, byte begin, byte offset)
        {
            int result = 0;

            for (int i = begin; i < arr.Length; i += offset)
                result += arr[i];
            return result % maxPrimeNumber;
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            FileStream sr = new FileStream(tb_messageFile.Text,FileMode.Open);
            FileStream sw = new FileStream(tb_cipherFile.Text,FileMode.Create);
            byte[] hashArray = GetBytePassword(tb_key.Text);
            RSA rsa = null;
            //RSA rsa = new RSA(GetSumElements(hashArray,0,2),GetSumElements(hashArray,1,2),false);
            if (rb_encrypt.Checked)
            {
                rsa = new RSA(GetSumElements(hashArray, 0, 2), GetSumElements(hashArray, 1, 2), false,maxPrimeNumber);
                for (int i = 0; i < sr.Length; ++i )
                {
                    int messageByte = sr.ReadByte();
                    int cipherByte = rsa.Encrypt(messageByte);
                    WriteTwoByte(sw, cipherByte);
                }
            }
            if(rb_decrypt.Checked)
            {
                rsa = new RSA(GetSumElements(hashArray, 0, 2), GetSumElements(hashArray, 1, 2), false,maxPrimeNumber);
                for (int i = 0; i < sr.Length / 2; ++i)
                {
                    int cipherByte = GetIntFromTwoByte((byte)sr.ReadByte(), (byte)sr.ReadByte());
                    sw.WriteByte((byte)rsa.Decrypt(cipherByte));
                }
            }

            if (rb_breaking.Checked)
            {
                rsa = new RSA(GetSumElements(hashArray, 0, 2), GetSumElements(hashArray, 1, 2), true,maxPrimeNumber);
                for (int i = 0; i < sr.Length / 2; ++i)
                {
                    int cipherByte = GetIntFromTwoByte((byte)sr.ReadByte(), (byte)sr.ReadByte());
                    sw.WriteByte((byte)rsa.Breaking(Int32.Parse(tb_r.Text),Int32.Parse(tb_publicKey.Text),cipherByte));
                }
            }
            sr.Close();
            sw.Close();
            lb_p.Text = "p = " + rsa.p;
            lb_q.Text = "q = " + rsa.q;
            lb_publicKey.Text = "public key = " + rsa.publicKey;
            lb_privateKey.Text = "private key = " + rsa.privateKey;
        }

        private byte[] GetBytePassword(string initial_string)
        {
            MD5 md5hash = MD5.Create();
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(initial_string));
            return data;
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
