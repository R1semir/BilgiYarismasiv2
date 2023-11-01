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
namespace Oyuınlar
{


    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BJO2DGU\\SQLEXPRESS;Initial Catalog=Sorularim;Integrated Security=True");

        int soru = 0;
        int puan = 0;
        int sure = 21;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sure = 21;
            btnA.BackColor = Color.Gray;
            btnB.BackColor = Color.Gray;
            btnC.BackColor = Color.Gray;
            btnD.BackColor = Color.Gray;
            btnBasla.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnBasla.Text = "İleri";
            soru++;
            lblsoru.Text = soru.ToString();
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select * from Soru1 order by NEWID()", baglan);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                btnA.Text = (dr1["a"].ToString());
                btnB.Text = (dr1["b"].ToString());
                btnC.Text = (dr1["c"].ToString());
                btnD.Text = (dr1["d"].ToString());
                txtSoru.Text = (dr1["Soru"].ToString());
                lblDogru.Text = (dr1["dogru"].ToString());
            }
            baglan.Close();
            if (soru == 2)
            {
                baglan.Open();
                SqlCommand komut2 = new SqlCommand("select * from Soru2 order by NEWID()", baglan);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    btnA.Text = (dr2["a"].ToString());
                    btnB.Text = (dr2["b"].ToString());
                    btnC.Text = (dr2["c"].ToString());
                    btnD.Text = (dr2["d"].ToString());
                    txtSoru.Text = (dr2["Soru"].ToString());
                    lblDogru.Text = (dr2["dogru"].ToString());

                }
                baglan.Close();
            }
            if (soru == 3)
            {
                baglan.Open();
                SqlCommand komut3 = new SqlCommand("select * from Soru3 order by NEWID()", baglan);
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    btnA.Text = (dr3["a"].ToString());
                    btnB.Text = (dr3["b"].ToString());
                    btnC.Text = (dr3["c"].ToString());
                    btnD.Text = (dr3["d"].ToString());
                    txtSoru.Text = (dr3["Soru"].ToString());
                    lblDogru.Text = (dr3["dogru"].ToString());

                }
                baglan.Close();
            }
            if (soru == 4)
            {
                baglan.Open();
                SqlCommand komut4 = new SqlCommand("select * from Soru4 order by NEWID()", baglan);
                SqlDataReader dr4 = komut4.ExecuteReader();
                while (dr4.Read())
                {
                    btnA.Text = (dr4["a"].ToString());
                    btnB.Text = (dr4["b"].ToString());
                    btnC.Text = (dr4["c"].ToString());
                    btnD.Text = (dr4["d"].ToString());
                    txtSoru.Text = (dr4["Soru"].ToString());
                    lblDogru.Text = (dr4["dogru"].ToString());

                }
                baglan.Close();
            }
            if (soru == 5)
            {
                baglan.Open();
                SqlCommand komut5 = new SqlCommand("select * from Soru5 order by NEWID()", baglan);
                SqlDataReader dr5 = komut5.ExecuteReader();
                while (dr5.Read())
                {
                    btnA.Text = (dr5["a"].ToString());
                    btnB.Text = (dr5["b"].ToString());
                    btnC.Text = (dr5["c"].ToString());
                    btnD.Text = (dr5["d"].ToString());
                    txtSoru.Text = (dr5["Soru"].ToString());
                    lblDogru.Text = (dr5["dogru"].ToString());

                }
                baglan.Close();
            }
            if (soru == 6)
            {
                baglan.Open();
                SqlCommand komut6 = new SqlCommand("select * from Soru6 order by NEWID()", baglan);
                SqlDataReader dr6 = komut6.ExecuteReader();
                while (dr6.Read())
                {
                    btnA.Text = (dr6["a"].ToString());
                    btnB.Text = (dr6["b"].ToString());
                    btnC.Text = (dr6["c"].ToString());
                    btnD.Text = (dr6["d"].ToString());
                    txtSoru.Text = (dr6["Soru"].ToString());
                    lblDogru.Text = (dr6["dogru"].ToString());

                }
                baglan.Close();
            }
            if (soru == 7)
            {
                btnBasla.Text = "Oyun Bitti";
                baglan.Open();
                SqlCommand komut7 = new SqlCommand("select * from Soru7 order by NEWID()", baglan);
                SqlDataReader dr7 = komut7.ExecuteReader();
                while (dr7.Read())
                {
                    btnA.Text = (dr7["a"].ToString());
                    btnB.Text = (dr7["b"].ToString());
                    btnC.Text = (dr7["c"].ToString());
                    btnD.Text = (dr7["d"].ToString());
                    txtSoru.Text = (dr7["Soru"].ToString());
                    lblDogru.Text = (dr7["dogru"].ToString());

                }
                baglan.Close();
            }
            if (soru == 8)
            {
                btnBasla.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                timer1.Enabled = false;
                txtSoru.Clear();
            }



        }
        private void lblsoru_Click(object sender, EventArgs e)
        {
            lblsoru.Text = soru.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.BackColor = Color.Gray;
            btnA.BackColor = Color.Gray;
            btnB.BackColor = Color.Gray;
            btnC.BackColor = Color.Gray;
            btnD.BackColor = Color.Gray;
            lblDogru.Visible = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.Enabled = true;
            if (btnA.Text == lblDogru.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnA.BackColor = Color.Green;
            }
            else
            {
                btnA.BackColor = Color.Red;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.Enabled = true;
            if (btnB.Text == lblDogru.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnB.BackColor = Color.Green;
            }
            else
            {
                btnB.BackColor = Color.Red;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.Enabled = true;
            if (btnC.Text == lblDogru.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnC.BackColor = Color.Green;
            }
            else
            {
                btnC.BackColor = Color.Red;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.Enabled = true;
            if (btnD.Text == lblDogru.Text)
            {
                puan = puan + 10;
                lblPuan.Text = puan.ToString();
                btnD.BackColor = Color.Green;
            }
            else
            {
                btnD.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure - 1;
            lblSüre.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnBasla.Enabled = true;
            }
        }
    }
}

