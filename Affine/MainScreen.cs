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
    public partial class MainScreen : Form
    {
        string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public MainScreen()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            string text = originText.Text;
            int a = 0;
            int b = 0;
            if (aKey.Text == "" || bKey.Text == "")
            {
                if (aKey.Text == "")
                    a = 3;
                if (bKey.Text == "")
                    b = 4;
            }
            else
            {
                a = Convert.ToInt32(aKey.Text);
                b = Convert.ToInt32(bKey.Text);
            }
            int x = 0, encryptedIndex = 0;
            string encryptedMessage = "";
            text = text.ToUpper();
            for (int i = 0; i < text.Length; i++)
            {
                string temp = text.Substring(i, 1);
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (temp == alphabet[j])
                        break;
                    else
                        x++;
                }
                if (temp == " ")
                {
                    encryptedMessage += " ";
                    x = 0;
                }
                else if (char.Parse(temp) >= 49 && char.Parse(temp) <= 57)
                {
                    encryptedMessage += temp;
                    x = 0;
                }
                else
                {
                    encryptedIndex = (a * x + b) % alphabet.Length;
                    x = 0;
                    encryptedMessage += alphabet[encryptedIndex];
                }
            }

            encodeText.Text = encryptedMessage;
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            string text = encodeText.Text;
            int a = 0;
            int b = 0;
            if (aKey.Text == "" || bKey.Text == "")
            {
                if (aKey.Text == "")
                    a = 3;
                if (bKey.Text == "")
                    b = 4;
            }
            else
            {
                a = Convert.ToInt32(aKey.Text);
                b = Convert.ToInt32(bKey.Text);
            }
            int x = 0, decryptedIndex = 0;
            int matrix = 0;
            string decryptedMessage = "";
            text = text.ToUpper();
            for (int i = 0; i < text.Length; i++)
            {
                string temp = text.Substring(i, 1);
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (temp == alphabet[j])
                        break;
                    else
                        x++;
                }
                if (temp == " ")
                {
                    decryptedMessage += " ";
                    x = 0;
                }
                else if (char.Parse(temp) >= 48 && char.Parse(temp) <= 57)
                {
                    decryptedMessage += temp;
                    x = 0;
                }
                else
                {
                    for (int mod = 1; mod < 27; mod++)
                    {
                        if ((a * mod) % alphabet.Length == 1)
                        {
                            matrix = mod;
                            break;
                        }
                    }
                    if (matrix != 0)
                    {
                        if (x - b < 0)
                            x += 26;
                        decryptedIndex = (matrix * (x - b)) % alphabet.Length;
                        decryptedMessage += alphabet[decryptedIndex];
                        x = 0;
                    }
                    else if (matrix == 0)
                    {
                        MessageBox.Show("A должно быть нечётным числом.");
                        break;
                    }
                }
            }

            originText.Text = decryptedMessage;
        }
    }
}
