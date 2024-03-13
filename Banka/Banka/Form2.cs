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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-I38QQJVP;Initial Catalog=DbBanka;Integrated Security=True");

        public string hesapno;

        private void Form2_Load(object sender, EventArgs e)
        {
            lblhesapno.Text = hesapno;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKISILER where HESAPNO=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", lblhesapno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1] + " " + dr[2];
                lbltc.Text = dr[3].ToString();
                lblnumara.Text = dr[4].ToString();
                lblhesapno.Text = dr[5].ToString();
            }
            baglanti.Close();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1",decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p2",mskhesapno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(txttutar.Text));
            komut2.Parameters.AddWithValue("@k2",lblhesapno.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET (GONDEREN,ALICI,TUTAR) values (@m1,@m2,@m3)", baglanti);
            komut3.Parameters.AddWithValue("@m1", lblhesapno.Text);
            komut3.Parameters.AddWithValue("@m2",mskhesapno.Text);
            komut3.Parameters.AddWithValue("@m3", decimal.Parse(txttutar.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para aktarma işlemi gerçekleştirildi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.hspno = lblhesapno.Text;
            frm.Show();
        }
    }
}
