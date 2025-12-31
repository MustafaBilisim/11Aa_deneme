using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dStok
{
    public partial class Yetkili : Form
    {
        public Yetkili()
        {
            InitializeComponent();
        }

        Kategoriler frmKategoriler = new Kategoriler();

        Urunler frmUrunler = new Urunler();

        Personel frmPersonel = new Personel();
        private void Yetkili_Load(object sender, EventArgs e)
        {
            frmKategoriler.TopLevel = false;
            frmKategoriler.FormBorderStyle = FormBorderStyle.None;
            frmKategoriler.Dock = DockStyle.Fill;
            tabKategoriler.Controls.Add(frmKategoriler);
            frmKategoriler.Show();




            frmUrunler.TopLevel = false;
            frmUrunler.FormBorderStyle = FormBorderStyle.None;
            frmUrunler.Dock = DockStyle.Fill;
            tabUrunler.Controls.Add(frmUrunler);
            frmUrunler.Show();



          
            frmPersonel.TopLevel = false;
            frmPersonel.FormBorderStyle = FormBorderStyle.None;
            frmPersonel.Dock = DockStyle.Fill;
            tabPersonel.Controls.Add(frmPersonel);
            frmPersonel.Show();







        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                frmKategoriler.kategorileriGoster();
            }

            if (tabControl1.SelectedIndex == 1)
            {
                frmUrunler.kategorileriGetir();
                frmUrunler.tedarikcileriGoster();
            }

            if (tabControl1.SelectedIndex == 2)
            {
                frmPersonel.yetkileriGetir();
            }





        }

        private void Yetkili_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
