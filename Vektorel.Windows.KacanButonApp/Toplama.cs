using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.KacanButonApp
{
    public partial class Toplama : Form
    {

        byte toplam = 0;
        public Toplama()
        {
            InitializeComponent();
        }

        private void Toplama_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            //btnSayi1.Text = random.Next(5, 29).ToString();
            //btnSayi2.Text = random.Next(5, 29).ToString();
            //btnSayi3.Text = random.Next(3, 10).ToString();
            //foreach (Control item in this.Controls)
            //{
            //    if (item is Button && item.Tag.ToString() == "0")

            //    {
            //        item.Text = random.Next(10, 50).ToString();
            //    }


            foreach (Control item in this.Controls["groupBox1"].Controls)
            {
                item.Text = random.Next(10, 100).ToString();

            }

        }


            //private void BtnSayi1_Click(object sender, EventArgs e)
            //{

            //    toplam += byte.Parse(btnSayi1.Text);
            //}

            //private void BtnSayi2_Click(object sender, EventArgs e)
            //{
            //    toplam += byte.Parse(btnSayi2.Text);
            //}

            //private void BtnSayi3_Click(object sender, EventArgs e)
            //{
            //    toplam += byte.Parse(btnSayi3.Text);
            //}


            private void BtnSayi_Click(object sender, EventArgs e)
            {
                Button buton = (Button)sender;
                toplam += byte.Parse(buton.Text);
                //buton.Visible = false;
                buton.Enabled = false;
            }


            private void BtnTopla_Click(object sender, EventArgs e)
            {
                MessageBox.Show(toplam.ToString());
                toplam = 0;
            }

        }
    }

