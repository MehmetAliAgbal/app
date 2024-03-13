using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-I38QQJVP;Initial Catalog=DbBanka;Integrated Security=True");

        public void hesapno()
        {
            Random rastgele = new Random();
            int hspno = rastgele.Next(100000, 1000000);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int hspno = rastgele.Next(100000, 1000000);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLHESAP",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (hspno == int.Parse(dr[0].ToString()))
                {
                    hspno = rastgele.Next(100000, 1000000);
                    mskhesapno.Text=hspno.ToString();
                }
                else
                {
                    mskhesapno.Text = hspno.ToString();
                }
            }
            baglanti.Close();
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3",msktc.Text);
            komut.Parameters.AddWithValue("@p4",msktelefon.Text);
            komut.Parameters.AddWithValue("@p5",mskhesapno.Text);
            komut.Parameters.AddWithValue("@p6",txtsifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt sisteme eklendi.");
        }
    }
}
