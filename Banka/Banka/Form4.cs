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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-I38QQJVP;Initial Catalog=DbBanka;Integrated Security=True");

        public string hspno;

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select AD + ' ' + SOYAD as 'ALICI',TUTAR From TBLHAREKET inner join TBLKISILER on TBLKISILER.HESAPNO=TBLHAREKET.ALICI Where GONDEREN=" + hspno,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataAdapter da2 = new SqlDataAdapter("Select AD + ' ' + SOYAD as 'GONDEREN',TUTAR From TBLHAREKET inner join TBLKISILER on TBLKISILER.HESAPNO=TBLHAREKET.GONDEREN Where ALICI=" + hspno, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
    }
}
