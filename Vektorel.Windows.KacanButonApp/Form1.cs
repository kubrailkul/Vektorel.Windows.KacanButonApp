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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Size = new Size(100, 20);
            btn.Text = "Bizim Buton";
            btn.Click += BizimButonClick; //metotla click ilişkilendirmesi
            this.Controls.Add(btn);
            
        }

        void BizimButonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");


        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton 2 clicklendi.");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            //button1.Text
            MessageBox.Show($"{buton.Text} clicklendi.");


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton 3 clicklendi.");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X:{e.X.ToString()} Y:{e.Y.ToString()}";
        }
    }
}
