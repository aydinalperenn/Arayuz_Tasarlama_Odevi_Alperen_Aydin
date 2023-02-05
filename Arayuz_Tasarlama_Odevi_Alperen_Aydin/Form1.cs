using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arayuz_Tasarlama_Odevi_Alperen_Aydin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox_temizle()
        {
            textBox1.Clear();
            txtStreet.Clear();
            txtState.Clear();
            txtZip.Clear();

            textBox1.Focus();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

            StringBuilder queryadresss = new StringBuilder();
            queryadresss.Append("https://www.google.com/maps?q=");
            queryadresss.Append("Gazi Üniversitesi" + "," + "+");
            webBrowser1.Navigate(queryadresss.ToString());
            queryadresss.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = txtStreet.Text;
            string city = textBox1.Text;
            string state = txtState.Text;
            string zip = txtZip.Text;

            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("https://www.google.com/maps?q=");

                if (street != string.Empty)
                {
                    queryadress.Append(street + "," + "+");
                }

                if (city != string.Empty)
                {
                    queryadress.Append(city + "," + "+");
                }

                if (state != string.Empty)
                {
                    queryadress.Append(state + "," + "+");
                }

                if (zip != string.Empty)
                {
                    queryadress.Append(zip + "," + "+");
                }

                webBrowser1.Navigate(queryadress.ToString());
                textbox_temizle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
