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
    public partial class frmOyun : Form
    {
        int puan = 0;
        public frmOyun()
        {
            InitializeComponent();
        }


        private void BtnKac_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();

            btnKac.Location = new Point(random.Next(this.ClientSize.Width - btnKac.Width), random.Next(this.ClientSize.Height - btnKac.Height));

            puan++;
            btnKac.Text = puan.ToString();

            if (puan % 10 == 0)
            {
                Random rnd = new Random();
                int x = rnd.Next(255);
                int y = rnd.Next(255);
                int z = rnd.Next(255);

                int a = rnd.Next(255);
                int b = rnd.Next(255);
                int c = rnd.Next(255);

                this.ClientSize = new System.Drawing.Size(this.Width + 10, this.Height + 3);
                this.BackColor = Color.FromArgb(x,y,z);


                btnKac.BackColor = Color.FromArgb(a,b,c);


            }


        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            btnKac.Text = "0";
        }
    }

}
