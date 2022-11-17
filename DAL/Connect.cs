using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Connect
    {
        public static SqlConnection db = new SqlConnection("Data Source=304-015;Initial Catalog=nkatmanli;User ID=sa;Password=1234");
    }
}
