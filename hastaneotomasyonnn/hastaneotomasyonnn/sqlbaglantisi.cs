using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace hastaneotomasyonnn
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-5H1QITST\\SQLEXPRESS;Initial Catalog=HastaneOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
