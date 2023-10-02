using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double alisfiyat, satisfiyat, karfiyat;
            alisfiyat=Convert.ToDouble(txtAlisfFiyat.Text);
            satisfiyat=Convert.ToDouble(txtSatisFiyat.Text);
            karfiyat = satisfiyat - alisfiyat;
            lblKarFiyat.Text = "Kar Fiyatı: " + karfiyat;
        }
    }
}
