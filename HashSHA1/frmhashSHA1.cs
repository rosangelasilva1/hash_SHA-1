using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HashSHA1
{
    public partial class frmhashSHA1 : Form
    {
        public frmhashSHA1()
        {
            InitializeComponent();
        }

        private void btnHashSHA1_Click(object sender, EventArgs e)
        {
            txthashSHA1.Text = getHashSHA1(txtpassword.Text);
        }

        public string getHashSHA1(string  text) {

            using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
            {
                sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
                byte[] varhash = sha1.Hash;
                StringBuilder sb = new StringBuilder();

                foreach (byte b in varhash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString(); 
            }
               
        }

    }
}
