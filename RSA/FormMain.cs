using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            int i = rsa.Encrypt(6);
            int j = rsa.Decrypt(i);
        }
    }
}
