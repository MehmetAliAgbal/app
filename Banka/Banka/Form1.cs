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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-I38QQJVP;Initial Catalog=DbBanka;Integrated Security=True");

        private void lnkkayitol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKISILER Where HESAPNO=@p1 and SIFRE=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Form2 frm = new Form2();
                frm.hesapno = mskhesapno.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş.");
            }
        }
    }
}
