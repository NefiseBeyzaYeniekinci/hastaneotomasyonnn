using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hastaneotomasyonnn
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDuyurular_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Veri tabanından duyuruları çekmek için DataTable kullanıyoruz
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Duyurular", bgl.baglanti());
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                bgl.baglanti().Close(); // Bağlantıyı kapatalım
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyurular yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gerekirse buraya tıklama işlemlerini ekleyebilirsiniz
        }
    }
}