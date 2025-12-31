using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dStok
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=LAB;Initial Catalog=dStok;User ID=sa;Password=123456;");
      

        
        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from personeller where kullanici_adi='"+txtKullaniciAdi.Text+"' and sifre='"+txtSifre.Text+"'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();

            if(dt.Rows.Count>0)
            {

                string yetkiID = dt.Rows[0]["yetki_id"].ToString();
                string ad = dt.Rows[0]["ad"].ToString();
                string soyad = dt.Rows[0]["soyad"].ToString();


                if (yetkiID == "1")
                {
                    Yetkili frmYetkili = new Yetkili();
                    frmYetkili.Show();
                    this.Hide();
                }

                else
                {

                    MessageBox.Show("Giriş yetkiniz bulunmamaktadır...");
                }

            }

            else
            {
                MessageBox.Show("Sistemde kayıtlı değilsiniz");
            }
           


            

        }
    }
}
