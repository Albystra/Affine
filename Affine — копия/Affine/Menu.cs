using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Encrypt encrypt = new Encrypt();
            encrypt.Show();
        }

        private void dec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Decrypt decrypt = new Decrypt();
            decrypt.Show();
        }
    }
}
