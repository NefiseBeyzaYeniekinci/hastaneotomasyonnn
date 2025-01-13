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

namespace hastaneotomasyonnn
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        public string TCnumara;
        public string secilen;
        sqlbaglantisi bgl = new sqlbaglantisi();


        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text=TCnumara;
            Txtid.Text = secilen;


            //AdSoyad

            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();


            //BranslarıDataGrideAktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //DoktorlarıListeyeAktarma

            SqlCommand cmd = new SqlCommand("SELECT DoktorAd + ' ' + DoktorSoyad AS 'Doktorlar', DoktorBrans FROM Tbl_Doktorlar", bgl.baglanti());
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //BransıCmbBoxAktarma

            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
                komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
                komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
                komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu Oluşturuldu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu kaydedilirken hata oluştu: " + ex.Message);
            }
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CmbDoktor.Items.Clear();
                using (SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar Where DoktorBrans = @p1", bgl.baglanti()))
                {
                    komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
                        }
                    }
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktorlar listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti()))
                {
                    komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Duyuru Oluşturuldu.");
                    RchDuyuru.Clear(); // Textbox'ı temizle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyuru oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();

        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frb = new FrmBransPaneli(); 
            frb.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            
            FrmDuyurular frl = new FrmDuyurular();
            frl.Show();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();

        }

        private void LblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
