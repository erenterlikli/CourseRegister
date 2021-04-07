using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection baglan = new SqlConnection(@"Data Source=EREN\SQLEXPRESS;Initial Catalog=YazOkulu;Integrated Security=True");

    }
}
