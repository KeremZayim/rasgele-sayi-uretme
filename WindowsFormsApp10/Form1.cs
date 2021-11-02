using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        Random rndm = new Random();
        int baslangic = 0, bitis = 0, adet = 0, rastgeleSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            baslangic = Convert.ToInt32(TBBaslangic.Text);
            bitis = Convert.ToInt32(tbBitis.Text);
            adet = Convert.ToInt32(tBAdet.Text);

            for (int i = adet; i < adet + adet; i++)
            {
                rastgeleSayi = rndm.Next(baslangic, bitis);

                if (LBDegisken.Items.Contains(rastgeleSayi))
                {
                    bool kontrol = true;
                    for (;kontrol;)
                    {
                        rastgeleSayi = rndm.Next(baslangic, bitis);
                        if (!LBDegisken.Items.Contains(rastgeleSayi))
                        {
                            LBDegisken.Items.Add(rastgeleSayi);
                            kontrol = false;
                        }
                    }
                    LBDegisken.Sorted = true;
                }
                else
                {
                    LBDegisken.Items.Add(rastgeleSayi);
                    LBDegisken.Sorted = true;
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            LBDegisken.Items.Clear();
        }
    }
}
